namespace tblrec
{
    partial class tlogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonentrar = new System.Windows.Forms.Button();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.textBoxsenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonentrar
            // 
            this.buttonentrar.Location = new System.Drawing.Point(139, 172);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(161, 58);
            this.buttonentrar.TabIndex = 0;
            this.buttonentrar.Text = "Entrar";
            this.buttonentrar.UseVisualStyleBackColor = true;
            this.buttonentrar.Click += new System.EventHandler(this.buttonentrar_Click);
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(73, 39);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(146, 20);
            this.textBoxusuario.TabIndex = 1;
            // 
            // textBoxsenha
            // 
            this.textBoxsenha.Location = new System.Drawing.Point(73, 75);
            this.textBoxsenha.Name = "textBoxsenha";
            this.textBoxsenha.PasswordChar = '*';
            this.textBoxsenha.Size = new System.Drawing.Size(146, 20);
            this.textBoxsenha.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxusuario);
            this.panel1.Controls.Add(this.textBoxsenha);
            this.panel1.Location = new System.Drawing.Point(81, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 133);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // tlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(447, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonentrar);
            this.Name = "tlogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.TextBox textBoxsenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

