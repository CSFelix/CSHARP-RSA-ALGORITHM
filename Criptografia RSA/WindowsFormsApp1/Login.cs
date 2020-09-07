using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RSA_Crypto;
using AssistenteVirtual;
using Erros;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        Conteudo_Erros msg = new Conteudo_Erros(); // armazena conteúdos das mensagens de erros      

        public Login()
        {
            InitializeComponent();
        }

        /* 
         * PARA MAIOR SEGURANÇA, A VERIFICAÇÃO DE LOGIN E SENHA CORRETOS É REALIZADA COM AMBOS ENCRIPTADOS 
         * PORTANTO, PARA SABER QUAL O LOGIN E SENHA REAIS, VERIFIQUE A PASTA "ARQUIVOS txt"
        */
        
        /// <summary>
        /// Verifico se o login e a senha foram preenchidos corretamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrar_btn_Click_1(object sender, EventArgs e)
        {
            // Caso algum campo esteja vazio, uma message box é exibida
            if (Login_txt.Text.Equals("") || Senha_txt.Text.Equals("") || Cumi_status.Text.Equals(""))
            {

                // Se ambos estiverem vazios
                if (Login_txt.Text.Equals("") && Senha_txt.Text.Equals("") && Cumi_status.Text.Equals(""))
                {
                    var retornos = msg.Retorno_Erro_Login(0, 0);
                    MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                // Se nem todos estiverem vazios
                else if (Login_txt.Text.Equals("") || Senha_txt.Text.Equals("") || Cumi_status.Text.Equals(""))
                {
                    var retornos = msg.Retorno_Erro_Login(1, 0);
                    MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }

            // Caso o login e a senha não sejam nulos
            else
            {

                // Variáveis locais
                string login = Login_txt.Text;
                string senha = Senha_txt.Text;
                string login_encriptado;
                string senha_encriptada;
                string status;

                // Instanciação da classe XOR
                RSA_Processo criptacao_login = new RSA_Processo();
                RSA_Processo criptacao_senha = new RSA_Processo();

                // Encriptação da senha e do login
                login_encriptado = criptacao_login.Encriptacao(Login_txt.Text, false, (int)Chaves_Padronizadas.PUBLICA, (int)Chaves_Padronizadas.MISTA);
                senha_encriptada = criptacao_senha.Encriptacao(Senha_txt.Text, false, (int)Chaves_Padronizadas.PUBLICA, (int)Chaves_Padronizadas.MISTA);
                status = Cumi_status.Text;

                // Check se o login e a senha estão corretos
                // Se login ou senha não estiverem corretos, uma MessageBox é exibida
                if (!(login_encriptado.Equals(Informacoes_Confidenciais.login)) || !(senha_encriptada.Equals(Informacoes_Confidenciais.senha)) || !(status.Equals("ON - EN") || status.Equals("ON - PT") || status.Equals("OFF - EN") || status.Equals("OFF - PT")))
                {

                    // Caso o login estiver inválido
                    if (!(login_encriptado.Equals(Informacoes_Confidenciais.login)))
                    {
                        var retornos = msg.Retorno_Erro_Login(2, 0);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Login_txt.Text = "";
                        Senha_txt.Text = "";
                        Cumi_status.Text = "";
                    }

                    // Caso o login estiver correto, mas a senha, incorreta
                    else if (!(senha_encriptada.Equals(Informacoes_Confidenciais.senha)))
                    {
                        var retornos = msg.Retorno_Erro_Login(3, 0);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Senha_txt.Text = "";
                    }

                    // Caso o login e a senha estiverem corretos, mas o status da Cumi não
                    else if (!(status.Equals("ON - EN") || status.Equals("ON - PT") || status.Equals("OFF - EN") || status.Equals("OFF - PT")))
                    {
                        var retornos = msg.Retorno_Erro_Login(4, 0);
                        MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Cumi_status.Text = "";
                    }

                }

                // Se o login e a senha estiverem corretos, a tela inicial é carregada
                if ((login_encriptado.Equals(Informacoes_Confidenciais.login)) && (senha_encriptada.Equals(Informacoes_Confidenciais.senha)) && (status.Equals("ON - EN") || status.Equals("ON - PT") || status.Equals("OFF - EN") || status.Equals("OFF - PT")))
                {
                    Login_txt.Text = "";
                    Senha_txt.Text = "";

                    this.Hide();

                    // Processamento de instanciação da janela de carregamento
                    bool status_cumi, idioma_internacional, cumi_som;

                    // Envio de CUMI desativada
                    if (status.Equals("OFF - EN") || status.Equals("OFF - PT"))
                    {
                        status_cumi = false;
                        cumi_som = true;

                        // Desativação em Inglês
                        if (status.Equals("OFF - EN"))
                        {
                            idioma_internacional = true;
                        }
                        // Desativação em Português
                        else
                        {
                            idioma_internacional = false;
                        }
                    }

                    // Envio de CUMI ativada
                    else
                    {
                        status_cumi = true;
                        cumi_som = true;

                        // Ativação em Inglês
                        if (status.Equals("ON - EN"))
                        {
                            idioma_internacional = true;
                        }
                        // Ativação em Português
                        else
                        {
                            idioma_internacional = false;
                        }
                    }

                    // Instanciação da CUMI e da tela de carregamento
                    CUMI cumi = new CUMI(status_cumi, idioma_internacional, cumi_som);
                    Carregando carregar = new Carregando(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());

                    if (cumi.Check_Status() == true)
                    {
                        try
                        {
                            cumi.Pensar_Fala(0, 0);
                        }
                        catch
                        {
                            string alerta = "";
                            cumi.Pensar_Fala(2, 16);

                            if (cumi.Check_Idioma_Internacional() == true)
                            {
                                alerta = "A serious error was found. Please, Notice the programmer.";
                            }
                            else
                            {
                                alerta = "Um erro grave foi encontrado. Por favor, avise ao programador.";
                            }

                            MessageBox.Show(alerta);
                        }

                    }

                    carregar.Show();
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
