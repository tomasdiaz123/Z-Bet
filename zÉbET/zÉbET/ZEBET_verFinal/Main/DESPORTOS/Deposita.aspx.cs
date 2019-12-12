//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Xml;

//namespace zÉbET.ZEBET_verFinal.Main.DESPORTOS.images
//{
//    public partial class baseball : System.Web.UI.Page
//    {
//        XmlDocument dox22 = new XmlDocument();
    
//        private string ValidateUsername2(string user)
//        {
//            if (CheckUser(user) != "")
//                return "Username já registado";

//            if (string.IsNullOrWhiteSpace(user))
//                return "User should not be empty";

//            Regex hasMiniMaxChars = new Regex(@".{3,16}");

//            if (!hasMiniMaxChars.IsMatch(user))
//                return "Username should be between 3 and 16 characters long";

//            return "";
//        }

//        private string CheckUser2(string user)
//        {
//            XmlDocument dox2 = new XmlDocument();
//            dox2.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

//            foreach (XmlNode node in dox2.DocumentElement.SelectSingleNode("Users"))
//            {
//                if (node.Name == "user")
//                {
//                    XmlAttributeCollection xmlAtr = node.Attributes;

//                    if (node.Attributes[0].Value == user)
//                        return node.Attributes[1].Value;
//                }
//            }
//            return "";
//        }
//        private void updateSaldo2(string user, int quant)
//        {
            
//            XmlDocument dox2 = new XmlDocument();
//            dox2.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

//            foreach (XmlNode node in dox2.DocumentElement.SelectSingleNode("Users"))
//            {
//                if (node.Name == "user")
//                {
//                    int saldo=Convert.ToInt32(node.Attributes[3].Value);
//                    if (quant > saldo)
//                    {
//                        Response.Write("<script> alert('Saldo Insufeciente') </script>");
//                    }
//                    else
//                    {
//                        saldo += quant;
//                        node.Attributes[3].Value = saldo.ToString();
//                    }
//                }
//            }
//        }
//        private void Aposta2(string user, string Winner,int quant)
//        {

//            XmlDocument dox2 = new XmlDocument();
//            dox2.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

//            foreach (XmlNode node in dox2.DocumentElement.SelectSingleNode("Users"))
//            {
//                if (node.Name == "user")
//                {
//                    node.ChildNodes[node.ChildNodes.Count].Attributes[0].Value= Winner;
//                    node.ChildNodes[node.ChildNodes.Count].Attributes[1].Value = quant.ToString();
//                }
//            }
//        }
//        private string GetSaldo2(string user)
//        {
//            XmlDocument dox2 = new XmlDocument();
//            dox2.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

//            foreach (XmlNode node in dox2.DocumentElement.SelectSingleNode("Users"))
//            {
//                if (node.Name == "user")
//                {
//                    XmlAttributeCollection xmlAtr = node.Attributes;

//                    if (node.Attributes[0].Value == user)
//                        return node.Attributes[3].Value;
//                }
//            }
//            return "0";
//        }

//        protected void btnAcre_Click(object sender, EventArgs e)
//        {
//            int saldo;
//            if (txtAcre.Text == "" || TextBox1.Text == "" || TextBox2.Text == "")
//            {
//                Response.Write("<script> alert('Erro') </script>");
//            }
//            else
//            {
//                if (CheckUser(TextBox1.Text) != TextBox2.Text || TextBox2.Text == "")
//                {
//                    Response.Write("<script> alert('Username ou Passowrd incorretas') </script>");
//                }
//                else
//                {
//                    if (Convert.ToInt32(txtAW.Text )<0)
//                    { Response.Write("<script> alert('Invalido') </script>"); }
//                    else
//                    {
//                        updateSaldo2(TextBox1.Text, Convert.ToInt32(txtAcre.Text));
//                    }
//                }
//            }

//        }
//    }
//}