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
    public partial class Resultado : Form
    {
        public char Value{ get; set; }
        public Resultado(string team1, string team2)
        {
            InitializeComponent();
            rdbTeam1.Text = team1;
            rdbTeam2.Text = team2;
        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (((RadioButton)ctr).Checked == true)
                {
                    this.DialogResult = DialogResult.OK;
                    Value = Convert.ToChar(((RadioButton)ctr).Tag);
                    Close();
                }
            }
        }
    }
}
