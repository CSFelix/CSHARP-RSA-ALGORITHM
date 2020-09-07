namespace WindowsFormsApp1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.logo = new System.Windows.Forms.Label();
            this.suporte_1 = new System.Windows.Forms.DataGridView();
            this.opcao_1 = new System.Windows.Forms.DataGridView();
            this.opcao_2 = new System.Windows.Forms.DataGridView();
            this.opcao_3 = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label_bem_vindo = new System.Windows.Forms.Label();
            this.label_txt1 = new System.Windows.Forms.Label();
            this.RELATORIO = new System.Windows.Forms.LinkLabel();
            this.SAS_IA = new System.Windows.Forms.LinkLabel();
            this.CRIPTACAO = new System.Windows.Forms.LinkLabel();
            this.descricao_1 = new System.Windows.Forms.Label();
            this.descricao_2 = new System.Windows.Forms.Label();
            this.descricao_3 = new System.Windows.Forms.Label();
            this.label_txt2 = new System.Windows.Forms.Label();
            this.btn_enviar_comando = new System.Windows.Forms.Button();
            this.linha_comando = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.suporte_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcao_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcao_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcao_3)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logo.Location = new System.Drawing.Point(-1, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.MaximumSize = new System.Drawing.Size(800, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(796, 47);
            this.logo.TabIndex = 1;
            this.logo.Text = "Safety At Sea (SAS)";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suporte_1
            // 
            this.suporte_1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suporte_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suporte_1.Location = new System.Drawing.Point(12, 63);
            this.suporte_1.MaximumSize = new System.Drawing.Size(755, 486);
            this.suporte_1.Name = "suporte_1";
            this.suporte_1.Size = new System.Drawing.Size(755, 486);
            this.suporte_1.TabIndex = 3;
            // 
            // opcao_1
            // 
            this.opcao_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opcao_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.opcao_1.Location = new System.Drawing.Point(36, 334);
            this.opcao_1.MaximumSize = new System.Drawing.Size(201, 185);
            this.opcao_1.MinimumSize = new System.Drawing.Size(201, 185);
            this.opcao_1.Name = "opcao_1";
            this.opcao_1.Size = new System.Drawing.Size(201, 185);
            this.opcao_1.TabIndex = 4;
            // 
            // opcao_2
            // 
            this.opcao_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opcao_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.opcao_2.Location = new System.Drawing.Point(287, 334);
            this.opcao_2.MaximumSize = new System.Drawing.Size(201, 185);
            this.opcao_2.MinimumSize = new System.Drawing.Size(201, 185);
            this.opcao_2.Name = "opcao_2";
            this.opcao_2.Size = new System.Drawing.Size(201, 185);
            this.opcao_2.TabIndex = 5;
            // 
            // opcao_3
            // 
            this.opcao_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opcao_3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.opcao_3.Location = new System.Drawing.Point(535, 334);
            this.opcao_3.MaximumSize = new System.Drawing.Size(201, 185);
            this.opcao_3.MinimumSize = new System.Drawing.Size(201, 185);
            this.opcao_3.Name = "opcao_3";
            this.opcao_3.Size = new System.Drawing.Size(201, 185);
            this.opcao_3.TabIndex = 6;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(36, 81);
            this.btn_sair.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_sair.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label_bem_vindo
            // 
            this.label_bem_vindo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_bem_vindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bem_vindo.Location = new System.Drawing.Point(296, 81);
            this.label_bem_vindo.MaximumSize = new System.Drawing.Size(201, 23);
            this.label_bem_vindo.MinimumSize = new System.Drawing.Size(201, 23);
            this.label_bem_vindo.Name = "label_bem_vindo";
            this.label_bem_vindo.Size = new System.Drawing.Size(201, 23);
            this.label_bem_vindo.TabIndex = 9;
            this.label_bem_vindo.Text = "Bem-vindo!";
            this.label_bem_vindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_txt1
            // 
            this.label_txt1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt1.Location = new System.Drawing.Point(36, 148);
            this.label_txt1.MaximumSize = new System.Drawing.Size(700, 23);
            this.label_txt1.MinimumSize = new System.Drawing.Size(700, 23);
            this.label_txt1.Name = "label_txt1";
            this.label_txt1.Size = new System.Drawing.Size(700, 23);
            this.label_txt1.TabIndex = 10;
            this.label_txt1.Text = "Operação 001 -> SAS\'s Criptografia";
            this.label_txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RELATORIO
            // 
            this.RELATORIO.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.RELATORIO.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RELATORIO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RELATORIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RELATORIO.LinkColor = System.Drawing.Color.Navy;
            this.RELATORIO.Location = new System.Drawing.Point(75, 357);
            this.RELATORIO.MaximumSize = new System.Drawing.Size(123, 23);
            this.RELATORIO.MinimumSize = new System.Drawing.Size(123, 23);
            this.RELATORIO.Name = "RELATORIO";
            this.RELATORIO.Size = new System.Drawing.Size(123, 23);
            this.RELATORIO.TabIndex = 11;
            this.RELATORIO.TabStop = true;
            this.RELATORIO.Text = "RELATÓRIO";
            this.RELATORIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RELATORIO.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.RELATORIO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RELATORIO_LinkClicked);
            this.RELATORIO.MouseHover += new System.EventHandler(this.RELATORIO_MouseHover);
            // 
            // SAS_IA
            // 
            this.SAS_IA.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.SAS_IA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SAS_IA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAS_IA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAS_IA.LinkColor = System.Drawing.Color.Navy;
            this.SAS_IA.Location = new System.Drawing.Point(573, 357);
            this.SAS_IA.MaximumSize = new System.Drawing.Size(123, 23);
            this.SAS_IA.MinimumSize = new System.Drawing.Size(123, 23);
            this.SAS_IA.Name = "SAS_IA";
            this.SAS_IA.Size = new System.Drawing.Size(123, 23);
            this.SAS_IA.TabIndex = 14;
            this.SAS_IA.TabStop = true;
            this.SAS_IA.Text = "SAS IA";
            this.SAS_IA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SAS_IA.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.SAS_IA.MouseHover += new System.EventHandler(this.SAS_IA_MouseHover);
            // 
            // CRIPTACAO
            // 
            this.CRIPTACAO.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.CRIPTACAO.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CRIPTACAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CRIPTACAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRIPTACAO.LinkColor = System.Drawing.Color.Navy;
            this.CRIPTACAO.Location = new System.Drawing.Point(327, 357);
            this.CRIPTACAO.MaximumSize = new System.Drawing.Size(123, 23);
            this.CRIPTACAO.MinimumSize = new System.Drawing.Size(123, 23);
            this.CRIPTACAO.Name = "CRIPTACAO";
            this.CRIPTACAO.Size = new System.Drawing.Size(123, 23);
            this.CRIPTACAO.TabIndex = 15;
            this.CRIPTACAO.TabStop = true;
            this.CRIPTACAO.Text = "CRIPTAÇÃO";
            this.CRIPTACAO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CRIPTACAO.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.CRIPTACAO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CRIPTACAO_LinkClicked_1);
            this.CRIPTACAO.MouseHover += new System.EventHandler(this.CRIPTACAO_MouseHover);
            // 
            // descricao_1
            // 
            this.descricao_1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.descricao_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.descricao_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_1.Location = new System.Drawing.Point(61, 412);
            this.descricao_1.MaximumSize = new System.Drawing.Size(160, 57);
            this.descricao_1.MinimumSize = new System.Drawing.Size(160, 57);
            this.descricao_1.Name = "descricao_1";
            this.descricao_1.Size = new System.Drawing.Size(160, 57);
            this.descricao_1.TabIndex = 16;
            this.descricao_1.Text = "  Descrição geral da tragédia ocorrida.";
            // 
            // descricao_2
            // 
            this.descricao_2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.descricao_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.descricao_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_2.Location = new System.Drawing.Point(315, 412);
            this.descricao_2.MaximumSize = new System.Drawing.Size(160, 57);
            this.descricao_2.MinimumSize = new System.Drawing.Size(160, 57);
            this.descricao_2.Name = "descricao_2";
            this.descricao_2.Size = new System.Drawing.Size(160, 57);
            this.descricao_2.TabIndex = 17;
            this.descricao_2.Text = "  Encripte e descripte dados com chaves públicas e privadas.";
            // 
            // descricao_3
            // 
            this.descricao_3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.descricao_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.descricao_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_3.Location = new System.Drawing.Point(561, 412);
            this.descricao_3.MaximumSize = new System.Drawing.Size(160, 57);
            this.descricao_3.MinimumSize = new System.Drawing.Size(160, 57);
            this.descricao_3.Name = "descricao_3";
            this.descricao_3.Size = new System.Drawing.Size(160, 57);
            this.descricao_3.TabIndex = 18;
            this.descricao_3.Text = "  Comunicação com a Inteligência Artificial do SAS: CUMI";
            // 
            // label_txt2
            // 
            this.label_txt2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt2.Location = new System.Drawing.Point(36, 189);
            this.label_txt2.MaximumSize = new System.Drawing.Size(700, 102);
            this.label_txt2.MinimumSize = new System.Drawing.Size(700, 102);
            this.label_txt2.Name = "label_txt2";
            this.label_txt2.Size = new System.Drawing.Size(700, 102);
            this.label_txt2.TabIndex = 19;
            this.label_txt2.Text = " Software desenvolvido por funcionários selecionados pelo Estado. Se você tem ace" +
    "sso a ele, saiba que a situação é delicada. Nunca diga o valor da chave-privada " +
    "à terceiros em hipótese alguma.";
            this.label_txt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_enviar_comando
            // 
            this.btn_enviar_comando.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_enviar_comando.Location = new System.Drawing.Point(680, 487);
            this.btn_enviar_comando.Name = "btn_enviar_comando";
            this.btn_enviar_comando.Size = new System.Drawing.Size(56, 23);
            this.btn_enviar_comando.TabIndex = 20;
            this.btn_enviar_comando.Text = "Enviar!";
            this.btn_enviar_comando.UseVisualStyleBackColor = false;
            this.btn_enviar_comando.Click += new System.EventHandler(this.btn_enviar_comando_Click);
            // 
            // linha_comando
            // 
            this.linha_comando.Location = new System.Drawing.Point(550, 487);
            this.linha_comando.Name = "linha_comando";
            this.linha_comando.Size = new System.Drawing.Size(124, 20);
            this.linha_comando.TabIndex = 21;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.linha_comando);
            this.Controls.Add(this.btn_enviar_comando);
            this.Controls.Add(this.label_txt2);
            this.Controls.Add(this.descricao_3);
            this.Controls.Add(this.descricao_2);
            this.Controls.Add(this.descricao_1);
            this.Controls.Add(this.CRIPTACAO);
            this.Controls.Add(this.SAS_IA);
            this.Controls.Add(this.RELATORIO);
            this.Controls.Add(this.label_txt1);
            this.Controls.Add(this.label_bem_vindo);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.opcao_3);
            this.Controls.Add(this.opcao_2);
            this.Controls.Add(this.opcao_1);
            this.Controls.Add(this.suporte_1);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Inicio";
            this.Text = "SAS - Início";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tela_inicial_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.suporte_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcao_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcao_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcao_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.DataGridView suporte_1;
        private System.Windows.Forms.DataGridView opcao_1;
        private System.Windows.Forms.DataGridView opcao_2;
        private System.Windows.Forms.DataGridView opcao_3;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label_bem_vindo;
        private System.Windows.Forms.Label label_txt1;
        private System.Windows.Forms.LinkLabel RELATORIO;
        private System.Windows.Forms.LinkLabel SAS_IA;
        private System.Windows.Forms.LinkLabel CRIPTACAO;
        private System.Windows.Forms.Label descricao_1;
        private System.Windows.Forms.Label descricao_2;
        private System.Windows.Forms.Label descricao_3;
        private System.Windows.Forms.Label label_txt2;
        private System.Windows.Forms.Button btn_enviar_comando;
        private System.Windows.Forms.TextBox linha_comando;
    }
}