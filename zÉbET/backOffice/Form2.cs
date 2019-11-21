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

namespace backOffice
{
    public partial class Form2 : Form
    {
        XmlDocument doc = new XmlDocument();

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            doc.Load("..\\..\\..\\data.xml");
            cbbNivel.Text = "user";
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            

            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("Users"))
            {
                if (node.Name == "user")
                {
                    //user nivel saldo
                    lvi = new ListViewItem();

                    lvi.Text = node.Attributes[0].Value;

                    lvsi = new ListViewItem.ListViewSubItem();

                    lvsi.Text = node.Attributes[2].Value;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();

                    lvsi.Text = node.Attributes[3].Value;
                    lvi.SubItems.Add(lvsi);

                    lsvUsers.Items.Add(lvi);
                }
            }
        }

        private void lsvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPass.Visible = (lsvUsers.SelectedItems.Count < 0);

            if (lsvUsers.SelectedItems.Count > 0)
            {
                txtPass.Visible = false;
                txtUserName.Text = lsvUsers.SelectedItems[0].Text;
                cbbNivel.Text = lsvUsers.SelectedItems[0].SubItems[1].Text;
                numSaldo.Value = Convert.ToDecimal(lsvUsers.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                txtPass.Visible = true;
                txtUserName.Text = "";
                txtPass.Text = "";
                numSaldo.Value = 0;
                cbbNivel.Text = "user";
            }
        }

      
        private void btnSave_Click(object sender, EventArgs e)
        {
            doc.Save("..\\..\\..\\data.xml");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (lsvUsers.SelectedItems.Count > 0)
            {
                lsvUsers.SelectedItems[0].Text = txtUserName.Text;
                lsvUsers.SelectedItems[0].SubItems[1].Text = cbbNivel.Text;
                lsvUsers.SelectedItems[0].SubItems[2].Text = numSaldo.Value.ToString();


                doc.DocumentElement.SelectSingleNode("Users").ChildNodes[lsvUsers.SelectedIndices[0]].Attributes[0].Value = txtUserName.Text;
                doc.DocumentElement.SelectSingleNode("Users").ChildNodes[lsvUsers.SelectedIndices[0]].Attributes[2].Value = cbbNivel.Text;
                doc.DocumentElement.SelectSingleNode("Users").ChildNodes[lsvUsers.SelectedIndices[0]].Attributes[3].Value = numSaldo.Value.ToString();
            }
            else
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                XmlNode Users = doc.SelectSingleNode("ZEBET").SelectSingleNode("Users");
                XmlNode user = doc.CreateElement("user");

                XmlAttribute name = doc.CreateAttribute("name");
                name.InnerXml = txtUserName.Text;

                XmlAttribute pass = doc.CreateAttribute("pass");
                pass.InnerXml = txtPass.Text;

                XmlAttribute nivel = doc.CreateAttribute("nivel");
                nivel.InnerXml = cbbNivel.Text;

                XmlAttribute saldo = doc.CreateAttribute("saldo");
                saldo.InnerXml = numSaldo.Value.ToString();

                user.Attributes.Append(name);
                user.Attributes.Append(pass);
                user.Attributes.Append(nivel);
                user.Attributes.Append(saldo);

                Users.AppendChild(user);

                lvi = new ListViewItem();

                lvi.Text = txtUserName.Text;

                lvsi = new ListViewItem.ListViewSubItem();

                lvsi.Text = cbbNivel.Text;
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();

                lvsi.Text = numSaldo.Value.ToString();
                lvi.SubItems.Add(lvsi);

                lsvUsers.Items.Add(lvi);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || (string.IsNullOrWhiteSpace(txtPass.Text) && txtPass.Visible == true))
            {
                btnSend.Enabled = false;
            }
            else
            {
                btnSend.Enabled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || (string.IsNullOrWhiteSpace(txtPass.Text) && txtPass.Visible == true))
            {
                btnSend.Enabled = false;
            }
            else
            {
                btnSend.Enabled = true;
            }
        }
    }
}
