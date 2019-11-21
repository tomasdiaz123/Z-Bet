using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Xml;
namespace zÉbET
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
        }
        protected void Label1_Click(object sender, EventArgs e)
        {
            if(Label1.Text== "és membro do ZÉ.BET? Clica aqui para iniciar sessão")
            {
                Label1.Text="Ainda nao tens conta?Clica aqui para te registares";
                txtRePassword.Visible = false;
            }
            else
            {
                Label1.Text = "és membro do ZÉ.BET? Clica aqui para iniciar sessão";
                txtRePassword.Visible = true;
            }

        }

        protected void btnRegista_Click(object sender, EventArgs e)
        {
            lblMatchPass.ForeColor = System.Drawing.Color.Red;
            lblMatchPass.Visible = false;
            string msg;

            msg = ValidateUsername(txtUtilizador.Text);

            if (msg != "")
            {
                lblUtilizador.Visible = true;
                lblUtilizador.Text = msg;
            }
            else
            {
                lblUtilizador.Visible = false;
                msg = ValidatePassword(txtPassword.Text);

                if (msg != "")
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = msg;
                }
                else
                {
                    errorLabel.Visible = false;
                    if (txtPassword.Text != txtRePassword.Text)
                    {
                        lblMatchPass.Visible = true;
                        lblMatchPass.Text = "Passwords must be the same";
                    }
                    else
                    {
                        lblMatchPass.Visible = false;
                        XmlDocument doc = new XmlDocument();
                        doc.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

                        XmlNode Users = doc.SelectSingleNode("ZEBET").SelectSingleNode("Users");
                        XmlNode user = doc.CreateElement("user");

                        XmlAttribute name = doc.CreateAttribute("name");
                        name.InnerXml = txtUtilizador.Text;

                        XmlAttribute pass = doc.CreateAttribute("pass");
                        pass.InnerXml = txtPassword.Text;

                        XmlAttribute nivel = doc.CreateAttribute("nivel");
                        nivel.InnerXml = "user";

                        XmlAttribute saldo = doc.CreateAttribute("saldo");
                        saldo.InnerXml = "0";

                        user.Attributes.Append(name);
                        user.Attributes.Append(pass);
                        user.Attributes.Append(nivel);
                        user.Attributes.Append(saldo);

                        Users.AppendChild(user);

                        doc.Save("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");
                        lblMatchPass.ForeColor= System.Drawing.Color.Green;
                        lblMatchPass.Visible = true;
                        lblMatchPass.Text = "User criado com sucesso";
                    }
                }
                
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            Label4.Visible = true;
            if (CheckUser(txtUsernameL.Text) != txtPassowordL.Text || txtPassowordL.Text == "")
            {
                Label4.ForeColor= System.Drawing.Color.Red;
                Label4.Text="Username ou password incorreta";
            }
            else
            {
                Label4.ForeColor = System.Drawing.Color.Green;
                Label4.Text="Sucesso";
                Label5.Text = "<left>Olá " + txtUsernameL.Text+"</left>";
                Label6.Text = "<left>" + "O seu saldo é:"+ GetSaldo(txtUsernameL.Text) ;
            }
        }
        private string ValidatePassword(string password)
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
                return "Password should be between 8 and 16 characters long";

            if (!hasNumber.IsMatch(password))
                return "Password should contain at least one numeric value";

            if (!hasSymbols.IsMatch(password))
                return "Password should contain at least one special case character";

            if (txtPassword.Text != txtRePassword.Text)
                return "Passwords do not match";

            return "";
        }

        private string ValidateUsername(string user)
        {
            if (CheckUser(user) != "")
                return "Username já registado";

            if (string.IsNullOrWhiteSpace(user))
                return "User should not be empty";

            Regex hasMiniMaxChars = new Regex(@".{3,16}");

            if (!hasMiniMaxChars.IsMatch(user))
                return "Username should be between 3 and 16 characters long";

            return "";
        }

        private string CheckUser(string user)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("Users"))
            {
                if (node.Name == "user")
                {
                    XmlAttributeCollection xmlAtr = node.Attributes;

                    if (node.Attributes[0].Value == user)
                        return node.Attributes[1].Value;
                }
            }
            return "";
        }
        private string GetSaldo(string user)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("Users"))
            {
                if (node.Name == "user")
                {
                    XmlAttributeCollection xmlAtr = node.Attributes;

                    if (node.Attributes[0].Value == user)
                        return node.Attributes[3].Value;
                }
            }
            return "0";
        }

    }
}