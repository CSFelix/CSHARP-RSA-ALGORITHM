using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoiceBot;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        CUMI cumi7 = new CUMI();
        bool cumi_acordada;

        public Inicio(bool cumi_acordada)
        {
            this.cumi_acordada = cumi_acordada;
            InitializeComponent();
        }

        /// <summary>
        /// Retorno à janela de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult escolha_sair = MessageBox.Show("Deseja deslogar de sua conta?", "Configuração de fechamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Arrumar aqui (quando fecho a nova janela instanciada, o programa continua rodando)
            if (escolha_sair == DialogResult.Yes)
            {
                this.Hide();

                // Instanciação da janela de login
                Login login = new Login();
                login.Show();
            }

        }

        /// <summary>
        /// Fechamento da tela inicial exibição da de relatório.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RELATORIO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
         
            // Instanciação da janela de relatório
            cumi_acordada = cumi7.Check_Acordada();
            Relatorio relatorio = new Relatorio(cumi_acordada);
            relatorio.Show();
        }

        /// <summary>
        /// Fechamento da tela inicial e exibição da de criptografia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRIPTACAO_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Instanciação da janela de criptação
            cumi_acordada = cumi7.Check_Acordada();
            Criptacao criptografia = new Criptacao(cumi_acordada);
            criptografia.Show();
        }

        /// <summary>
        /// Quando o mouse estiver sobre a label link do relatório, sua descrição é dita pela CUMI caso ela esteja acordada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RELATORIO_MouseHover(object sender, EventArgs e)
        {
            if (cumi_acordada == true)
            {
                // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                try
                {
                    cumi7.Pensar(0, 0);
                }
                catch
                {
                    cumi7.Pensar(2, 11);
                    MessageBox.Show("Um erro encontrado, avise ao programador!");
                }
            }
        }

        /// <summary>
        /// Quando o mouse estiver sobre o label link da criptação, sua descrição é dita pela CUMI caso ela esteja acordada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRIPTACAO_MouseHover(object sender, EventArgs e)
        {
            if (cumi_acordada == true)
            {
                try
                {
                    cumi7.Pensar(0, 1);
                }
                catch
                {
                    cumi7.Pensar(2, 11);
                    MessageBox.Show("Um erro encontrado, avise ao programador!");
                }
            }
        }

        /// <summary>
        /// Quando o mouse estiver sobre o label link da SAS IA, sua descrição é dita pela CUMI caso ela esteja acordada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SAS_IA_MouseHover(object sender, EventArgs e)
        {
            if (cumi_acordada == true)
            {
                try
                {
                    cumi7.Pensar(0, 2);
                }
                catch
                {
                    cumi7.Pensar(2, 11);
                    MessageBox.Show("Um erro encontrado, avise ao programador!");
                }
            }
        }

        /// <summary>
        /// Envio de comandos à CUMI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_enviar_comando_Click(object sender, EventArgs e)
        {
            string comando = linha_comando.Text.ToLower(); // qualquer comando é passado para minúsculo
            linha_comando.Text = "";

            // Nenhum comando foi digitado
            if (comando.Equals(""))
            {
                MessageBox.Show("Digite um comando antes de enviar.");
            }

            // Comando digitado
            else
            {
                // CUMI acordada
                if (cumi_acordada == true)
                {
                    // A CUMI tenta processar o comando enviado a ela.
                    // Caso ela mão o reconhecer, cairá no bloco catch DESTE try
                    try
                    {
                        // Caso nenhum comando tenha sido enviado, a CUMI alertará o usuário junto com uma messagebox
                        if (comando.Equals(""))
                        {
                            try
                            {
                                cumi7.Pensar(2, 12);
                            }
                            catch
                            {
                                cumi7.Pensar(2, 11);
                                MessageBox.Show("Um erro encontrado, avise ao programador!");
                            }
                        }

                        // Caso algum comando tenha sido enviado, a CUMI o processará.
                        else
                        {
                            try
                            {
                                cumi7.Pensar(1, 2); // "OK"

                                cumi7.Refletir(comando);
                            }
                            catch
                            {
                                cumi7.Pensar(2, 11);
                                MessageBox.Show("Um erro encontrado, avise ao programador!");
                            }
                        }
                    }

                    // Comando não reconhecido.
                    catch
                    {
                        try
                        {
                            cumi7.Pensar(2, 10);
                        }
                        catch
                        {
                            cumi7.Pensar(2, 11);
                            MessageBox.Show("Um erro encontrado, avise ao programador!");
                        }
                    }
                }

                // CUMI dormindo: o único comando que obedecerá será o de acordar.
                else
                {
                    if (comando.Equals("acorde"))
                    {
                        cumi_acordada = true;
                        MessageBox.Show("Acordei!");
                        cumi7.Refletir(comando);
                    }
                }
            }
        }

        private void tela_inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
