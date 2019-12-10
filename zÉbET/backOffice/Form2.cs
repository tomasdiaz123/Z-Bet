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
            
            // preencher listview dos users
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

            foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("jogos"))
            {
                
                int idJogo = Convert.ToInt32(node.Attributes[0].Value);
                string modalidade = node.Attributes[1].Value;
                string liga = node.Attributes[2].Value;
                string e1 = node.Attributes[3].Value;
                string e2 = node.Attributes[4].Value;

                double[] odds = { Convert.ToDouble(node.ChildNodes[0].Attributes[0].Value),
                    Convert.ToDouble(node.ChildNodes[1].Attributes[0].Value),
                    Convert.ToDouble(node.ChildNodes[2].Attributes[0].Value) };
                lsvAddJogo(new Jogo(idJogo, modalidade, liga, e1, e2, odds));
            }
        }

        private void lsvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPass.Visible = (lsvUsers.SelectedItems.Count < 0);

            if (lsvUsers.SelectedItems.Count > 0)
            {
                txtPass.Visible = false;
                lblPassword.Visible = false;
                txtUserName.Text = lsvUsers.SelectedItems[0].Text;
                cbbNivel.Text = lsvUsers.SelectedItems[0].SubItems[1].Text;
                numSaldo.Value = Convert.ToDecimal(lsvUsers.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                txtPass.Visible = true;
                lblPassword.Visible = true;
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

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            int id = lsvJogos.Items.Count;
           
            FormAddJogo formAddGame = new FormAddJogo(id);

            

            if (formAddGame.ShowDialog() == DialogResult.OK)
            {
                lsvAddJogo(formAddGame.jogo);
            }
        }

        private void lsvAddJogo (Jogo jogo)
        {
            //id    modalidade  liga    equipa1 odd1 oddX odd2 equipa2
            ListViewItem lvi = new ListViewItem();

            lvi.Text = jogo.idJogo.ToString();

            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.modalidade;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.liga;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.team1;
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.odds[0].ToString();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.odds[1].ToString();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.odds[2].ToString();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();

            lvsi.Text = jogo.team2;
            lvi.SubItems.Add(lvsi);

            lsvJogos.Items.Add(lvi);

        }

        private void lsvJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvJogos.SelectedIndices.Count!=0)
            {
                numOdd1.Enabled = true;
                numOddX.Enabled = true;
                numOdd2.Enabled = true;
                txtTeam1.Text = lsvJogos.SelectedItems[0].SubItems[3].Text;
                txtTeam2.Text = lsvJogos.SelectedItems[0].SubItems[7].Text;
                numOdd1.Value = Convert.ToDecimal(lsvJogos.SelectedItems[0].SubItems[4].Text);
                numOddX.Value = Convert.ToDecimal(lsvJogos.SelectedItems[0].SubItems[5].Text);
                numOdd2.Value = Convert.ToDecimal(lsvJogos.SelectedItems[0].SubItems[6].Text);
            }
            else
            {
                txtTeam1.Text = "";
                txtTeam2.Text = "";
                numOdd1.Enabled = false;
                numOddX.Enabled = false;
                numOdd2.Enabled = false;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (lsvJogos.SelectedIndices.Count != 0)
            {
                lsvJogos.SelectedItems[0].SubItems[4].Text = numOdd1.Value.ToString();
                lsvJogos.SelectedItems[0].SubItems[5].Text = numOddX.Value.ToString();
                lsvJogos.SelectedItems[0].SubItems[6].Text = numOdd2.Value.ToString();
            }
        }
    }
}
