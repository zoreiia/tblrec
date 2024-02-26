namespace tblrec
{
    partial class tmenu
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
            this.dataGridViewusers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxendereco = new System.Windows.Forms.TextBox();
            this.textBoxcpf = new System.Windows.Forms.TextBox();
            this.textBoxcelular = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.comboBoxnivel = new System.Windows.Forms.ComboBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonexcluir = new System.Windows.Forms.Button();
            this.buttonatualizar = new System.Windows.Forms.Button();
            this.buttoncadastro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonpesquisar = new System.Windows.Forms.Button();
            this.textBoxpesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewusers
            // 
            this.dataGridViewusers.AllowUserToAddRows = false;
            this.dataGridViewusers.AllowUserToDeleteRows = false;
            this.dataGridViewusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewusers.Location = new System.Drawing.Point(430, 58);
            this.dataGridViewusers.Name = "dataGridViewusers";
            this.dataGridViewusers.ReadOnly = true;
            this.dataGridViewusers.Size = new System.Drawing.Size(629, 417);
            this.dataGridViewusers.TabIndex = 0;
            this.dataGridViewusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewusers_CellContentClick);
            this.dataGridViewusers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewusers_CellMouseDoubleClick);
            this.dataGridViewusers.DoubleClick += new System.EventHandler(this.dataGridViewusers_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.textBoxendereco);
            this.panel1.Controls.Add(this.textBoxcpf);
            this.panel1.Controls.Add(this.textBoxcelular);
            this.panel1.Controls.Add(this.textBoxemail);
            this.panel1.Controls.Add(this.comboBoxnivel);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 387);
            this.panel1.TabIndex = 1;
            // 
            // textBoxendereco
            // 
            this.textBoxendereco.Location = new System.Drawing.Point(15, 344);
            this.textBoxendereco.Name = "textBoxendereco";
            this.textBoxendereco.Size = new System.Drawing.Size(179, 20);
            this.textBoxendereco.TabIndex = 6;
            this.textBoxendereco.TextChanged += new System.EventHandler(this.textBoxendereco_TextChanged);
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.Location = new System.Drawing.Point(15, 305);
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(179, 20);
            this.textBoxcpf.TabIndex = 5;
            // 
            // textBoxcelular
            // 
            this.textBoxcelular.Location = new System.Drawing.Point(15, 266);
            this.textBoxcelular.Name = "textBoxcelular";
            this.textBoxcelular.Size = new System.Drawing.Size(179, 20);
            this.textBoxcelular.TabIndex = 4;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(15, 227);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(179, 20);
            this.textBoxemail.TabIndex = 3;
            // 
            // comboBoxnivel
            // 
            this.comboBoxnivel.FormattingEnabled = true;
            this.comboBoxnivel.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.comboBoxnivel.Location = new System.Drawing.Point(15, 187);
            this.comboBoxnivel.Name = "comboBoxnivel";
            this.comboBoxnivel.Size = new System.Drawing.Size(179, 21);
            this.comboBoxnivel.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(15, 148);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(179, 20);
            this.senha.TabIndex = 1;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(15, 109);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(179, 20);
            this.user.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nível:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações do Usuário:";
            // 
            // buttonexcluir
            // 
            this.buttonexcluir.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonexcluir.Location = new System.Drawing.Point(295, 419);
            this.buttonexcluir.Name = "buttonexcluir";
            this.buttonexcluir.Size = new System.Drawing.Size(129, 56);
            this.buttonexcluir.TabIndex = 16;
            this.buttonexcluir.Text = "Excluir";
            this.buttonexcluir.UseVisualStyleBackColor = true;
            this.buttonexcluir.Click += new System.EventHandler(this.buttonexcluir_Click);
            // 
            // buttonatualizar
            // 
            this.buttonatualizar.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonatualizar.Location = new System.Drawing.Point(160, 419);
            this.buttonatualizar.Name = "buttonatualizar";
            this.buttonatualizar.Size = new System.Drawing.Size(129, 56);
            this.buttonatualizar.TabIndex = 15;
            this.buttonatualizar.Text = "Atualizar";
            this.buttonatualizar.UseVisualStyleBackColor = true;
            this.buttonatualizar.Click += new System.EventHandler(this.buttonatualizar_Click);
            // 
            // buttoncadastro
            // 
            this.buttoncadastro.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttoncadastro.Location = new System.Drawing.Point(14, 419);
            this.buttoncadastro.Name = "buttoncadastro";
            this.buttoncadastro.Size = new System.Drawing.Size(140, 56);
            this.buttoncadastro.TabIndex = 14;
            this.buttoncadastro.Text = "Cadastrar";
            this.buttoncadastro.UseVisualStyleBackColor = true;
            this.buttoncadastro.Click += new System.EventHandler(this.buttoncadastro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.Location = new System.Drawing.Point(430, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 43);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pesquisar por Nome:";
            // 
            // buttonpesquisar
            // 
            this.buttonpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpesquisar.Location = new System.Drawing.Point(917, 12);
            this.buttonpesquisar.Name = "buttonpesquisar";
            this.buttonpesquisar.Size = new System.Drawing.Size(142, 43);
            this.buttonpesquisar.TabIndex = 17;
            this.buttonpesquisar.Text = "Search";
            this.buttonpesquisar.UseVisualStyleBackColor = true;
            this.buttonpesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxpesquisar
            // 
            this.textBoxpesquisar.Location = new System.Drawing.Point(671, 27);
            this.textBoxpesquisar.Name = "textBoxpesquisar";
            this.textBoxpesquisar.Size = new System.Drawing.Size(240, 20);
            this.textBoxpesquisar.TabIndex = 18;
            // 
            // tmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 487);
            this.Controls.Add(this.textBoxpesquisar);
            this.Controls.Add(this.buttonpesquisar);
            this.Controls.Add(this.buttonexcluir);
            this.Controls.Add(this.buttonatualizar);
            this.Controls.Add(this.buttoncadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewusers);
            this.Controls.Add(this.label9);
            this.Name = "tmenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewusers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewusers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox textBoxendereco;
        private System.Windows.Forms.TextBox textBoxcpf;
        private System.Windows.Forms.TextBox textBoxcelular;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.ComboBox comboBoxnivel;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button buttonexcluir;
        private System.Windows.Forms.Button buttonatualizar;
        private System.Windows.Forms.Button buttoncadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonpesquisar;
        private System.Windows.Forms.TextBox textBoxpesquisar;
    }
}