using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using Criptografia;
using VoiceBot;

namespace WindowsFormsApp1
{
    public partial class Criptacao : Form
    {
        CUMI cumi5 = new CUMI();
        bool cumi_acordada; // armazena a condição de que a CUMI está mesma acordada ou não.

        public Criptacao(bool cumi_acordada)
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

            // Instanciação da tela inicial.
            Inicio inicio = new Inicio(cumi_acordada);
            inicio.Show();
        }

        /// <summary>
        /// Caminho à área de criptação de imagens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_imagens_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Instanciação da tela de criptação de imagens.
            Criptacao_imagens imagens = new Criptacao_imagens(cumi_acordada);
            imagens.Show();
        }

        /// <summary>
        /// Retorno do tamanho da mensagem a ser encriptada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mostrar_tamanho_msg_descriptada_Click(object sender, EventArgs e)
        {
            int comprimento;
            comprimento = msg_descriptada_en.TextLength; 
            tamanho_msg_descriptada.Text = Convert.ToString(comprimento); 
        }

        /// <summary>
        /// Retorno do tamanho da mensagem a ser descriptada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mostrar_tamanho_msg_encriptada_Click(object sender, EventArgs e)
        {   
            int comprimento;
            comprimento = msg_encriptada_de.TextLength; 
            tamanho_msg_encriptada.Text = Convert.ToString(comprimento);
        }

        /// <summary>
        /// Encriptação da mensagem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            // Caso a chave pública ou a mensagem a encriptar não sejam informadas.
            if ((chave_publica.Text.Equals("")) || (msg_descriptada_en.Text.Equals("")))
            {
                /*  Para todos os casos aqui presentes, uma MessageBox será exibida! */

                // Se nenhuma das duas forem informadas
                if ((chave_publica.Text.Equals("")) && (msg_descriptada_en.Text.Equals("")))
                {
                    if (cumi_acordada == true)
                    {
                        // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                        try
                        {
                            cumi5.Pensar(2, 0);
                        }
                        catch
                        {
                            cumi5.Pensar(2, 11);
                            MessageBox.Show("Um erro encontrado, avise ao programador!");
                        }
                    }

                    MessageBox.Show("Chave-pública e campo de mensagem não informados.\nPor favor, informe-os antes de encriptar.");
                }

                // Caso uma das duas não ser informada.
                else
                {
                    // Se a chave-pública não for informada
                    if (chave_publica.Text.Equals(""))
                    {
                        if (cumi_acordada == true)
                        {
                            // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                            try
                            {
                                cumi5.Pensar(2, 2);
                            }
                            catch
                            {
                                cumi5.Pensar(2, 11);
                                MessageBox.Show("Um erro encontrado, avise ao programador!");
                            }
                        }

                        MessageBox.Show("Chave-pública não informada.");
                    }

                    // Se a mensagem não informada
                    else
                    {
                        if (cumi_acordada == true)
                        {
                            try
                            {
                                cumi5.Pensar(2, 4);
                            }
                            catch
                            {
                                cumi5.Pensar(2, 11);
                                MessageBox.Show("Um erro encontrado, avise ao programador!");
                            }
                        }

                        MessageBox.Show("Mensagem a encriptar não informada.");
                    }

                }

            }

            // Caso ambas sejam informadas, finalmente a encriptação ocorre.
            else
            {
                // Se a encriptação ocorrer normalmente, a mensagem encriptada é exibida.
                try
                {
                    Crypto c = new RSA();
                    msg_encriptada_en.Text = c.Encriptacao(false, msg_descriptada_en.Text, Convert.ToInt32(chave_publica.Text));
                }
                catch
                {
                    msg_encriptada_en.Text = "X??????X"; // um exemplo disso aqui ocorrer é quando o usuário passa um caractere-letra como chave.
                }
               
            }
        }

       /// <summary>
       /// Descriptação da mensagem.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_descriptar_Click(object sender, EventArgs e)
        {
            // Caso a chave-privada ou a mensagem não sejam informadas
            if ((chave_privada.Text.Equals("")) || (msg_encriptada_de.Text.Equals("")))
            {
                /*  Para todos os casos aqui presentes, uma MessageBox será exibida! */

                // Caso ambas não sejam informadas
                if ((chave_privada.Text.Equals("")) && (msg_encriptada_de.Text.Equals("")))
                {
                    if (cumi_acordada == true)
                    {
                        try
                        {
                            cumi5.Pensar(2, 1);
                        }
                        catch
                        {
                            cumi5.Pensar(2, 11);
                            MessageBox.Show("Um erro encontrado, avise ao programador!");
                        }
                    }

                    MessageBox.Show("Chave-privada e campo de mensagem não informados. \nPor favor, informe - os antes de descriptar.");
                }

                // Caso uma das duas não seja informada
                else
                {
                    // Se a chave-privada não for informada
                    if (chave_privada.Text.Equals(""))
                    {
                        if (cumi_acordada == true)
                        {
                            try
                            {
                                cumi5.Pensar(2, 3);
                            }
                            catch
                            {
                                cumi5.Pensar(2, 11);
                                MessageBox.Show("Um erro encontrado, avise ao programador!");
                            }
                        }

                        MessageBox.Show("Chave-privada não informada.");
                    }

                    // Se a mensagem não for informada
                    else
                    {
                        if (cumi_acordada == true)
                        {
                            try
                            {
                                cumi5.Pensar(2, 5);
                            }
                            catch
                            {
                                cumi5.Pensar(2, 11);
                                MessageBox.Show("Um erro encontrado, avise ao programador!");
                            }
                        }

                        MessageBox.Show("Mensagem a descriptar não informada.");
                    }

                }
            }

            // Caso ambas sejam informadas, ocorre a descriptação.
            else
            {
                // Se a descriptação ocorrer normalmente, a mensagem descriptada é exibida.
                try
                {
                    Crypto d = new RSA();
                    msg_descriptada_de.Text = d.Decriptacao(false, msg_encriptada_de.Text, Convert.ToInt32(chave_privada.Text));
                }
                catch
                {
                    msg_descriptada_de.Text = "X??????X"; // exemplo disso ocorrer: um caractere-letra passado como chave.
                }
                
            }
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }


    
}