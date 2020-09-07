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
    public partial class Relatorio : Form
    {
        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;
        Conteudo_Erros msg = new Conteudo_Erros();

        public Relatorio(bool status_cumi, bool idioma_internacional, bool cumi_som)
        {
            this.status_cumi = status_cumi;
            this.idioma_internacional = idioma_internacional;
            this.cumi_som = cumi_som;
            cumi = new CUMI(this.status_cumi, this.idioma_internacional, this.cumi_som);
            InitializeComponent();
        }

        /// <summary>
        /// Retorno à tela inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_voltar_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Inicio inicio = new Inicio(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
            inicio.Show();
        }

       /// <summary>
       /// Descriptação do relatório.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_descriptar_relatorio_Click(object sender, EventArgs e)
        {
            // Chave-privada não informada.
            if (chave_privada_relatorio.Text.Equals(""))
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

            // Chave-privada informada.
            else
            {
                try
                {
                    RSA_Processo criptacao_titulo = new RSA_Processo();
                    RSA_Processo criptacao_data = new RSA_Processo();
                    RSA_Processo criptacao_descricao = new RSA_Processo();

                    titulo.Text = criptacao_titulo.Decriptacao(titulo.Text, false, Convert.ToInt32(chave_privada_relatorio.Text), (int)Chaves_Padronizadas.MISTA);
                    data.Text = criptacao_data.Decriptacao(data.Text, false, Convert.ToInt32(chave_privada_relatorio.Text), (int)Chaves_Padronizadas.MISTA);
                    relatorio_descricao.Text = criptacao_descricao.Decriptacao(relatorio_descricao.Text, false, Convert.ToInt32(chave_privada_relatorio.Text), (int)Chaves_Padronizadas.MISTA);
                }
                catch
                {
                    relatorio_descricao.Text = "X??????X"; //exemplo disso ocorrer: quando um caractere-letra é passado como chave.
                }
                finally
                {
                    flowLayoutPanel1.AutoScroll = false;
                }
               
            }

            chave_privada_relatorio.Text = "";
        }
        
        /// <summary>
        /// Encriptação automática do relatório (sem a necessidade de informar a chave pública).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_encriptar_relatorio_Click(object sender, EventArgs e)
        {
            RSA_Processo decriptacao_titulo = new RSA_Processo();
            RSA_Processo decriptacao_data = new RSA_Processo();
            RSA_Processo decriptacao_descricao = new RSA_Processo();

            titulo.Text = decriptacao_titulo.Encriptacao(titulo.Text, false, (int)Chaves_Padronizadas.PUBLICA, (int)Chaves_Padronizadas.MISTA);
            data.Text = decriptacao_data.Encriptacao(data.Text, false, (int)Chaves_Padronizadas.PUBLICA, (int)Chaves_Padronizadas.MISTA);
            relatorio_descricao.Text = decriptacao_descricao.Encriptacao(relatorio_descricao.Text, false, (int)Chaves_Padronizadas.PUBLICA, (int)Chaves_Padronizadas.MISTA);
            flowLayoutPanel1.AutoScroll = true;
        }

        /// <summary>
        /// Fechamento da tela de relatório e exibição da de imagens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_imagens_Click(object sender, EventArgs e)
        {
            chave_privada_relatorio.Text = "";
            this.Hide();
            Imagens_relatorio imagens = new Imagens_relatorio(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
            imagens.Show();
           
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
