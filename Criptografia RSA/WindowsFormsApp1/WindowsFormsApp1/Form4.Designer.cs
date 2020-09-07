namespace WindowsFormsApp1
{
    partial class Criptacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criptacao));
            this.suporte_2 = new System.Windows.Forms.DataGridView();
            this.label_encriptar = new System.Windows.Forms.Label();
            this.label_descriptar = new System.Windows.Forms.Label();
            this.label_chave_publica = new System.Windows.Forms.Label();
            this.label_chave_privada = new System.Windows.Forms.Label();
            this.chave_publica = new System.Windows.Forms.TextBox();
            this.chave_privada = new System.Windows.Forms.TextBox();
            this.msg_descriptada_en = new System.Windows.Forms.RichTextBox();
            this.msg_encriptada_en = new System.Windows.Forms.RichTextBox();
            this.msg_encriptada_de = new System.Windows.Forms.RichTextBox();
            this.msg_descriptada_de = new System.Windows.Forms.RichTextBox();
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.btn_descriptar = new System.Windows.Forms.Button();
            this.btn_voltar_2 = new System.Windows.Forms.Button();
            this.btn_ajuda = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.btn_mostrar_tamanho_msg_descriptada = new System.Windows.Forms.Button();
            this.btn_mostrar_tamanho_msg_encriptada = new System.Windows.Forms.Button();
            this.tamanho_msg_descriptada = new System.Windows.Forms.TextBox();
            this.tamanho_msg_encriptada = new System.Windows.Forms.TextBox();
            this.btn_imagens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suporte_2)).BeginInit();
            this.SuspendLayout();
            // 
            // suporte_2
            // 
            this.suporte_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suporte_2.Location = new System.Drawing.Point(17, 63);
            this.suporte_2.MaximumSize = new System.Drawing.Size(755, 486);
            this.suporte_2.Name = "suporte_2";
            this.suporte_2.Size = new System.Drawing.Size(755, 486);
            this.suporte_2.TabIndex = 4;
            // 
            // label_encriptar
            // 
            this.label_encriptar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_encriptar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_encriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_encriptar.Location = new System.Drawing.Point(26, 126);
            this.label_encriptar.MaximumSize = new System.Drawing.Size(107, 23);
            this.label_encriptar.MinimumSize = new System.Drawing.Size(107, 23);
            this.label_encriptar.Name = "label_encriptar";
            this.label_encriptar.Size = new System.Drawing.Size(107, 23);
            this.label_encriptar.TabIndex = 5;
            this.label_encriptar.Text = "ENCRIPTAR";
            this.label_encriptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_descriptar
            // 
            this.label_descriptar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_descriptar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_descriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descriptar.Location = new System.Drawing.Point(26, 341);
            this.label_descriptar.MaximumSize = new System.Drawing.Size(107, 23);
            this.label_descriptar.MinimumSize = new System.Drawing.Size(107, 23);
            this.label_descriptar.Name = "label_descriptar";
            this.label_descriptar.Size = new System.Drawing.Size(107, 23);
            this.label_descriptar.TabIndex = 6;
            this.label_descriptar.Text = "DESCRIPTAR";
            this.label_descriptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_chave_publica
            // 
            this.label_chave_publica.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_chave_publica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chave_publica.Location = new System.Drawing.Point(460, 126);
            this.label_chave_publica.MaximumSize = new System.Drawing.Size(107, 23);
            this.label_chave_publica.MinimumSize = new System.Drawing.Size(107, 23);
            this.label_chave_publica.Name = "label_chave_publica";
            this.label_chave_publica.Size = new System.Drawing.Size(107, 23);
            this.label_chave_publica.TabIndex = 7;
            this.label_chave_publica.Text = "Chave-pública:";
            this.label_chave_publica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_chave_privada
            // 
            this.label_chave_privada.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_chave_privada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chave_privada.Location = new System.Drawing.Point(460, 339);
            this.label_chave_privada.MaximumSize = new System.Drawing.Size(107, 23);
            this.label_chave_privada.MinimumSize = new System.Drawing.Size(107, 23);
            this.label_chave_privada.Name = "label_chave_privada";
            this.label_chave_privada.Size = new System.Drawing.Size(107, 23);
            this.label_chave_privada.TabIndex = 8;
            this.label_chave_privada.Text = "Chave-privada:";
            this.label_chave_privada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chave_publica
            // 
            this.chave_publica.Location = new System.Drawing.Point(556, 128);
            this.chave_publica.MaximumSize = new System.Drawing.Size(69, 20);
            this.chave_publica.MinimumSize = new System.Drawing.Size(24, 20);
            this.chave_publica.Name = "chave_publica";
            this.chave_publica.Size = new System.Drawing.Size(69, 20);
            this.chave_publica.TabIndex = 9;
            // 
            // chave_privada
            // 
            this.chave_privada.Location = new System.Drawing.Point(556, 339);
            this.chave_privada.MaximumSize = new System.Drawing.Size(69, 20);
            this.chave_privada.MinimumSize = new System.Drawing.Size(24, 20);
            this.chave_privada.Name = "chave_privada";
            this.chave_privada.Size = new System.Drawing.Size(69, 20);
            this.chave_privada.TabIndex = 10;
            // 
            // msg_descriptada_en
            // 
            this.msg_descriptada_en.Location = new System.Drawing.Point(26, 157);
            this.msg_descriptada_en.MaximumSize = new System.Drawing.Size(286, 160);
            this.msg_descriptada_en.Name = "msg_descriptada_en";
            this.msg_descriptada_en.Size = new System.Drawing.Size(286, 160);
            this.msg_descriptada_en.TabIndex = 11;
            this.msg_descriptada_en.Text = "";
            // 
            // msg_encriptada_en
            // 
            this.msg_encriptada_en.Location = new System.Drawing.Point(466, 157);
            this.msg_encriptada_en.MaximumSize = new System.Drawing.Size(286, 160);
            this.msg_encriptada_en.Name = "msg_encriptada_en";
            this.msg_encriptada_en.Size = new System.Drawing.Size(286, 160);
            this.msg_encriptada_en.TabIndex = 12;
            this.msg_encriptada_en.Text = "";
            // 
            // msg_encriptada_de
            // 
            this.msg_encriptada_de.Location = new System.Drawing.Point(26, 367);
            this.msg_encriptada_de.MaximumSize = new System.Drawing.Size(286, 160);
            this.msg_encriptada_de.Name = "msg_encriptada_de";
            this.msg_encriptada_de.Size = new System.Drawing.Size(286, 160);
            this.msg_encriptada_de.TabIndex = 13;
            this.msg_encriptada_de.Text = "";
            // 
            // msg_descriptada_de
            // 
            this.msg_descriptada_de.Location = new System.Drawing.Point(466, 367);
            this.msg_descriptada_de.MaximumSize = new System.Drawing.Size(286, 160);
            this.msg_descriptada_de.Name = "msg_descriptada_de";
            this.msg_descriptada_de.Size = new System.Drawing.Size(286, 160);
            this.msg_descriptada_de.TabIndex = 14;
            this.msg_descriptada_de.Text = "";
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_encriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encriptar.Location = new System.Drawing.Point(327, 219);
            this.btn_encriptar.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(121, 23);
            this.btn_encriptar.TabIndex = 15;
            this.btn_encriptar.Text = "Encriptar >>";
            this.btn_encriptar.UseVisualStyleBackColor = false;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // btn_descriptar
            // 
            this.btn_descriptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_descriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descriptar.Location = new System.Drawing.Point(327, 434);
            this.btn_descriptar.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_descriptar.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_descriptar.Name = "btn_descriptar";
            this.btn_descriptar.Size = new System.Drawing.Size(121, 23);
            this.btn_descriptar.TabIndex = 16;
            this.btn_descriptar.Text = "Descriptar >>";
            this.btn_descriptar.UseVisualStyleBackColor = false;
            this.btn_descriptar.Click += new System.EventHandler(this.btn_descriptar_Click);
            // 
            // btn_voltar_2
            // 
            this.btn_voltar_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_voltar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_2.Location = new System.Drawing.Point(37, 77);
            this.btn_voltar_2.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_voltar_2.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_voltar_2.Name = "btn_voltar_2";
            this.btn_voltar_2.Size = new System.Drawing.Size(121, 23);
            this.btn_voltar_2.TabIndex = 17;
            this.btn_voltar_2.Text = "<< Voltar";
            this.btn_voltar_2.UseVisualStyleBackColor = false;
            this.btn_voltar_2.Click += new System.EventHandler(this.btn_voltar_2_Click);
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ajuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajuda.Location = new System.Drawing.Point(505, 77);
            this.btn_ajuda.MaximumSize = new System.Drawing.Size(64, 23);
            this.btn_ajuda.MinimumSize = new System.Drawing.Size(64, 23);
            this.btn_ajuda.Name = "btn_ajuda";
            this.btn_ajuda.Size = new System.Drawing.Size(64, 23);
            this.btn_ajuda.TabIndex = 18;
            this.btn_ajuda.Text = "Ajuda ?";
            this.btn_ajuda.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logo.Location = new System.Drawing.Point(-2, -1);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.MaximumSize = new System.Drawing.Size(800, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(796, 47);
            this.logo.TabIndex = 19;
            this.logo.Text = "Safety At Sea (SAS)";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mostrar_tamanho_msg_descriptada
            // 
            this.btn_mostrar_tamanho_msg_descriptada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mostrar_tamanho_msg_descriptada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrar_tamanho_msg_descriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_tamanho_msg_descriptada.Location = new System.Drawing.Point(181, 128);
            this.btn_mostrar_tamanho_msg_descriptada.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_mostrar_tamanho_msg_descriptada.Name = "btn_mostrar_tamanho_msg_descriptada";
            this.btn_mostrar_tamanho_msg_descriptada.Size = new System.Drawing.Size(65, 23);
            this.btn_mostrar_tamanho_msg_descriptada.TabIndex = 20;
            this.btn_mostrar_tamanho_msg_descriptada.Text = "Mostrar";
            this.btn_mostrar_tamanho_msg_descriptada.UseVisualStyleBackColor = false;
            this.btn_mostrar_tamanho_msg_descriptada.Click += new System.EventHandler(this.btn_mostrar_tamanho_msg_descriptada_Click);
            // 
            // btn_mostrar_tamanho_msg_encriptada
            // 
            this.btn_mostrar_tamanho_msg_encriptada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mostrar_tamanho_msg_encriptada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrar_tamanho_msg_encriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_tamanho_msg_encriptada.Location = new System.Drawing.Point(181, 341);
            this.btn_mostrar_tamanho_msg_encriptada.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_mostrar_tamanho_msg_encriptada.Name = "btn_mostrar_tamanho_msg_encriptada";
            this.btn_mostrar_tamanho_msg_encriptada.Size = new System.Drawing.Size(65, 23);
            this.btn_mostrar_tamanho_msg_encriptada.TabIndex = 21;
            this.btn_mostrar_tamanho_msg_encriptada.Text = "Mostrar";
            this.btn_mostrar_tamanho_msg_encriptada.UseVisualStyleBackColor = false;
            this.btn_mostrar_tamanho_msg_encriptada.Click += new System.EventHandler(this.btn_mostrar_tamanho_msg_encriptada_Click);
            // 
            // tamanho_msg_descriptada
            // 
            this.tamanho_msg_descriptada.Location = new System.Drawing.Point(261, 130);
            this.tamanho_msg_descriptada.MaximumSize = new System.Drawing.Size(69, 20);
            this.tamanho_msg_descriptada.MinimumSize = new System.Drawing.Size(24, 20);
            this.tamanho_msg_descriptada.Name = "tamanho_msg_descriptada";
            this.tamanho_msg_descriptada.Size = new System.Drawing.Size(51, 20);
            this.tamanho_msg_descriptada.TabIndex = 22;
            // 
            // tamanho_msg_encriptada
            // 
            this.tamanho_msg_encriptada.Location = new System.Drawing.Point(261, 343);
            this.tamanho_msg_encriptada.MaximumSize = new System.Drawing.Size(69, 20);
            this.tamanho_msg_encriptada.MinimumSize = new System.Drawing.Size(24, 20);
            this.tamanho_msg_encriptada.Name = "tamanho_msg_encriptada";
            this.tamanho_msg_encriptada.Size = new System.Drawing.Size(51, 20);
            this.tamanho_msg_encriptada.TabIndex = 23;
            // 
            // btn_imagens
            // 
            this.btn_imagens.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_imagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imagens.Location = new System.Drawing.Point(631, 77);
            this.btn_imagens.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_imagens.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_imagens.Name = "btn_imagens";
            this.btn_imagens.Size = new System.Drawing.Size(121, 23);
            this.btn_imagens.TabIndex = 24;
            this.btn_imagens.Text = "Imagens >>";
            this.btn_imagens.UseVisualStyleBackColor = false;
            this.btn_imagens.Click += new System.EventHandler(this.btn_imagens_Click);
            // 
            // Criptacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_imagens);
            this.Controls.Add(this.tamanho_msg_encriptada);
            this.Controls.Add(this.tamanho_msg_descriptada);
            this.Controls.Add(this.btn_mostrar_tamanho_msg_encriptada);
            this.Controls.Add(this.btn_mostrar_tamanho_msg_descriptada);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_ajuda);
            this.Controls.Add(this.btn_voltar_2);
            this.Controls.Add(this.btn_descriptar);
            this.Controls.Add(this.btn_encriptar);
            this.Controls.Add(this.msg_descriptada_de);
            this.Controls.Add(this.msg_encriptada_de);
            this.Controls.Add(this.msg_encriptada_en);
            this.Controls.Add(this.msg_descriptada_en);
            this.Controls.Add(this.chave_privada);
            this.Controls.Add(this.chave_publica);
            this.Controls.Add(this.label_chave_privada);
            this.Controls.Add(this.label_chave_publica);
            this.Controls.Add(this.label_descriptar);
            this.Controls.Add(this.label_encriptar);
            this.Controls.Add(this.suporte_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Criptacao";
            this.Text = "SAS - Criptografia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.suporte_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView suporte_2;
        private System.Windows.Forms.Label label_encriptar;
        private System.Windows.Forms.Label label_descriptar;
        private System.Windows.Forms.Label label_chave_publica;
        private System.Windows.Forms.Label label_chave_privada;
        private System.Windows.Forms.TextBox chave_publica;
        private System.Windows.Forms.TextBox chave_privada;
        private System.Windows.Forms.RichTextBox msg_descriptada_en;
        private System.Windows.Forms.RichTextBox msg_encriptada_en;
        private System.Windows.Forms.RichTextBox msg_encriptada_de;
        private System.Windows.Forms.RichTextBox msg_descriptada_de;
        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.Button btn_descriptar;
        private System.Windows.Forms.Button btn_voltar_2;
        private System.Windows.Forms.Button btn_ajuda;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button btn_mostrar_tamanho_msg_descriptada;
        private System.Windows.Forms.Button btn_mostrar_tamanho_msg_encriptada;
        private System.Windows.Forms.TextBox tamanho_msg_descriptada;
        private System.Windows.Forms.TextBox tamanho_msg_encriptada;
        private System.Windows.Forms.Button btn_imagens;
    }
}