using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace zÉbET.ZEBET_verFinal.Main.DESPORTOS.images
{
    public partial class baseball : System.Web.UI.Page
    {
        XmlDocument doc = new XmlDocument();
      
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void rdbHoquei_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rdbFutebol_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        protected void rdbBasket_CheckedChanged(object sender, EventArgs e)
        {
          
          
        }

        protected void rdbVolei_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        protected void rdbSnooker_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void Basebol_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        protected void brnRefresh_Click(object sender, EventArgs e)
        {
            doc.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            int idx = 0, idx2 = 0, idx3 = 0;
            if (rdbHoquei.Checked == true)
            {
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[1].Value == "Basebol" && node.Attributes[5].Value == "0")
                    {
                        if (node.Attributes[2].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                                idx++;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                                idx++;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                                idx++;
                            }
                        }
                        if (node.Attributes[2].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label4.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label5.Visible = true;
                                idx2++;
                            }
                            if (idx2 == 2)
                            {
                                Label7.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label7.Visible = true;
                                idx2++;
                            }
                        }
                        if (node.Attributes[2].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label8.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 1)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label8.Visible = true;
                                idx3++;
                            }
                            if (idx3 == 2)
                            {
                                Label9.Text = node.Attributes[0].Value+node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label9.Visible = true;
                                idx3++;
                            }
                        }
                    }
                }
            }
            if (rdbFutebol.Checked == true)
            {
                idx = 0; idx2 = 0; idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[1].Value == "Futebol" && node.Attributes[5].Value == "0")
                    {
                        if (node.Attributes[2].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[0].Value+node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                                
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                                
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                               
                            }
                            idx++;
                        }
                        if (node.Attributes[2].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label4.Visible = true;
                                
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label5.Visible = true;
                                
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label6.Visible = true;

                            }
                            idx2++;
                        }
                        if (node.Attributes[2].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label7.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                            }
                            if (idx3 == 1)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                            }
                            if (idx3 == 2)
                            {
                                Label9.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                            }
                            idx3++;
                        }
                    }
                }
            }
            if (rdbBasket.Checked == true)
            {
                idx = 0; idx2 = 0; idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[1].Value == "Basket" && node.Attributes[5].Value == "0")
                    {
                        if (node.Attributes[2].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                                
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                             
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                                
                            }
                            idx++;
                        }
                        if (node.Attributes[2].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label4.Visible = true;
                                
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label5.Visible = true;
                                
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label6.Visible = true;
                                
                            }
                            idx2++;
                        }
                        if (node.Attributes[2].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label7.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label7.Visible = true;
                                
                            }
                            if (idx3 == 1)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label8.Visible = true;
                                
                            }
                            if (idx3 == 2)
                            {
                                Label9.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label9.Visible = true;
                                
                            }
                            idx3++;
                        }
                    }
                }
            }
            if (rdbVolei.Checked == true)
            {
                idx = 0; idx2 = 0; idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[1].Value == "Volei" && node.Attributes[5].Value == "0")
                    {
                        if (node.Attributes[2].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                                
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                                
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                                
                            }
                            idx++;
                        }
                        if (node.Attributes[2].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label4.Visible = true;
                                
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label5.Visible = true;
                                
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label6.Visible = true;
                                
                            }
                            idx2++;
                        }
                        if (node.Attributes[2].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label7.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label7.Visible = true;
                                
                            }
                            if (idx3 == 1)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label8.Visible = true;
                                
                            }
                            if (idx3 == 2)
                            {
                                Label9.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label9.Visible = true;
                                
                            }
                            idx3++;
                        }
                    }
                }
            }
            if (rdbSnooker.Checked == true)
            {
                idx = 0; idx2 = 0; idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[1].Value == "Snooker" && node.Attributes[5].Value == "0")
                    {
                        if (node.Attributes[2].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                                
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                                
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                                
                            }
                            idx++;
                        }
                        if (node.Attributes[2].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label4.Visible = true;
                                
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label5.Visible = true;
                                
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label6.Visible = true;
                                
                            }
                            idx2++;
                        }
                        if (node.Attributes[2].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label7.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label7.Visible = true;
                                
                            }
                            if (idx3 == 1)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label8.Visible = true;
                            }
                            if (idx3 == 2)
                            {
                                Label9.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label9.Visible = true;
                            }
                                idx3++;

                        }
                    }
                }
            }
            if (rdbBasebol.Checked == true)
            {
                idx = 0; idx2 = 0; idx3 = 0;
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
                {
                    if (node.Attributes[1].Value == "Basebol" && node.Attributes[5].Value == "0")
                    {
                        if (node.Attributes[2].Value == "pt")
                        {
                            if (idx == 0)
                            {
                                Label1.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label1.Visible = true;
                            }
                            if (idx == 1)
                            {
                                Label2.Text = node.Attributes[0].Value+ node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label2.Visible = true;
                            }
                            if (idx == 2)
                            {
                                Label3.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label3.Visible = true;
                            }
                            idx++;

                        }
                        if (node.Attributes[2].Value == "fr")
                        {
                            if (idx2 == 0)
                            {
                                Label4.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label4.Visible = true;
                            
                            }
                            if (idx2 == 1)
                            {
                                Label5.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label5.Visible = true;
                            }
                            if (idx2 == 2)
                            {
                                Label6.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label6.Visible = true;
                            }
                            idx2++;

                        }
                        if (node.Attributes[2].Value == "en")
                        {
                            if (idx3 == 0)
                            {
                                Label7.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label7.Visible = true;
                            
                            }
                            if (idx3 == 1)
                            {
                                Label8.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label8.Visible = true;
                            }
                            if (idx3 == 2)
                            {
                                Label9.Text = node.Attributes[0].Value + node.Attributes[3].Value + "[" + node.ChildNodes[0].Attributes[0].Value + "] " + "X[" + node.ChildNodes[1].Attributes[0].Value + "] " + node.Attributes[4].Value + "[" + node.ChildNodes[2].Attributes[0].Value + "]";
                                Label9.Visible = true;
                            }
                            idx3++;

                        }
                    }

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int saldo;
            if(txtAID.Text==""||txtAQ.Text==""||txtAW.Text=="")
            {
                Response.Write("<script> alert('Erro') </script>");
            }
            else
            {
                if (CheckUser(txtUser.Text) != txtPass.Text || txtPass.Text == "")
                {
                    Response.Write("<script> alert('Username ou Passowrd incorretas') </script>");
                }
                else
                {
                    if (txtAW.Text != "1" && txtAW.Text != "X" && txtAW.Text != "x" && txtAW.Text != "2")
                    { Response.Write("<script> alert('Aposta Invalida') </script>"); }
                    else
                    {
                        updateSaldo(txtUser.Text, Convert.ToInt32(txtAQ.Text));
                        Aposta(txtUser.Text, txtAW.Text, Convert.ToInt32(txtAQ.Text));
                    }
                }
            }

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
        private void updateSaldo(string user, int quant)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("Users"))
            {
                if (node.Name == "user")
                {
                    int saldo=Convert.ToInt32(Convert.ToDouble(node.Attributes[3].Value));
                    if (quant > saldo)
                    {
                        Response.Write("<script> alert('Saldo Insufeciente') </script>");
                    }
                    else
                    {
                        saldo -= quant;
                        node.Attributes[3].Value = saldo.ToString();
                    }
                }
            }
        }
        private void Aposta(string user, string Winner,int quant)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\i170015\\Source\\Repos\\Z-Bet\\zÉbET\\data.xml");

            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("Users"))
            {
                if (node.Name == "user")
                {
                    XmlNode jogo = doc.CreateElement("jogo");
                    XmlAttribute id = doc.CreateAttribute("id");
                    XmlNode aposta = doc.CreateElement("aposta");
                    XmlAttribute type = doc.CreateAttribute("type");
                    type.Value = Winner;
                    XmlAttribute amount = doc.CreateAttribute("amount");
                    amount.Value = quant.ToString();
                    aposta.Attributes.Append(type);
                    aposta.Attributes.Append(amount);
                    jogo.AppendChild(aposta);
                    jogo.Attributes.Append(id);
                    node.SelectSingleNode("apostas").AppendChild(jogo);
                }
            }
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