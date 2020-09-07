namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.logo = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.Login_txt = new System.Windows.Forms.TextBox();
            this.Senha_txt = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cumi_status = new System.Windows.Forms.TextBox();
            this.Entrar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Lavender;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.SlateBlue;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.MaximumSize = new System.Drawing.Size(999, 999);
            this.logo.MinimumSize = new System.Drawing.Size(379, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(601, 28);
            this.logo.TabIndex = 0;
            this.logo.Text = "Safety At Sea (SAS)";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_senha
            // 
            this.label_senha.BackColor = System.Drawing.Color.Transparent;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.Color.Black;
            this.label_senha.Location = new System.Drawing.Point(93, 105);
            this.label_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_senha.MaximumSize = new System.Drawing.Size(66, 22);
            this.label_senha.MinimumSize = new System.Drawing.Size(66, 22);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(66, 22);
            this.label_senha.TabIndex = 1;
            this.label_senha.Text = "SENHA:";
            this.label_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_txt
            // 
            this.Login_txt.Location = new System.Drawing.Point(198, 62);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Login_txt.MaximumSize = new System.Drawing.Size(999, 999);
            this.Login_txt.MinimumSize = new System.Drawing.Size(148, 22);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(334, 22);
            this.Login_txt.TabIndex = 3;
            // 
            // Senha_txt
            // 
            this.Senha_txt.Location = new System.Drawing.Point(198, 105);
            this.Senha_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Senha_txt.MaximumSize = new System.Drawing.Size(999, 999);
            this.Senha_txt.MinimumSize = new System.Drawing.Size(148, 22);
            this.Senha_txt.Name = "Senha_txt";
            this.Senha_txt.Size = new System.Drawing.Size(334, 22);
            this.Senha_txt.TabIndex = 4;
            this.Senha_txt.UseSystemPasswordChar = true;
            // 
            // label_login
            // 
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(93, 62);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.MaximumSize = new System.Drawing.Size(66, 22);
            this.label_login.MinimumSize = new System.Drawing.Size(66, 22);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(66, 22);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "LOGIN:";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(66, 22);
            this.label1.MinimumSize = new System.Drawing.Size(66, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "CUMI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cumi_status
            // 
            this.Cumi_status.Location = new System.Drawing.Point(198, 196);
            this.Cumi_status.Margin = new System.Windows.Forms.Padding(4);
            this.Cumi_status.MaximumSize = new System.Drawing.Size(999, 999);
            this.Cumi_status.Name = "Cumi_status";
            this.Cumi_status.Size = new System.Drawing.Size(81, 22);
            this.Cumi_status.TabIndex = 8;
            // 
            // Entrar_btn
            // 
            this.Entrar_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Entrar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Entrar_btn.Location = new System.Drawing.Point(445, 222);
            this.Entrar_btn.MaximumSize = new System.Drawing.Size(87, 23);
            this.Entrar_btn.MinimumSize = new System.Drawing.Size(87, 23);
            this.Entrar_btn.Name = "Entrar_btn";
            this.Entrar_btn.Size = new System.Drawing.Size(87, 23);
            this.Entrar_btn.TabIndex = 9;
            this.Entrar_btn.Text = "ENTRAR";
            this.Entrar_btn.UseVisualStyleBackColor = false;
            this.Entrar_btn.Click += new System.EventHandler(this.Entrar_btn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wave_and_bubbles;
            this.ClientSize = new System.Drawing.Size(599, 271);
            this.Controls.Add(this.Entrar_btn);
            this.Controls.Add(this.Cumi_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.Senha_txt);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(999, 999);
            this.MinimumSize = new System.Drawing.Size(394, 226);
            this.Name = "Login";
            this.Text = "SAS - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox Login_txt;
        private System.Windows.Forms.TextBox Senha_txt;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cumi_status;
        private System.Windows.Forms.Button Entrar_btn;
    }
}

