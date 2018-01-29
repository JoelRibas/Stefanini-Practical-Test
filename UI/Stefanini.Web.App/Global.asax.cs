using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Stefanini.Web.App
{
    public class Global : System.Web.HttpApplication
    {

        #region Events

        protected void Application_Start(object sender, EventArgs e)
        {
            this.registerRoutes(System.Web.Routing.RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        #endregion

        #region Routes

        void registerRoutes(System.Web.Routing.RouteCollection routes)
        {

            routes.MapPageRoute("login", "login", "~/Pages/LoginPage.aspx", false);
            routes.MapPageRoute("customerlist", "customerlist", "~/Pages/CustomerListPage.aspx", false);

        }

        #endregion



    }
}