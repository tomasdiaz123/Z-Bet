using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
namespace zÉbET
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegista_Click(object sender, EventArgs e)
        {
            string Error = validatePass(txtPassword.Text);
            if(Error!=null)
            {
                errorLabel.Text = Error;
                errorLabel.Visible = true;
            }
            else
                errorLabel.Visible = false;
            if (txtPassword.Text != txtRePassword.Text)
            {
                lblMatchPass.Text = "Passwords não combinam";
                lblMatchPass.Visible = true;
            }
            else
                lblMatchPass.Visible = false;
            if(txtUtilizador.Text=="")
            {
                lblUtilizador.Text = "Campo Obrigatório";
                lblUtilizador.Visible = true;
            }
            
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }
        public string validatePass (string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Password should not be empty";

            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChars = new Regex(@".{8,16}");
            Regex hasLowerChar = new Regex(@"[a-z]+");
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(password))
                return "Password should contain at least one lower case letter";

            if (!hasUpperChar.IsMatch(password))
                return "Password should contain at least one upper case letter";

            if (!hasMiniMaxChars.IsMatch(password))
                return "Password should be between 3 and 16 characters long";

            if (!hasNumber.IsMatch(password))
                return "Password should contain at least one numeric value";

            if (!hasSymbols.IsMatch(password))
                return "Password should contain at least one special case character";

            return "";
        }
    }
}