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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNivel = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.numSaldo = new System.Windows.Forms.NumericUpDown();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lsvUsers = new System.Windows.Forms.ListView();
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpJogos = new System.Windows.Forms.TabPage();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModalidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLiga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeam1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOdd1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOddX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOdd2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeam2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcTabs.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
            this.tpJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTabs
            // 
            this.tbcTabs.Controls.Add(this.tpUsers);
            this.tbcTabs.Controls.Add(this.tpJogos);
            this.tbcTabs.Location = new System.Drawing.Point(12, 20);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(724, 440);
            this.tbcTabs.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.label3);
            this.tpUsers.Controls.Add(this.txtPass);
            this.tpUsers.Controls.Add(this.btnSave);
            this.tpUsers.Controls.Add(this.lblPassword);
            this.tpUsers.Controls.Add(this.label1);
            this.tpUsers.Controls.Add(this.cbbNivel);
            this.tpUsers.Controls.Add(this.btnSend);
            this.tpUsers.Controls.Add(this.numSaldo);
            this.tpUsers.Controls.Add(this.txtUserName);
            this.tpUsers.Controls.Add(this.lsvUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(716, 414);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saldo";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(178, 35);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(136, 20);
            this.txtPass.TabIndex = 9;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(175, 16);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // cbbNivel
            // 
            this.cbbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNivel.FormattingEnabled = true;
            this.cbbNivel.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cbbNivel.Location = new System.Drawing.Point(16, 83);
            this.cbbNivel.Name = "cbbNivel";
            this.cbbNivel.Size = new System.Drawing.Size(152, 21);
            this.cbbNivel.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(178, 147);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = ">>";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // numSaldo
            // 
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Location = new System.Drawing.Point(178, 83);
            this.numSaldo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(136, 20);
            this.numSaldo.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(16, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lsvUsers
            // 
            this.lsvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsername,
            this.chNivel,
            this.chSaldo});
            this.lsvUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lsvUsers.Location = new System.Drawing.Point(320, 16);
            this.lsvUsers.Name = "lsvUsers";
            this.lsvUsers.Size = new System.Drawing.Size(390, 392);
            this.lsvUsers.TabIndex = 0;
            this.lsvUsers.UseCompatibleStateImageBehavior = false;
            this.lsvUsers.View = System.Windows.Forms.View.Details;
            this.lsvUsers.SelectedIndexChanged += new System.EventHandler(this.lsvUsers_SelectedIndexChanged);
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 275;
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
            this.tpJogos.Controls.Add(this.btnResult);
            this.tpJogos.Controls.Add(this.btnClose);
            this.tpJogos.Controls.Add(this.btnNewGame);
            this.tpJogos.Controls.Add(this.label5);
            this.tpJogos.Controls.Add(this.label4);
            this.tpJogos.Controls.Add(this.label2);
            this.tpJogos.Controls.Add(this.btnSave2);
            this.tpJogos.Controls.Add(this.btnSend2);
            this.tpJogos.Controls.Add(this.numericUpDown3);
            this.tpJogos.Controls.Add(this.numericUpDown2);
            this.tpJogos.Controls.Add(this.numericUpDown1);
            this.tpJogos.Controls.Add(this.textBox2);
            this.tpJogos.Controls.Add(this.textBox1);
            this.tpJogos.Controls.Add(this.listView1);
            this.tpJogos.Location = new System.Drawing.Point(4, 22);
            this.tpJogos.Name = "tpJogos";
            this.tpJogos.Padding = new System.Windows.Forms.Padding(3);
            this.tpJogos.Size = new System.Drawing.Size(716, 414);
            this.tpJogos.TabIndex = 1;
            this.tpJogos.Text = "Jogos";
            this.tpJogos.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(107, 166);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 36);
            this.btnResult.TabIndex = 13;
            this.btnResult.Text = "Resultado";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Fechar Apostas";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(15, 373);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "Novo Jogo";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Equipa2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Empate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Equipa 1";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(188, 373);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 7;
            this.btnSave2.Text = "Guardar";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(198, 166);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(75, 36);
            this.btnSend2.TabIndex = 6;
            this.btnSend2.Text = ">>";
            this.btnSend2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(188, 124);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown3.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(188, 85);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(188, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chModalidade,
            this.chLiga,
            this.chTeam1,
            this.chOdd1,
            this.chOddX,
            this.chOdd2,
            this.chTeam2});
            this.listView1.Location = new System.Drawing.Point(279, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 402);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 48;
            // 
            // chModalidade
            // 
            this.chModalidade.Text = "Modalidade";
            this.chModalidade.Width = 78;
            // 
            // chLiga
            // 
            this.chLiga.Text = "Liga";
            this.chLiga.Width = 63;
            // 
            // chTeam1
            // 
            this.chTeam1.Text = "Equipa1";
            this.chTeam1.Width = 69;
            // 
            // chOdd1
            // 
            this.chOdd1.Text = "1";
            this.chOdd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOdd1.Width = 30;
            // 
            // chOddX
            // 
            this.chOddX.Text = "X";
            this.chOddX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOddX.Width = 30;
            // 
            // chOdd2
            // 
            this.chOdd2.Text = "2";
            this.chOdd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOdd2.Width = 30;
            // 
            // chTeam2
            // 
            this.chTeam2.Text = "Equipa2";
            this.chTeam2.Width = 77;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 472);
            this.Controls.Add(this.tbcTabs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tbcTabs.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            this.tpJogos.ResumeLayout(false);
            this.tpJogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNivel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.NumericUpDown numSaldo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chModalidade;
        private System.Windows.Forms.ColumnHeader chLiga;
        private System.Windows.Forms.ColumnHeader chTeam1;
        private System.Windows.Forms.ColumnHeader chOdd1;
        private System.Windows.Forms.ColumnHeader chOddX;
        private System.Windows.Forms.ColumnHeader chOdd2;
        private System.Windows.Forms.ColumnHeader chTeam2;
    }
}