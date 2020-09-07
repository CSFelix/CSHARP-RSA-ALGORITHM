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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        CUMI cumi1 = new CUMI(); // instanciação da CUMI
        bool cumi_acordada; // armazena a condição de que a CUMI está mesma acordada ou não.

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
                    MessageBox.Show("Os campos estão vazios, por favor, preencha-os antes de entrar.");
                }

                // Se nem todos estiverem vazios
                else if (Login_txt.Text.Equals("") || Senha_txt.Text.Equals("") || Cumi_status.Text.Equals(""))
                {
                    MessageBox.Show("Algum(ns) dos campos está(ão) vazio(s), por favor, preencha-o(s) antes de entrar.");
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
                Crypto c = new RSA();

                // Encriptação da senha e do login
                login_encriptado = c.Encriptacao(false, Login_txt.Text, 13);
                senha_encriptada = c.Encriptacao(false, Senha_txt.Text, 13);
                status = Cumi_status.Text;

                // Check se o login e a senha estão corretos
                // Se login ou senha não estiverem corretos, uma MessageBox é exibida
                if (!(login_encriptado.Equals(Acesso.login)) || !(senha_encriptada.Equals(Acesso.senha)) || !(status == "ON" ^ status == "OFF"))
                {

                    // Caso o login estiver inválido
                    if (!(login_encriptado.Equals(Acesso.login)))
                    {
                        MessageBox.Show("Login inválido.");
                        Login_txt.Text = "";
                        Senha_txt.Text = "";
                        Cumi_status.Text = "";
                    }

                    // Caso o login estiver correto, mas a senha, incorreta
                    else if (!(senha_encriptada.Equals(Acesso.senha)))
                    {
                        MessageBox.Show("Senha inválida.");
                        Senha_txt.Text = "";
                    }

                    // Caso o login e a senha estiverem corretos, mas o status da Cumi não
                    else if (!(status == "ON" ^ status == "OFF"))
                    {
                        MessageBox.Show("O status da CUMI não foi informado corretamente. Verifique se você enviou \"ON\" ou \"OFF\", ou se está com o capslock desativado. ");
                        Cumi_status.Text = "";
                    }

                }

                // Se o login e a senha estiverem corretos, a tela inicial é carregada
                if ((login_encriptado.Equals(Acesso.login)) && (senha_encriptada.Equals(Acesso.senha)) && (status == "ON" ^ status == "OFF"))
                {
                    Login_txt.Text = "";
                    Senha_txt.Text = "";

                    this.Hide();

                    // Instanciação da tela de carregamento
                    if (status == "OFF")
                    {
                        cumi_acordada = false;
                    }
                    else
                    {
                        cumi_acordada = true;

                        // Caso eu tenha passada algum parâmetro errado, a CUMI alertará o usuário junto com uma MessageBox
                        try
                        {
                            cumi1.Pensar(1, 0);
                        }
                        catch
                        {
                            cumi1.Pensar(2, 11);
                            MessageBox.Show("Um erro encontrado, avise ao programador!");
                        }
                    }

                    Carregando carregar = new Carregando(cumi_acordada);
                    carregar.Show();
                }
            }
        }
    }
}
