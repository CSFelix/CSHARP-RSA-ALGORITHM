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
    public partial class Relatorio : Form
    {
        CUMI cumi3 = new CUMI();
        bool cumi_acordada; // armazena a condição de que a CUMI está mesma acordada ou não.

        public Relatorio(bool cumi_acordada)
        {
            this.cumi_acordada = cumi_acordada;
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
            
            Inicio inicio = new Inicio(cumi_acordada);
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
                if (cumi_acordada == true)
                {
                    // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                    try
                    {
                        cumi3.Pensar(2, 3);
                    }
                    catch
                    {
                        cumi3.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
                    }
                }

                MessageBox.Show("Informe o valor da chave privada antes de descriptografar a mensagem.");
            }

            // Chave-privada informada.
            else
            {
                try
                {
                    Crypto c = new RSA();
                    titulo.Text = c.Decriptacao(true, titulo.Text, Convert.ToInt32(chave_privada_relatorio.Text));
                    data.Text = c.Decriptacao(true, data.Text, Convert.ToInt32(chave_privada_relatorio.Text));
                    relatorio_descricao.Text = c.Decriptacao(true, relatorio_descricao.Text, Convert.ToInt32(chave_privada_relatorio.Text));
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
            Crypto d = new RSA();
            titulo.Text = d.Encriptacao(true, titulo.Text, Acesso.chave_publica);
            data.Text = d.Encriptacao(true, data.Text, Acesso.chave_publica);
            relatorio_descricao.Text = d.Encriptacao(true, relatorio_descricao.Text, Acesso.chave_publica);
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
            Imagens_relatorio imagens = new Imagens_relatorio(cumi_acordada);
            imagens.Show();
           
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
