using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistenteVirtual;
using RSA_Crypto;
using Erros;

namespace WindowsFormsApp1
{
    public partial class Imagens_relatorio : Form
    {
        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;
        Conteudo_Erros msg = new Conteudo_Erros();

        bool permissao = false; // permissão para visualizar as imagens
        string legenda_imagem1, legenda_imagem2; // legendas das imagens

        public Imagens_relatorio(bool status_cumi, bool idioma_internacional, bool cumi_som)
        {
            this.status_cumi = status_cumi;
            this.idioma_internacional = idioma_internacional;
            this.cumi_som = cumi_som;
            cumi = new CUMI(this.status_cumi, this.idioma_internacional, this.cumi_som);
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
                var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 12, 1);
                MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (cumi.Check_Status() == true)
                {
                    try
                    {
                        cumi.Pensar_Fala(2, 12);
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Se a chave-privada for informada, as informações são exibidas na label e o usuário recebe permissão para visualizar as imagens que o software enviou nas lables.
            else
            {
                permissao = true;
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel2.AutoScroll = true;

                // Chave-privada errada.
                if (!(chave_privada_imagem.Text.Equals(Convert.ToString((int)Chaves_Padronizadas.PRIVADA))))
                {
                    imagem1_encriptada.Text = Informacoes_Confidenciais.imagem3;
                    imagem1_encriptada.BackColor = Color.LightSkyBlue;
                    imagem2_encriptada.Text = Informacoes_Confidenciais.imagem3;
                    imagem2_encriptada.BackColor = Color.LightSkyBlue;
                    legenda_imagem1 = "";
                    legenda_imagem2 = "";
                }

                // Chave-privada correta.
                else
                {
                    imagem1_encriptada.Text = Informacoes_Confidenciais.imagem1;
                    imagem1_encriptada.BackColor = Color.LightSkyBlue;
                    imagem2_encriptada.Text = Informacoes_Confidenciais.imagem2;
                    imagem2_encriptada.BackColor = Color.LightSkyBlue;
                    legenda_imagem1 = Informacoes_Confidenciais.legenda_imagem1;
                    legenda_imagem2 = Informacoes_Confidenciais.legenda_imagem2;
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
            Relatorio relatorio = new Relatorio(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
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
                var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 2, 2);
                MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (cumi.Check_Status() == true)
                {
                    try
                    {
                        cumi.Pensar_Fala(2, 2);
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Se a permissão de exibição for verdadeira, a imagem 1 é exibida.
            else
            {
                
                Imagem_Array imagem1 = new Imagem_Array();

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
                var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 2, 2);
                MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (cumi.Check_Status() == true)
                {
                    try
                    {
                        cumi.Pensar_Fala(2, 2);
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Se a permissão de exibição for verdadeira, a imagem 2 é exibida.
            else
            {

                Imagem_Array imagem2 = new Imagem_Array();

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
