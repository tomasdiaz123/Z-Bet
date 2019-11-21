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
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\data.xml");

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
            ChangeEnabledCampos(lsvUsers.SelectedItems.Count >0);

            if (lsvUsers.SelectedItems.Count > 0)
            {
                txtUserName.Text = lsvUsers.SelectedItems[0].Text;
                cbbNivel.Text = lsvUsers.SelectedItems[0].SubItems[1].Text;
                numSaldo.Value = Convert.ToDecimal(lsvUsers.SelectedItems[0].SubItems[2].Text) /100;
            }
            else
            {
                txtUserName.Text = "";

               
                numSaldo.Value = 0;
            }
        }

        private void ChangeEnabledCampos(bool a)
        {
            txtUserName.Enabled = a;
            numSaldo.Enabled = a;
            cbbNivel.Enabled = a;
            btnReset.Enabled = a;
            btnSave.Enabled = a;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lsvUsers.SelectedItems[0].Text = txtUserName.Text;
            lsvUsers.SelectedItems[0].SubItems[1].Text = cbbNivel.Text;
            lsvUsers.SelectedItems[0].SubItems[2].Text = numSaldo.Value.ToString();
        }
    }
}
