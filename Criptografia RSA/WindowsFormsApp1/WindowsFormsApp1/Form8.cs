using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criptografia;
using VoiceBot;

namespace WindowsFormsApp1
{
    public partial class Criptacao_imagens : Form
    {
        CUMI cumi6 = new CUMI();
        bool cumi_acordada; // armazena a condição de que a CUMI está mesma acordada ou não.

        Imagem imagem = new Imagem();
        public Criptacao_imagens(bool cumi_acordada)
        {
            this.cumi_acordada = cumi_acordada;
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
                if (cumi_acordada == true)
                {
                    // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                    try
                    {
                        cumi6.Pensar(2, 7);
                    }
                    catch
                    {
                        cumi6.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
                    }
                }

                MessageBox.Show("Selecione uma imagem antes de encriptar.");
            }
            // Caso contrário, a imagem é transformada em byte array e exibida em formato de string na richTextBox
            else
            {
                byte[] bytes = imagem.Imagem_Para_Byte_Array(imagem_em_pixels.Image);
                imagem_em_bytes.Text = BitConverter.ToString(bytes);
                imagem_em_bytes.Text = imagem_em_bytes.Text.Replace("-", "");
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
                if (cumi_acordada == true)
                {
                    try
                    {
                        cumi6.Pensar(2, 8);
                    }
                    catch
                    {
                        cumi6.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
                    }
                }

                MessageBox.Show("Informe os valores hexadecimais da imagem antes de descriptá-la.");
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
                    // Caso houver algum erro, uma MessageBox surge
                    if (cumi_acordada == true)
                    {
                        try
                        {
                            cumi6.Pensar(2, 9);
                        }
                        catch
                        {
                            cumi6.Pensar(2, 11);
                            MessageBox.Show("Um erro encontrado, avise ao programador!");
                        }
                    }

                    MessageBox.Show("Valores hexadecimais fora dos padrões.");
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

            Criptacao criptacao = new Criptacao(cumi_acordada);
            criptacao.Show();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
