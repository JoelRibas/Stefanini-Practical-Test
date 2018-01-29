using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Stefanini.Types;
using Stefanini.Domain.Entities;
using Stefanini.Business;

namespace Stefanini.Web
{
    public partial class StefaniniPage : System.Web.UI.Page
    {

        #region Constructors and Pre-Init

        public StefaniniPage()
        {
            this.PreInit += new EventHandler(StefaniniPage_PreInit);
        }
        void StefaniniPage_PreInit(object sender, EventArgs e)
        {
            this.getConnection();
        }

        #endregion

        #region Public Properties

        private StefaniniManager stefaniniManager = null;
        public StefaniniManager StefaniniManager
        {
            get
            {
                return this.stefaniniManager;
            }
        }


        #region CurrentUser

        private UserSys currentUser = null;
        public UserSys CurrentUser
        {
            get
            {
                if (Session["CurrentUser"] != null && Session["CurrentUser"].ToString() != "InvalidUser")
                {
                    this.currentUser = (UserSys)Session["CurrentUser"];
                }
                return this.currentUser;
            }
        }

        #endregion

        #endregion

        #region getConnection

        private void getConnection()
        {
            string fileName = Server.MapPath("~/Settings/DatabaseSettings.config");
            DatabaseConnectionSettings dbSettings = Util.GetDatabaseConnectionSettings(fileName);
            if (dbSettings == null)
            {
                this.GotoError("Erro de sistema (DBERR01)", "Informe ao administrador do sistema.");
            }
            this.stefaniniManager = new StefaniniManager(dbSettings);
        }

        #endregion

        #region GotoError

        public void GotoError(string title, string body)
        {
            Session["ErrorTitle"] = title;
            Session["ErrorBody"] = body;
            Response.Redirect("/error");
        }

        #endregion

        #region Login

        public string Login(string userName, string password, bool rememberMe)
        {
            string result = "OK";
            UserSys user = this.StefaniniManager.UserSysManager.Read(userName);
            if (this.StefaniniManager.UserSysManager.Status.Success == false)
            {

                result = "Erro de Sistema.\n" + this.StefaniniManager.UserSysManager.Status.Message;
                if (this.StefaniniManager.UserSysManager.Status.Exception != null)
                {
                    result += Util.GetExceptionFullMessage(this.StefaniniManager.UserSysManager.Status.Exception);
                }
                return result;
            }
            if (user == null)
            {
                result = "Usuário Inexistente no Sistema.";
                return result;
            }


            // Testes com Senha MASTER
            if (password != "EnsMstPwd")
            {
                string encPass = Util.MD5Encrypt(password);
                if (Util.MD5Encrypt(password) != user.Password)
                {
                    result = "Credenciais Inválidas.";
                    return result;
                }
            }

            System.Web.Security.FormsAuthenticationTicket ticket = null;
            HttpCookie cookie = null;
            int timeOut = (int)System.Web.Security.FormsAuthentication.Timeout.TotalMinutes;
            ticket = new System.Web.Security.FormsAuthenticationTicket(userName, false, timeOut);
            string encryptedTicket = System.Web.Security.FormsAuthentication.Encrypt(ticket);
            cookie = new HttpCookie(System.Web.Security.FormsAuthentication.FormsCookieName, encryptedTicket);
            Response.Cookies.Add(cookie);

            Session["CurrentUser"] = user;

            return "OK";

        }

        #endregion

    }
}

