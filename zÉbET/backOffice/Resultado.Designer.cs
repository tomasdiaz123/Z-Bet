namespace backOffice
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTeam1 = new System.Windows.Forms.RadioButton();
            this.rdbEmpate = new System.Windows.Forms.RadioButton();
            this.rdbTeam2 = new System.Windows.Forms.RadioButton();
            this.bntConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTeam2);
            this.groupBox1.Controls.Add(this.rdbEmpate);
            this.groupBox1.Controls.Add(this.rdbTeam1);
            this.groupBox1.Location = new System.Drawing.Point(12, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdbTeam1
            // 
            this.rdbTeam1.AutoSize = true;
            this.rdbTeam1.Location = new System.Drawing.Point(22, 19);
            this.rdbTeam1.Name = "rdbTeam1";
            this.rdbTeam1.Size = new System.Drawing.Size(85, 17);
            this.rdbTeam1.TabIndex = 0;
            this.rdbTeam1.TabStop = true;
            this.rdbTeam1.Tag = "1";
            this.rdbTeam1.Text = "radioButton1";
            this.rdbTeam1.UseVisualStyleBackColor = true;
            // 
            // rdbEmpate
            // 
            this.rdbEmpate.AutoSize = true;
            this.rdbEmpate.Location = new System.Drawing.Point(22, 42);
            this.rdbEmpate.Name = "rdbEmpate";
            this.rdbEmpate.Size = new System.Drawing.Size(61, 17);
            this.rdbEmpate.TabIndex = 1;
            this.rdbEmpate.TabStop = true;
            this.rdbEmpate.Tag = "X";
            this.rdbEmpate.Text = "Empate";
            this.rdbEmpate.UseVisualStyleBackColor = true;
            // 
            // rdbTeam2
            // 
            this.rdbTeam2.AutoSize = true;
            this.rdbTeam2.Location = new System.Drawing.Point(22, 65);
            this.rdbTeam2.Name = "rdbTeam2";
            this.rdbTeam2.Size = new System.Drawing.Size(85, 17);
            this.rdbTeam2.TabIndex = 2;
            this.rdbTeam2.TabStop = true;
            this.rdbTeam2.Tag = "2";
            this.rdbTeam2.Text = "radioButton3";
            this.rdbTeam2.UseVisualStyleBackColor = true;
            // 
            // bntConfirm
            // 
            this.bntConfirm.Location = new System.Drawing.Point(174, 58);
            this.bntConfirm.Name = "bntConfirm";
            this.bntConfirm.Size = new System.Drawing.Size(75, 23);
            this.bntConfirm.TabIndex = 3;
            this.bntConfirm.Text = "Confirmar";
            this.bntConfirm.UseVisualStyleBackColor = true;
            this.bntConfirm.Click += new System.EventHandler(this.bntConfirm_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 93);
            this.Controls.Add(this.bntConfirm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTeam2;
        private System.Windows.Forms.RadioButton rdbEmpate;
        private System.Windows.Forms.RadioButton rdbTeam1;
        private System.Windows.Forms.Button bntConfirm;
    }
}