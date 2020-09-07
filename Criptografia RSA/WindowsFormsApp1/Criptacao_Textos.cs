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
using AssistenteVirtual;
using RSA_Crypto;
using Erros;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Criptacao : Form
    {
        Conteudo_Erros msg = new Conteudo_Erros(); // armazena conteúdos das mensagens de erros

        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;

        public Criptacao(bool status_cumi, bool idioma_internacional, bool cumi_som)
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

            // Instanciação da tela inicial.
            Inicio inicio = new Inicio(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
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
            Criptacao_imagens imagens = new Criptacao_imagens(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
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
            // Caso algum input não tenha sido informado
            if ((chave_publica.Text.Equals("")) || (chave_mista.Text.Equals("")) || (msg_descriptada_en.Text.Equals("")))
            {

                // Caso a mensagem, a chave-mista e a pública não sejam informadas
                if ((chave_publica.Text.Equals("")) && (chave_mista.Text.Equals("")) && (msg_descriptada_en.Text.Equals("")))
                {
                    var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 3, 1);
                    MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (cumi.Check_Status() == true)
                    {
                        try
                        {
                            cumi.Pensar_Fala(2, 3);
                        }

                        catch
                        {
                            cumi.Pensar_Fala(2, 16);
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Caso uma delas não tenha sido informada
                else if ((chave_publica.Text.Equals("")) ^ (chave_mista.Text.Equals("")) ^ (msg_descriptada_en.Text.Equals("")))
                {
                    /* Chave-Pública */
                    if (chave_publica.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 11, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        try
                        {
                            cumi.Pensar_Fala(2, 11);
                        }

                        catch
                        {
                            cumi.Pensar_Fala(2, 16);
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    /* Chave-Mista */
                    else if (chave_mista.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 10, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 10);
                            }

                            catch
                            {
                                cumi.Pensar_Fala(2, 16);
                                var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                                MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    /* Mensagem Decriptada */
                    else
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 17, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 17);
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

                // Caso duas não tenham sido informadas
                else
                {
                    /* Chave-Mista e Pública */
                    if (chave_mista.Text.Equals("") && chave_publica.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 8, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 8);
                            }

                            catch
                            {
                                cumi.Pensar_Fala(2, 16);
                                var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                                MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    /* Chave-Mista e Mensagm Decriptada */
                    else if (chave_mista.Text.Equals("") && msg_descriptada_en.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 5, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 5);
                            }

                            catch
                            {
                                cumi.Pensar_Fala(2, 16);
                                var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                                MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    /* Chave-Pública e Mensagem Decriptada */
                    else if (chave_publica.Text.Equals("") && msg_descriptada_en.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 6, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 6);
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

            // Caso ambas sejam informadas, finalmente a encriptação ocorre.
            else
            {
                // Se a encriptação ocorrer normalmente, a mensagem encriptada é exibida.
                try
                {
                    RSA_Processo criptacao_msg_decriptada = new RSA_Processo();
                    msg_encriptada_en.Text = criptacao_msg_decriptada.Encriptacao(msg_descriptada_en.Text, false, Convert.ToInt32(chave_publica.Text), Convert.ToInt32(chave_mista.Text));
                }

                catch
                {
                    msg_encriptada_en.Text = "X??????X"; // um exemplo disso aqui ocorrer é quando o usuário passa um caractere-letra como chave.
                }

            }

        }

       /// <summary>
       /// Instanciação e exibição do Form de Densidade.
       /// </summary>
       /// <remarks>
       /// Tal Form fornece informações sobre o comprimento de bytes e porcentagens de densidades entre uma mensagem decriptada e encriptada.
       /// </remarks>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_densidade_Click(object sender, EventArgs e)
        {
            // O Form apenas será instanciado e exibido se:
            // 1 → o campo da mensagem decriptada e encriptada em Decriptação estiverem preenchidos;
            // 2 → o campo da chave-mista estiver preenchido.
            if (!(msg_descriptada_de.Text.Equals("")) && !(msg_encriptada_de.Text.Equals("")) && !(chave_mista.Text.Equals("")))
            {
                // O software tentará instanciar a Janela, caso algum erro ocorrer, o usuário será alertado.
                // O principal erro que pode ocorrer é no terceiro parâmetro: 
                // se o campo da chave-mista ter sido preenchido por caracteres não numéricos,
                // não será possível convertê-lo para int e, consequentemente, o Form não será criado.
                try
                {
                    // Instanciação da Janela de Densidade
                    Densidade_Mensagens dm = new Densidade_Mensagens(msg_descriptada_de.Text, msg_encriptada_de.Text, Convert.ToInt32(Math.Floor(Math.Log10(Convert.ToDouble(chave_mista.Text))) + 1));
                    dm.Show();
                }
                
                catch
                {                 
                    try
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 19, 4);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        cumi.Pensar_Fala(2, 19);
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 18, 1);
                MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                try
                {
                    cumi.Pensar_Fala(2, 18);
                }

                catch
                {
                    cumi.Pensar_Fala(2, 16);
                    var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                    MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Caso algum input não tenha sido informado
            if ((chave_privada.Text.Equals("")) || (chave_mista.Text.Equals("")) || (msg_encriptada_de.Text.Equals("")))
            {
                // Caso a mensagem, a chave-mista e a privada não tenham sido informadas
                if ((chave_privada.Text.Equals("")) && (chave_mista.Text.Equals("")) && (msg_encriptada_de.Text.Equals("")))
                {
                    var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 4, 1);
                    MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (cumi.Check_Status() == true)
                    {
                        try
                        {
                            cumi.Pensar_Fala(2, 4);
                        }

                        catch
                        {
                            cumi.Pensar_Fala(2, 16);
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Caso uma das três não tenha sido informada
                else if ((chave_privada.Text.Equals("")) ^ (chave_mista.Text.Equals("")) ^ (msg_encriptada_de.Text.Equals("")))
                {
                    /* Chave-Privada */
                    if (chave_privada.Text.Equals(""))
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

                    /* Chave-Mista */
                    else if (chave_mista.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 10, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 10);
                            }

                            catch
                            {
                                cumi.Pensar_Fala(2, 16);
                                var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                                MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    /* Mensagem Encriptada */
                    else 
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 17, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 17);
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
            
                // Caso duas delas não tenham sido informadas
                else
                {
                    /* Chave-Mista e Privada */
                    if (chave_mista.Text.Equals("") && chave_privada.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 9, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 9);
                            }

                            catch
                            {
                                cumi.Pensar_Fala(2, 16);
                                var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                                MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    /* Chave-Mista e Mensagem Encriptada */
                    else if (chave_mista.Text.Equals("") && msg_encriptada_de.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 5, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 5);
                            }

                            catch
                            {
                                cumi.Pensar_Fala(2, 16);
                                var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                                MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    /* Chave-Privada e Mensagem Encriptada */
                    else if (chave_privada.Text.Equals("") && msg_encriptada_de.Text.Equals(""))
                    {
                        var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 7, 1);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cumi.Check_Status() == true)
                        {
                            try
                            {
                                cumi.Pensar_Fala(2, 7);
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

            // Caso ambas sejam informadas, ocorre a descriptação.
            else
            {
       
                // Tentativa de decriptação
                try
                {
                    int Chave_Privada = 0;
                    RSA_Processo criptacao_msg_encriptada = new RSA_Processo();
                    // Tentativa de atribuição de valor na variávbel "Chave_Privada"
                    // Dois possíveis erros são:
                    // 1 → Nenhum primo informado nas textbox's correspondentes;
                    // 2 → Dado impossível de ser convertido para Int32 nas textbox's correspondentes.
                    try
                    {
                        Chave_Privada = (check_valor_negativo.Checked) ? criptacao_msg_encriptada.Chave_Privada_Negativa(Convert.ToInt32(primo1.Text), Convert.ToInt32(primo2.Text), Convert.ToInt32(chave_privada.Text)) : Convert.ToInt32(chave_privada.Text);
                        
                    }

                    catch
                    {
                        if (primo1.Text.Equals("") || primo2.Text.Equals(""))
                        {
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 20, 0);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                        else
                        {
                            var retornos2 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 21, 5);
                            MessageBox.Show(retornos2.Item1, retornos2.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }

                    msg_descriptada_de.Text = criptacao_msg_encriptada.Decriptacao(msg_encriptada_de.Text, false, Chave_Privada, Convert.ToInt32(chave_mista.Text));
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