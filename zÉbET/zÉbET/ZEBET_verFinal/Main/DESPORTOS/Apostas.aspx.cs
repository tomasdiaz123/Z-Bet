using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace zÉbET.ZEBET_verFinal.Main.DESPORTOS.images
{
    public partial class baseball : System.Web.UI.Page
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("..\\..\\..\\data.xml");
        protected void Page_Load(object sender, EventArgs e)
        {
            rdbHoquei.Attributes.Add("onclick", "HideDOB()");
        }

        protected void rdbHoquei_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHoquei.Checked == true)
            {
                int idx = 0, idx2 = 0, idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[6].Value == "Basebol" && node.Attributes[2].Value == "0")
                    {
                        if (node.Attributes[5].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if (node.Attributes[5].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[5].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
        }

        protected void rdbFutebol_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFutebol.Checked == true)
            {
                int idx = 0, idx2 = 0, idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[6].Value == "Futebol" && node.Attributes[2].Value == "0")
                    {
                        if (node.Attributes[5].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if (node.Attributes[5].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[5].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
        }

        protected void rdbBasket_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBasket.Checked == true)
            {
                int idx = 0, idx2 = 0, idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[6].Value == "Basket" && node.Attributes[2].Value == "0")
                    {
                        if (node.Attributes[5].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if (node.Attributes[5].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[5].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
        }

        protected void rdbVolei_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVolei.Checked == true)
            {
                int idx = 0, idx2 = 0, idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[6].Value == "Volei" && node.Attributes[2].Value == "0")
                    {
                        if (node.Attributes[5].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if (node.Attributes[5].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[5].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
        }

        protected void rdbSnooker_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSnooker.Checked == true)
            {
                int idx = 0, idx2 = 0, idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[6].Value == "Snooker" && node.Attributes[2].Value == "0")
                    {
                        if (node.Attributes[5].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if (node.Attributes[5].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[5].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
        }

        protected void Basebol_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBasebol.Checked == true)
            {
                int idx = 0,idx2=0,idx3=0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[6].Value == "Basebol" && node.Attributes[2].Value == "0")
                    {
                        if (node.Attributes[5].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if(node.Attributes[5].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[5].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label4.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label1.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label5.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label2.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label6.Text = node.Attributes[5].Value + "[" + node.ChildNodes[2].Value + "] " + "X[" + node.ChildNodes[1].Value + "] " + node.Attributes[4] + "[" + node.ChildNodes[0].Value + "]";
                                Label3.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
        }
    }
}