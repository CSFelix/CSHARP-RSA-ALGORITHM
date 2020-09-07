namespace WindowsFormsApp1
{
    partial class sair
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
            this.logo = new System.Windows.Forms.Label();
            this.suporte_sair = new System.Windows.Forms.DataGridView();
            this.label_pergunta = new System.Windows.Forms.Label();
            this.btn_sair_sim = new System.Windows.Forms.Button();
            this.btn_sair_nao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suporte_sair)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.MaximumSize = new System.Drawing.Size(379, 28);
            this.logo.MinimumSize = new System.Drawing.Size(379, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(379, 28);
            this.logo.TabIndex = 1;
            this.logo.Text = "Safety At Sea (SAS)";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suporte_sair
            // 
            this.suporte_sair.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suporte_sair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suporte_sair.Location = new System.Drawing.Point(47, 46);
            this.suporte_sair.MaximumSize = new System.Drawing.Size(286, 116);
            this.suporte_sair.MinimumSize = new System.Drawing.Size(286, 116);
            this.suporte_sair.Name = "suporte_sair";
            this.suporte_sair.Size = new System.Drawing.Size(286, 116);
            this.suporte_sair.TabIndex = 2;
            // 
            // label_pergunta
            // 
            this.label_pergunta.AutoSize = true;
            this.label_pergunta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pergunta.Location = new System.Drawing.Point(110, 58);
            this.label_pergunta.MaximumSize = new System.Drawing.Size(171, 20);
            this.label_pergunta.MinimumSize = new System.Drawing.Size(171, 20);
            this.label_pergunta.Name = "label_pergunta";
            this.label_pergunta.Size = new System.Drawing.Size(171, 20);
            this.label_pergunta.TabIndex = 3;
            this.label_pergunta.Text = "Deseja mesmo sair?";
            this.label_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_sair_sim
            // 
            this.btn_sair_sim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sair_sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair_sim.Location = new System.Drawing.Point(83, 123);
            this.btn_sair_sim.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_sair_sim.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_sair_sim.Name = "btn_sair_sim";
            this.btn_sair_sim.Size = new System.Drawing.Size(75, 23);
            this.btn_sair_sim.TabIndex = 4;
            this.btn_sair_sim.Text = "Sim";
            this.btn_sair_sim.UseVisualStyleBackColor = false;
            this.btn_sair_sim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sair_nao
            // 
            this.btn_sair_nao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sair_nao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair_nao.Location = new System.Drawing.Point(227, 123);
            this.btn_sair_nao.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_sair_nao.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_sair_nao.Name = "btn_sair_nao";
            this.btn_sair_nao.Size = new System.Drawing.Size(75, 23);
            this.btn_sair_nao.TabIndex = 5;
            this.btn_sair_nao.Text = "Não";
            this.btn_sair_nao.UseVisualStyleBackColor = false;
            this.btn_sair_nao.Click += new System.EventHandler(this.button2_Click);
            // 
            // sair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(378, 187);
            this.Controls.Add(this.btn_sair_nao);
            this.Controls.Add(this.btn_sair_sim);
            this.Controls.Add(this.label_pergunta);
            this.Controls.Add(this.suporte_sair);
            this.Controls.Add(this.logo);
            this.MaximumSize = new System.Drawing.Size(394, 226);
            this.Name = "sair";
            this.Text = "SAS - Mensagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sair_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.suporte_sair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.DataGridView suporte_sair;
        private System.Windows.Forms.Label label_pergunta;
        private System.Windows.Forms.Button btn_sair_sim;
        private System.Windows.Forms.Button btn_sair_nao;
    }
}