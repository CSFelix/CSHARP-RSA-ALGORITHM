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
            this.btn_mostrar_tamanho_msg_descriptada = new System.Windows.Forms.Button();
            this.btn_mostrar_tamanho_msg_encriptada = new System.Windows.Forms.Button();
            this.btn_imagens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chave_mista = new System.Windows.Forms.TextBox();
            this.btn_densidade = new System.Windows.Forms.Button();
            this.check_valor_negativo = new System.Windows.Forms.CheckBox();
            this.primo1 = new System.Windows.Forms.TextBox();
            this.primo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.tamanho_msg_descriptada = new System.Windows.Forms.Label();
            this.tamanho_msg_encriptada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suporte_2)).BeginInit();
            this.SuspendLayout();
            // 
            // suporte_2
            // 
            this.suporte_2.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.suporte_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suporte_2.Location = new System.Drawing.Point(17, 63);
            this.suporte_2.MaximumSize = new System.Drawing.Size(755, 486);
            this.suporte_2.Name = "suporte_2";
            this.suporte_2.Size = new System.Drawing.Size(755, 486);
            this.suporte_2.TabIndex = 4;
            // 
            // label_encriptar
            // 
            this.label_encriptar.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.label_descriptar.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.label_chave_publica.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_chave_publica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chave_publica.Location = new System.Drawing.Point(463, 135);
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
            this.label_chave_privada.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_chave_privada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chave_privada.Location = new System.Drawing.Point(463, 344);
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
            this.chave_publica.Location = new System.Drawing.Point(573, 137);
            this.chave_publica.MaximumSize = new System.Drawing.Size(69, 20);
            this.chave_publica.MinimumSize = new System.Drawing.Size(24, 20);
            this.chave_publica.Name = "chave_publica";
            this.chave_publica.Size = new System.Drawing.Size(69, 20);
            this.chave_publica.TabIndex = 9;
            // 
            // chave_privada
            // 
            this.chave_privada.Location = new System.Drawing.Point(576, 347);
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
            this.btn_encriptar.Location = new System.Drawing.Point(327, 208);
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
            // btn_mostrar_tamanho_msg_descriptada
            // 
            this.btn_mostrar_tamanho_msg_descriptada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mostrar_tamanho_msg_descriptada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrar_tamanho_msg_descriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_tamanho_msg_descriptada.Location = new System.Drawing.Point(162, 128);
            this.btn_mostrar_tamanho_msg_descriptada.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_mostrar_tamanho_msg_descriptada.Name = "btn_mostrar_tamanho_msg_descriptada";
            this.btn_mostrar_tamanho_msg_descriptada.Size = new System.Drawing.Size(84, 23);
            this.btn_mostrar_tamanho_msg_descriptada.TabIndex = 20;
            this.btn_mostrar_tamanho_msg_descriptada.Text = "Tamanho";
            this.btn_mostrar_tamanho_msg_descriptada.UseVisualStyleBackColor = false;
            this.btn_mostrar_tamanho_msg_descriptada.Click += new System.EventHandler(this.btn_mostrar_tamanho_msg_descriptada_Click);
            // 
            // btn_mostrar_tamanho_msg_encriptada
            // 
            this.btn_mostrar_tamanho_msg_encriptada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mostrar_tamanho_msg_encriptada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrar_tamanho_msg_encriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_tamanho_msg_encriptada.Location = new System.Drawing.Point(162, 341);
            this.btn_mostrar_tamanho_msg_encriptada.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_mostrar_tamanho_msg_encriptada.Name = "btn_mostrar_tamanho_msg_encriptada";
            this.btn_mostrar_tamanho_msg_encriptada.Size = new System.Drawing.Size(84, 23);
            this.btn_mostrar_tamanho_msg_encriptada.TabIndex = 21;
            this.btn_mostrar_tamanho_msg_encriptada.Text = "Tamanho";
            this.btn_mostrar_tamanho_msg_encriptada.UseVisualStyleBackColor = false;
            this.btn_mostrar_tamanho_msg_encriptada.Click += new System.EventHandler(this.btn_mostrar_tamanho_msg_encriptada_Click);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 73);
            this.label1.MaximumSize = new System.Drawing.Size(107, 23);
            this.label1.MinimumSize = new System.Drawing.Size(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chave-mista:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chave_mista
            // 
            this.chave_mista.Location = new System.Drawing.Point(311, 75);
            this.chave_mista.MaximumSize = new System.Drawing.Size(69, 20);
            this.chave_mista.MinimumSize = new System.Drawing.Size(24, 20);
            this.chave_mista.Name = "chave_mista";
            this.chave_mista.Size = new System.Drawing.Size(69, 20);
            this.chave_mista.TabIndex = 26;
            // 
            // btn_densidade
            // 
            this.btn_densidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_densidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_densidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_densidade.Location = new System.Drawing.Point(327, 324);
            this.btn_densidade.MaximumSize = new System.Drawing.Size(121, 23);
            this.btn_densidade.Name = "btn_densidade";
            this.btn_densidade.Size = new System.Drawing.Size(121, 23);
            this.btn_densidade.TabIndex = 27;
            this.btn_densidade.Text = ">> Densidade <<";
            this.btn_densidade.UseVisualStyleBackColor = false;
            this.btn_densidade.Click += new System.EventHandler(this.btn_densidade_Click);
            // 
            // check_valor_negativo
            // 
            this.check_valor_negativo.AutoSize = true;
            this.check_valor_negativo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.check_valor_negativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_valor_negativo.Location = new System.Drawing.Point(651, 348);
            this.check_valor_negativo.Name = "check_valor_negativo";
            this.check_valor_negativo.Size = new System.Drawing.Size(105, 19);
            this.check_valor_negativo.TabIndex = 29;
            this.check_valor_negativo.Text = "Valor Negativo";
            this.check_valor_negativo.UseVisualStyleBackColor = false;
            // 
            // primo1
            // 
            this.primo1.Location = new System.Drawing.Point(454, 73);
            this.primo1.MaximumSize = new System.Drawing.Size(69, 20);
            this.primo1.MinimumSize = new System.Drawing.Size(24, 20);
            this.primo1.Name = "primo1";
            this.primo1.Size = new System.Drawing.Size(46, 20);
            this.primo1.TabIndex = 30;
            // 
            // primo2
            // 
            this.primo2.Location = new System.Drawing.Point(573, 74);
            this.primo2.MaximumSize = new System.Drawing.Size(69, 20);
            this.primo2.MinimumSize = new System.Drawing.Size(24, 20);
            this.primo2.Name = "primo2";
            this.primo2.Size = new System.Drawing.Size(46, 20);
            this.primo2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 73);
            this.label2.MaximumSize = new System.Drawing.Size(107, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Primo 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 72);
            this.label3.MaximumSize = new System.Drawing.Size(107, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Primo 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Lavender;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.SlateBlue;
            this.logo.Location = new System.Drawing.Point(-2, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.MaximumSize = new System.Drawing.Size(999, 999);
            this.logo.MinimumSize = new System.Drawing.Size(379, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(790, 28);
            this.logo.TabIndex = 34;
            this.logo.Text = "Safety At Sea (SAS)";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tamanho_msg_descriptada
            // 
            this.tamanho_msg_descriptada.BackColor = System.Drawing.Color.White;
            this.tamanho_msg_descriptada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tamanho_msg_descriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho_msg_descriptada.Location = new System.Drawing.Point(258, 128);
            this.tamanho_msg_descriptada.MaximumSize = new System.Drawing.Size(107, 23);
            this.tamanho_msg_descriptada.MinimumSize = new System.Drawing.Size(30, 23);
            this.tamanho_msg_descriptada.Name = "tamanho_msg_descriptada";
            this.tamanho_msg_descriptada.Size = new System.Drawing.Size(50, 23);
            this.tamanho_msg_descriptada.TabIndex = 35;
            this.tamanho_msg_descriptada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tamanho_msg_encriptada
            // 
            this.tamanho_msg_encriptada.BackColor = System.Drawing.Color.White;
            this.tamanho_msg_encriptada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tamanho_msg_encriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho_msg_encriptada.Location = new System.Drawing.Point(258, 341);
            this.tamanho_msg_encriptada.MaximumSize = new System.Drawing.Size(107, 23);
            this.tamanho_msg_encriptada.MinimumSize = new System.Drawing.Size(30, 23);
            this.tamanho_msg_encriptada.Name = "tamanho_msg_encriptada";
            this.tamanho_msg_encriptada.Size = new System.Drawing.Size(50, 23);
            this.tamanho_msg_encriptada.TabIndex = 36;
            this.tamanho_msg_encriptada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Criptacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wave_and_bubbles;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tamanho_msg_encriptada);
            this.Controls.Add(this.tamanho_msg_descriptada);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.primo2);
            this.Controls.Add(this.primo1);
            this.Controls.Add(this.check_valor_negativo);
            this.Controls.Add(this.btn_densidade);
            this.Controls.Add(this.chave_mista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_imagens);
            this.Controls.Add(this.btn_mostrar_tamanho_msg_encriptada);
            this.Controls.Add(this.btn_mostrar_tamanho_msg_descriptada);
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
            this.MinimumSize = new System.Drawing.Size(800, 600);
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
        private System.Windows.Forms.Button btn_mostrar_tamanho_msg_descriptada;
        private System.Windows.Forms.Button btn_mostrar_tamanho_msg_encriptada;
        private System.Windows.Forms.Button btn_imagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chave_mista;
        private System.Windows.Forms.Button btn_densidade;
        private System.Windows.Forms.CheckBox check_valor_negativo;
        private System.Windows.Forms.TextBox primo1;
        private System.Windows.Forms.TextBox primo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label tamanho_msg_descriptada;
        private System.Windows.Forms.Label tamanho_msg_encriptada;
    }
}