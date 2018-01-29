using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Stefanini.Domain.Entities;

namespace Stefanini.Web.App
{
    public partial class StefaniniSecurePage : StefaniniPage
    {

        #region Constructors and Init

        public StefaniniSecurePage()
        {
            this.Init += new EventHandler(StefaniniSecurePage_Init);
        }
        void StefaniniSecurePage_Init(object sender, EventArgs e)
        {
            this.verifyAuthentication();
        }

        #endregion

        #region Authentication and Authorization

        private void verifyAuthentication()
        {
            if (!Context.User.Identity.IsAuthenticated)
            {
                Response.Redirect("/Login");
            }
        }

        #endregion

        #region redirecToError

        private void redirecToError()
        {
            Session["ErrorTitle"] = "Acesso negado";
            Session["ErrorBody"] = "Você não tem autorização para acessar essa página.\nConsulte o administrador do Sistema.";
            Response.Redirect("~/Erro");
        }

        #endregion

    }
}

