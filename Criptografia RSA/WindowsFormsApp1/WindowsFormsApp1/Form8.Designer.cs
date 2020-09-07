namespace WindowsFormsApp1
{
    partial class Criptacao_imagens
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
            this.suporte_3 = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.escolher_imagem = new System.Windows.Forms.Button();
            this.descriptar_imagem = new System.Windows.Forms.Button();
            this.imagem_em_bytes = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imagem_em_pixels = new System.Windows.Forms.PictureBox();
            this.btn_encriptar_imagem = new System.Windows.Forms.Button();
            this.btn_limpar_picture = new System.Windows.Forms.Button();
            this.btn_limpar_text_box = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suporte_3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_em_pixels)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.RoyalBlue;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logo.Location = new System.Drawing.Point(-4, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.MaximumSize = new System.Drawing.Size(788, 47);
            this.logo.MinimumSize = new System.Drawing.Size(788, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(788, 47);
            this.logo.TabIndex = 4;
            this.logo.Text = "Safety At Sea (SAS)";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suporte_3
            // 
            this.suporte_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suporte_3.Location = new System.Drawing.Point(12, 63);
            this.suporte_3.MaximumSize = new System.Drawing.Size(755, 486);
            this.suporte_3.Name = "suporte_3";
            this.suporte_3.Size = new System.Drawing.Size(755, 486);
            this.suporte_3.TabIndex = 7;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(42, 91);
            this.btn_voltar.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_voltar.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(121, 23);
            this.btn_voltar.TabIndex = 20;
            this.btn_voltar.Text = "<< Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // escolher_imagem
            // 
            this.escolher_imagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.escolher_imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.escolher_imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolher_imagem.Location = new System.Drawing.Point(35, 295);
            this.escolher_imagem.MaximumSize = new System.Drawing.Size(121, 23);
            this.escolher_imagem.MinimumSize = new System.Drawing.Size(121, 23);
            this.escolher_imagem.Name = "escolher_imagem";
            this.escolher_imagem.Size = new System.Drawing.Size(121, 23);
            this.escolher_imagem.TabIndex = 22;
            this.escolher_imagem.Text = "Escolher imagem";
            this.escolher_imagem.UseVisualStyleBackColor = false;
            this.escolher_imagem.Click += new System.EventHandler(this.escolher_imagem_Click);
            // 
            // descriptar_imagem
            // 
            this.descriptar_imagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descriptar_imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descriptar_imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptar_imagem.Location = new System.Drawing.Point(478, 295);
            this.descriptar_imagem.MaximumSize = new System.Drawing.Size(121, 23);
            this.descriptar_imagem.MinimumSize = new System.Drawing.Size(121, 23);
            this.descriptar_imagem.Name = "descriptar_imagem";
            this.descriptar_imagem.Size = new System.Drawing.Size(121, 23);
            this.descriptar_imagem.TabIndex = 23;
            this.descriptar_imagem.Text = "↓ Descriptar";
            this.descriptar_imagem.UseVisualStyleBackColor = false;
            this.descriptar_imagem.Click += new System.EventHandler(this.descriptar_imagem_Click);
            // 
            // imagem_em_bytes
            // 
            this.imagem_em_bytes.Location = new System.Drawing.Point(35, 144);
            this.imagem_em_bytes.Name = "imagem_em_bytes";
            this.imagem_em_bytes.Size = new System.Drawing.Size(705, 135);
            this.imagem_em_bytes.TabIndex = 24;
            this.imagem_em_bytes.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.imagem_em_pixels);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 345);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 190);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // imagem_em_pixels
            // 
            this.imagem_em_pixels.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imagem_em_pixels.Location = new System.Drawing.Point(3, 3);
            this.imagem_em_pixels.Name = "imagem_em_pixels";
            this.imagem_em_pixels.Size = new System.Drawing.Size(734, 343);
            this.imagem_em_pixels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagem_em_pixels.TabIndex = 0;
            this.imagem_em_pixels.TabStop = false;
            this.imagem_em_pixels.WaitOnLoad = true;
            // 
            // btn_encriptar_imagem
            // 
            this.btn_encriptar_imagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_encriptar_imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encriptar_imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encriptar_imagem.Location = new System.Drawing.Point(619, 295);
            this.btn_encriptar_imagem.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_encriptar_imagem.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_encriptar_imagem.Name = "btn_encriptar_imagem";
            this.btn_encriptar_imagem.Size = new System.Drawing.Size(121, 23);
            this.btn_encriptar_imagem.TabIndex = 26;
            this.btn_encriptar_imagem.Text = "Encriptar ↑";
            this.btn_encriptar_imagem.UseVisualStyleBackColor = false;
            this.btn_encriptar_imagem.Click += new System.EventHandler(this.btn_encriptar_imagem_Click);
            // 
            // btn_limpar_picture
            // 
            this.btn_limpar_picture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpar_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar_picture.Location = new System.Drawing.Point(328, 295);
            this.btn_limpar_picture.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_limpar_picture.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_limpar_picture.Name = "btn_limpar_picture";
            this.btn_limpar_picture.Size = new System.Drawing.Size(121, 23);
            this.btn_limpar_picture.TabIndex = 27;
            this.btn_limpar_picture.Text = "Limpar picture";
            this.btn_limpar_picture.UseVisualStyleBackColor = false;
            this.btn_limpar_picture.Click += new System.EventHandler(this.btn_limpar_picture_Click);
            // 
            // btn_limpar_text_box
            // 
            this.btn_limpar_text_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpar_text_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar_text_box.Location = new System.Drawing.Point(186, 295);
            this.btn_limpar_text_box.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_limpar_text_box.MinimumSize = new System.Drawing.Size(121, 23);
            this.btn_limpar_text_box.Name = "btn_limpar_text_box";
            this.btn_limpar_text_box.Size = new System.Drawing.Size(121, 23);
            this.btn_limpar_text_box.TabIndex = 28;
            this.btn_limpar_text_box.Text = "Limpar text box";
            this.btn_limpar_text_box.UseVisualStyleBackColor = false;
            this.btn_limpar_text_box.Click += new System.EventHandler(this.btn_limpar_text_box_Click);
            // 
            // Criptacao_imagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_limpar_text_box);
            this.Controls.Add(this.btn_limpar_picture);
            this.Controls.Add(this.btn_encriptar_imagem);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.imagem_em_bytes);
            this.Controls.Add(this.descriptar_imagem);
            this.Controls.Add(this.escolher_imagem);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.suporte_3);
            this.Controls.Add(this.logo);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Criptacao_imagens";
            this.Text = "Form8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.suporte_3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_em_pixels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.DataGridView suporte_3;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button escolher_imagem;
        private System.Windows.Forms.Button descriptar_imagem;
        private System.Windows.Forms.RichTextBox imagem_em_bytes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox imagem_em_pixels;
        private System.Windows.Forms.Button btn_encriptar_imagem;
        private System.Windows.Forms.Button btn_limpar_picture;
        private System.Windows.Forms.Button btn_limpar_text_box;
    }
}