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
    public partial class Imagens_relatorio : Form
    {
        CUMI cumi4 = new CUMI();
        bool cumi_acordada; // armazena a condição de que a CUMI está mesma acordada ou não.

        bool permissao = false; // permissão para visualizar as imagens
        string legenda_imagem1, legenda_imagem2; // legendas das imagens

        public Imagens_relatorio(bool cumi_acordada)
        {
            this.cumi_acordada = cumi_acordada;
            InitializeComponent();
        }

        /// <summary>
        /// Transformação da permissão de false para verdadeira e exibição das imagens transformadas em bytes hexadeimais.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_descriptar_relatorio_Click(object sender, EventArgs e)
        {
            // Caso a chave privada não tenha sido informada, o usuário é alertado.
            if (chave_privada_imagem.Text.Equals(""))
            {
                if (cumi_acordada == true)
                {
                    // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                    try
                    {
                        cumi4.Pensar(2, 3);
                    }
                    catch
                    {
                        cumi4.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
                    }

                }

                MessageBox.Show("Informe a chave-privada antes de descriptar.");
            }

            // Se a chave-privada for informada, as informações são exibidas na label e o usuário recebe permissão para visualizar as imagens que o software enviou nas lables.
            else
            {
                permissao = true;
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel2.AutoScroll = true;

                // Chave-privada errada.
                if (!(chave_privada_imagem.Text.Equals("237")))
                {
                    imagem1_encriptada.Text = Acesso.imagem3;
                    imagem2_encriptada.Text = Acesso.imagem3;
                    legenda_imagem1 = "";
                    legenda_imagem2 = "";
                }

                // Chave-privada correta.
                else
                {
                    imagem1_encriptada.Text = Acesso.imagem1;
                    imagem2_encriptada.Text = Acesso.imagem2;
                    legenda_imagem1 = Acesso.legenda_imagem1;
                    legenda_imagem2 = Acesso.legenda_imagem2;
                }
                chave_privada_imagem.Text = "";
            }
        }

        /// <summary>
        /// Limpagem da tela (usada para esconder as informações disponíveis ao usuário).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_esconder_imagens_Click(object sender, EventArgs e)
        {
            permissao = false;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel2.AutoScroll = false;
            imagem1_encriptada.Text = "";
            imagem2_encriptada.Text = "";
            imagem1_descriptada.Image = null;
            imagem2_descriptada.Image = null;
            imagem1_descriptada.Text = "";
            imagem2_descriptada.Text = "";
        }

        /// <summary>
        /// Retorno à tela de relatório.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_voltar_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Relatorio relatorio = new Relatorio(cumi_acordada);
            relatorio.Show();
        }

        /// <summary>
        /// Exibição da imagem 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_descripat_imagem1_Click(object sender, EventArgs e)
        {
            // Caso a permissão para a exibição seja falsa, uma messagebox é exibida.
            if (permissao == false)
            {
                if (cumi_acordada == true)
                {
                    try
                    {
                        cumi4.Pensar(2, 6);
                    }
                    catch
                    {
                        cumi4.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
                    }
                }

                MessageBox.Show("Você não tem permissão para visualizar as imagens.");
            }

            // Se a permissão de exibição for verdadeira, a imagem 1 é exibida.
            else
            {
                
                Imagem imagem1 = new Imagem();
                byte[] imagem1_bytes = imagem1.String_Para_Byte_Array(imagem1_encriptada.Text);
                Image imagem1_visualizacao = imagem1.Byte_Array_Para_Imagem(imagem1_bytes);
                imagem1_descriptada.Image = imagem1_visualizacao;
                imagem1_descriptada.Text = legenda_imagem1;

            }
        }

        /// <summary>
        /// Exibição da imagem 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_descriptar_imagem2_Click(object sender, EventArgs e)
        {
            // Caso a permissão para a exibição seja falsa, uma messagebox é exibida.
            if (permissao == false)
            {
                if (cumi_acordada == true)
                {
                    try
                    {
                        cumi4.Pensar(2, 6);
                    }
                    catch
                    {
                        cumi4.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
                    }
                }

                MessageBox.Show("Você não tem permissão para visualizar as imagens.");
            }

            // Se a permissão de exibição for verdadeira, a imagem 2 é exibida.
            else
            {

                Imagem imagem2 = new Imagem();
                byte[] imagem2_bytes = imagem2.String_Para_Byte_Array(imagem2_encriptada.Text);
                Image imagem2_visualizacao = imagem2.Byte_Array_Para_Imagem(imagem2_bytes);
                imagem2_descriptada.Image = imagem2_visualizacao;
                imagem2_descriptada.Text = legenda_imagem2;

            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
