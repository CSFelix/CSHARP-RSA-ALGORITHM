using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA_Crypto;
using AssistenteVirtual;
using Erros;

namespace WindowsFormsApp1
{
    public partial class Criptacao_imagens : Form
    {
        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;
        Conteudo_Erros msg = new Conteudo_Erros();

        Imagem_Array imagem = new Imagem_Array();
        public Criptacao_imagens(bool status_cumi, bool idioma_internacional, bool cumi_som)
        {
            this.status_cumi = status_cumi;
            this.idioma_internacional = idioma_internacional;
            this.cumi_som = cumi_som;
            cumi = new CUMI(this.status_cumi, this.idioma_internacional, this.cumi_som);
            InitializeComponent();
        }

        /// <summary>
        /// Escolha da imagem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void escolher_imagem_Click(object sender, EventArgs e)
        {
            // Quando o usuário escolher a imagem, ela carregará na label "imagem_em_pixels"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagem_em_pixels.ImageLocation = openFileDialog1.FileName;
                imagem_em_pixels.Load();
            }
        }

        /// <summary>
        /// Limpa o campo de imagens selecionadas (somente quando ele não é nulo).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_picture_Click(object sender, EventArgs e)
        {
            if (imagem_em_pixels.Image != null)
            {
                imagem_em_pixels.Image = null;
            }
        }

        /// <summary>
        /// Limpa o campo de valores hexadecimais (somente quando há algo digitado nele).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_text_box_Click(object sender, EventArgs e)
        {
            if (imagem_em_bytes.Text != "")
            {
                imagem_em_bytes.Text = "";
            }
        }

        /// <summary>
        /// Transformação da imagem em byte array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_encriptar_imagem_Click(object sender, EventArgs e)
        {
            // Se a imagem não for selecionada, uma MessageBox surge
            if (imagem_em_pixels.Image == null)
            {
                var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 15, 2);
                MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cumi.Check_Status() == true)
                {
                    try
                    {
                        cumi.Pensar_Fala(2, 15);
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                 
                }
            }
            // Caso contrário, a imagem é transformada em byte array e exibida em formato de string na richTextBox
            else
            {
                byte[] bytes = imagem.Imagem_Para_Byte_Array(imagem_em_pixels.Image);
                imagem_em_bytes.Text = imagem.Byte_Array_Para_String(bytes);          
            }
        }

        /// <summary>
        /// Transformação do byte array em imagem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descriptar_imagem_Click(object sender, EventArgs e)
        {
            // Se o usuário não digitou os valores hexadecimais da imagem, uma MessageBox surge
            if (imagem_em_bytes.Text == "")
            {
                var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 13, 2);
                MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cumi.Check_Status() == true)
                {                   
                    try
                    {
                        cumi.Pensar_Fala(2, 13);
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
                }
            }
            // Caso contrário, os valores hexadecimais são convertidos em um array de bytes e depois para imagem na PictureBox
            else
            {
                try
                {
                    // Tentativa de conversão
                    byte[] bytes = imagem.String_Para_Byte_Array(imagem_em_bytes.Text);
                    imagem_em_pixels.Image = imagem.Byte_Array_Para_Imagem(bytes);
                }
                catch
                {
                    var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 14, 2);
                    MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (cumi.Check_Status() == true)
                    {
                        try
                        {
                            cumi.Pensar_Fala(2, 14);
                        }

                        catch
                        {
                            cumi.Pensar_Fala(2, 16);
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                       
                    }
                }                              
            }
        }

        /// <summary>
        /// Retorno à área de criptação de textos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Criptacao criptacao = new Criptacao(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
            criptacao.Show();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
