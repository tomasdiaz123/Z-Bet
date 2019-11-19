using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace ZeBet_BackOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string msg;

            msg = ValidateUsername(txtUser2.Text);

            if (msg != "")
                errorProvider1.SetError(txtUser2, msg);
            else
            {
                errorProvider1.Clear();
                msg = ValidatePassword(txtPass2.Text);

                if (msg != "")
                    errorProvider1.SetError(txtPass2, msg);
                else
                {
                    errorProvider1.Clear();
                    XmlDocument doc = new XmlDocument();
                    doc.Load("..\\..\\..\\..\\data.xml");

                    XmlNode Users = doc.SelectSingleNode("ZEBET").SelectSingleNode("Users");
                    XmlNode user = doc.CreateElement("user");

                    XmlAttribute name = doc.CreateAttribute("name");
                    name.InnerXml = txtUser2.Text;

                    XmlAttribute pass = doc.CreateAttribute("pass");
                    pass.InnerXml = txtPass2.Text;

                    XmlAttribute nivel = doc.CreateAttribute("nivel");
                    nivel.InnerXml = "user";

                    XmlAttribute saldo = doc.CreateAttribute("saldo");
                    saldo.InnerXml = "0";

                    user.Attributes.Append(name);
                    user.Attributes.Append(pass);
                    user.Attributes.Append(nivel);
                    user.Attributes.Append(saldo);

                    Users.AppendChild(user);

                    doc.Save("..\\..\\..\\..\\data.xml");
                    MessageBox.Show("Registado com sucessso!");
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckUser(txtUser.Text) != txtPass.Text || txtPass.Text == "")
            {
                MessageBox.Show("Username ou password incorreta", "Erro de Autenticação");
                txtPass.Clear();
            }
            else
            {
                MessageBox.Show("Sucesso");
                Form frm = new Form2();
                frm.Show();
                txtUser.Clear();
                txtPass.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass1.Checked == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass2.Checked == true)
            {
                txtPass2.UseSystemPasswordChar = false;
                txtRepeatPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass2.UseSystemPasswordChar = true;
                txtRepeatPass.UseSystemPasswordChar = true;
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

            if (txtPass2.Text != txtRepeatPass.Text)
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
            doc.Load("..\\..\\..\\..\\data.xml");

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

        
    }
}


