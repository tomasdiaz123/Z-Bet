using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backOffice
{
    public partial class FormAddJogo : Form
    {
        public Jogo jogo;   
        public FormAddJogo()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (string.IsNullOrWhiteSpace(cbbModalidade.Text))
                msg = "Selecione uma modalidade";
            if (string.IsNullOrWhiteSpace(txtLiga.Text))
                msg = "Indique uma liga";
            if (string.IsNullOrWhiteSpace(txtE1.Text))
                msg = "Campo Equipa1 vazio";
            if (numE1.Value == 0 || numX.Value == 0 || numE2.Value == 0)
                msg = "Preencha todas as odds";
            if (string.IsNullOrWhiteSpace(txtE2.Text))
                msg = "Campo Equipa2 vazio";

            if (msg!= "")
            {
                MessageBox.Show(msg, "Adicionar Jogo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                jogo = new Jogo(cbbModalidade.Text, txtLiga.Text, txtE1.Text, txtE2.Text, Convert.ToDouble(numE1.Value), Convert.ToDouble(numX.Value), Convert.ToDouble(numE2.Value));
                this.Close();
            }
        }
    }

    public class Jogo
    {
        public string modalidade,liga,team1, team2;
        public double[] odds;

        public Jogo(string m, string l, string t1, string t2, double odd1, double oddX, double odd2)
        {
            modalidade = m;
            liga = l;
            team1 = t1;
            team2 = t2;
            odds = new double[3];
            odds[0] = odd1;
            odds[1] = oddX;
            odds[2] = odd2;
        }
    }
}
