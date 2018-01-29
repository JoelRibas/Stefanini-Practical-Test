using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stefanini.Web.App
{
    public partial class Default : StefaniniPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Response.Redirect("~/login");
            //Response.Redirect("~/customerlist");


            //string loginResult = this.Login("admin@sellseverything.com", "admin123", false);
            //string loginResult = this.Login("seller1@sellseverything.com", "seller1123", false);
            string loginResult = this.Login("seller2@sellseverything.com", "seller2123", false);

            if (loginResult != "OK")
            {
                throw new Exception(loginResult);
            }

            Response.Redirect("/customerlist");


        }
    }
}