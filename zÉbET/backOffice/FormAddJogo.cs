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
        int idJogo;   
        public FormAddJogo(int id)
        {
            InitializeComponent();
            idJogo = id;
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
                this.DialogResult = DialogResult.OK;
                jogo = new Jogo(idJogo, cbbModalidade.Text, txtLiga.Text, txtE1.Text, txtE2.Text,new double[]{ Convert.ToDouble(numE1.Value), Convert.ToDouble(numX.Value), Convert.ToDouble(numE2.Value) });
                this.Close();
            }
        }
    }

    public class Jogo
    {
        public int idJogo;
        public string modalidade,liga,team1, team2;
        public double[] odds;

        
        public Jogo(int id, string m, string l, string t1, string t2, double[] od)
        {
            idJogo = id;
            modalidade = m;
            liga = l;
            team1 = t1;
            team2 = t2;
            odds = new double[3];
            odds = od;
        }
    }
}
