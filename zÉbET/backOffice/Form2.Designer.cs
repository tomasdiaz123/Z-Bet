namespace backOffice
{
    partial class Form2
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
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lsvUsers = new System.Windows.Forms.ListView();
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpJogos = new System.Windows.Forms.TabPage();
            this.numSaldo = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbNivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcTabs.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTabs
            // 
            this.tbcTabs.Controls.Add(this.tpUsers);
            this.tbcTabs.Controls.Add(this.tpJogos);
            this.tbcTabs.Location = new System.Drawing.Point(12, 20);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(453, 281);
            this.tbcTabs.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.label2);
            this.tpUsers.Controls.Add(this.label1);
            this.tpUsers.Controls.Add(this.cbbNivel);
            this.tpUsers.Controls.Add(this.btnSave);
            this.tpUsers.Controls.Add(this.btnReset);
            this.tpUsers.Controls.Add(this.numSaldo);
            this.tpUsers.Controls.Add(this.txtUserName);
            this.tpUsers.Controls.Add(this.lsvUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(445, 255);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(16, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(162, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lsvUsers
            // 
            this.lsvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsername,
            this.chNivel,
            this.chSaldo});
            this.lsvUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lsvUsers.Location = new System.Drawing.Point(6, 118);
            this.lsvUsers.Name = "lsvUsers";
            this.lsvUsers.Size = new System.Drawing.Size(433, 131);
            this.lsvUsers.TabIndex = 0;
            this.lsvUsers.UseCompatibleStateImageBehavior = false;
            this.lsvUsers.View = System.Windows.Forms.View.Details;
            this.lsvUsers.SelectedIndexChanged += new System.EventHandler(this.lsvUsers_SelectedIndexChanged);
            // 
            // chUsername
            // 
            this.chUsername.Text = "Name";
            this.chUsername.Width = 280;
            // 
            // chNivel
            // 
            this.chNivel.Text = "Nível";
            this.chNivel.Width = 50;
            // 
            // chSaldo
            // 
            this.chSaldo.Text = "Saldo";
            // 
            // tpJogos
            // 
            this.tpJogos.Location = new System.Drawing.Point(4, 22);
            this.tpJogos.Name = "tpJogos";
            this.tpJogos.Padding = new System.Windows.Forms.Padding(3);
            this.tpJogos.Size = new System.Drawing.Size(445, 255);
            this.tpJogos.TabIndex = 1;
            this.tpJogos.Text = "Jogos";
            this.tpJogos.UseVisualStyleBackColor = true;
            // 
            // numSaldo
            // 
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Enabled = false;
            this.numSaldo.Location = new System.Drawing.Point(199, 32);
            this.numSaldo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(99, 20);
            this.numSaldo.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(331, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(331, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbNivel
            // 
            this.cbbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNivel.Enabled = false;
            this.cbbNivel.FormattingEnabled = true;
            this.cbbNivel.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cbbNivel.Location = new System.Drawing.Point(16, 69);
            this.cbbNivel.Name = "cbbNivel";
            this.cbbNivel.Size = new System.Drawing.Size(121, 21);
            this.cbbNivel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 313);
            this.Controls.Add(this.tbcTabs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tbcTabs.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTabs;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpJogos;
        private System.Windows.Forms.ListView lsvUsers;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chNivel;
        private System.Windows.Forms.ColumnHeader chSaldo;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNivel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numSaldo;
    }
}