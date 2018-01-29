using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stefanini.Web.App.Pages
{
    public partial class LoginPage : StefaniniPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.UserName.Value.Length == 0)
            {
                this.UserName.Focus();
            }
            else
            {
                this.Password.Focus();
            }
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.UserName.Value))
            {
                this.LoginErrorLiteral.Text = "O Nome do Usuário é Obrigatório.";
                this.MessageDiv.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(this.Password.Value))
            {
                this.LoginErrorLiteral.Text = "A Senha é Obrigatória.";
                this.MessageDiv.Visible = true;
                return;
            }

            // Do Login
            string loginResult = this.Login(this.UserName.Value, this.Password.Value, false);

            if (loginResult != "OK")
            {
                this.LoginErrorLiteral.Text = loginResult;
                this.MessageDiv.Visible = true;
                return;
            }

            Response.Redirect("/customerlist");

        }
    }
}