namespace backOffice
{
    partial class FormAddJogo
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
            this.txtE1 = new System.Windows.Forms.TextBox();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.numE1 = new System.Windows.Forms.NumericUpDown();
            this.numE2 = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.txtLiga = new System.Windows.Forms.TextBox();
            this.cbbModalidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEquipa1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.SuspendLayout();
            // 
            // txtE1
            // 
            this.txtE1.Location = new System.Drawing.Point(33, 89);
            this.txtE1.Name = "txtE1";
            this.txtE1.Size = new System.Drawing.Size(120, 20);
            this.txtE1.TabIndex = 0;
            // 
            // txtE2
            // 
            this.txtE2.Location = new System.Drawing.Point(354, 90);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(129, 20);
            this.txtE2.TabIndex = 1;
            // 
            // numE1
            // 
            this.numE1.DecimalPlaces = 2;
            this.numE1.Location = new System.Drawing.Point(159, 89);
            this.numE1.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.numE1.Name = "numE1";
            this.numE1.Size = new System.Drawing.Size(59, 20);
            this.numE1.TabIndex = 2;
            this.numE1.Value = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            // 
            // numE2
            // 
            this.numE2.DecimalPlaces = 2;
            this.numE2.Location = new System.Drawing.Point(289, 90);
            this.numE2.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.numE2.Name = "numE2";
            this.numE2.Size = new System.Drawing.Size(59, 20);
            this.numE2.TabIndex = 3;
            this.numE2.Value = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            // 
            // numX
            // 
            this.numX.DecimalPlaces = 2;
            this.numX.Location = new System.Drawing.Point(224, 89);
            this.numX.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(59, 20);
            this.numX.TabIndex = 4;
            this.numX.Value = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            // 
            // txtLiga
            // 
            this.txtLiga.Location = new System.Drawing.Point(169, 38);
            this.txtLiga.Name = "txtLiga";
            this.txtLiga.Size = new System.Drawing.Size(100, 20);
            this.txtLiga.TabIndex = 5;
            // 
            // cbbModalidade
            // 
            this.cbbModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbModalidade.FormattingEnabled = true;
            this.cbbModalidade.Items.AddRange(new object[] {
            "Futebol",
            "Basquetebol",
            "Basebol",
            "Hoquei",
            "Tenis",
            "Snooker"});
            this.cbbModalidade.Location = new System.Drawing.Point(32, 37);
            this.cbbModalidade.Name = "cbbModalidade";
            this.cbbModalidade.Size = new System.Drawing.Size(121, 21);
            this.cbbModalidade.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liga";
            // 
            // lblEquipa1
            // 
            this.lblEquipa1.AutoSize = true;
            this.lblEquipa1.Location = new System.Drawing.Point(30, 73);
            this.lblEquipa1.Name = "lblEquipa1";
            this.lblEquipa1.Size = new System.Drawing.Size(46, 13);
            this.lblEquipa1.TabIndex = 9;
            this.lblEquipa1.Text = "Equipa1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Equipa2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(408, 139);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormAddJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 176);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEquipa1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbModalidade);
            this.Controls.Add(this.txtLiga);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.numE2);
            this.Controls.Add(this.numE1);
            this.Controls.Add(this.txtE2);
            this.Controls.Add(this.txtE1);
            this.Name = "FormAddJogo";
            this.Text = "Novo Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.numE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtE1;
        private System.Windows.Forms.TextBox txtE2;
        private System.Windows.Forms.NumericUpDown numE1;
        private System.Windows.Forms.NumericUpDown numE2;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.TextBox txtLiga;
        private System.Windows.Forms.ComboBox cbbModalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEquipa1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
    }
}