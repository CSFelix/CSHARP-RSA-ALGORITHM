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
using Erros;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;
        Conteudo_Erros msg = new Conteudo_Erros();

        public Inicio(bool status_cumi, bool idioma_internacional, bool cumi_som)
        {
            this.status_cumi = status_cumi;
            this.idioma_internacional = idioma_internacional;
            this.cumi_som = cumi_som;
            cumi = new CUMI(this.status_cumi, this.idioma_internacional, this.cumi_som);
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
                Application.Exit();
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
            Relatorio relatorio = new Relatorio(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
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
            Criptacao criptografia = new Criptacao(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
            criptografia.Show();
        }

        /// <summary>
        /// Quando o mouse estiver sobre a label link do relatório, sua descrição é dita pela CUMI caso ela esteja acordada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RELATORIO_MouseHover(object sender, EventArgs e)
        {
            RELATORIO.BackColor = Color.White;
            if (cumi.Check_Status() == true)
            {
                try
                {
                    cumi.Pensar_Fala(1, 0);
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
        /// Quando o mouse estiver sobre o label link da criptação, sua descrição é dita pela CUMI caso ela esteja acordada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRIPTACAO_MouseHover(object sender, EventArgs e)
        {
            CRIPTACAO.BackColor = Color.White;
            if (cumi.Check_Status() == true)
            {
                try
                {
                    cumi.Pensar_Fala(1, 1);
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
        /// Quando o mouse estiver sobre o label link da SAS IA, sua descrição é dita pela CUMI caso ela esteja acordada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SAS_IA_MouseHover(object sender, EventArgs e)
        {
            SAS_IA.BackColor = Color.White;
            if (cumi.Check_Status() == true)
            {
                try
                {
                    cumi.Pensar_Fala(1, 2);
                }
                catch
                {
                    cumi.Pensar_Fala(2, 16);
                    var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                    MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SAS_IA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CMD_cumi cmd_cumi = new CMD_cumi(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
            cmd_cumi.Show();
        }

        private void SAS_IA_MouseLeave(object sender, EventArgs e)
        {
            SAS_IA.BackColor = Color.LightSkyBlue;
        }

        private void CRIPTACAO_MouseLeave(object sender, EventArgs e)
        {
            CRIPTACAO.BackColor = Color.LightSkyBlue;
        }

        private void RELATORIO_MouseLeave(object sender, EventArgs e)
        {
            RELATORIO.BackColor = Color.LightSkyBlue;
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

            if (cumi.Check_Status() == true)
            {
                // A CUMI tenta processar o comando enviado a ela.
                // Caso ela mão o reconhecer, cairá no bloco catch deste try
                try
                {
                    if (comando.Equals(""))
                    {
                        try
                        {
                            cumi.Pensar_Fala(2, 0);
                            var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 0, 0);
                            MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        catch
                        {
                            cumi.Pensar_Fala(2, 16);
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            cumi.Pensar_Diretorio(comando);
                        }

                        catch
                        {
                            cumi.Pensar_Fala(2, 16);
                            var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                            MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Comando não reconhecido
                catch
                {                   
                    try
                    {                      
                        cumi.Pensar_Fala(2, 1);                      
                    }

                    catch
                    {
                        cumi.Pensar_Fala(2, 16);
                        var retornos1 = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 16, 3);
                        MessageBox.Show(retornos1.Item1, retornos1.Item2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    /* Essa MessageBox está com problemas de exibição */
                    var retornos = msg.Retorno_Erro_Processo(cumi.Check_Idioma_Internacional(), 1, 0);
                    MessageBox.Show(retornos.Item1, retornos.Item2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // CUMI dormindo: o único comando que obedecerá será o de acordar.
            else
            {
                bool comando_acordar = false;

                // Check em Inglês
                if (cumi.Check_Idioma_Internacional() == true)
                {
                    if (comando.Equals("wake"))
                    {
                        comando_acordar = true;
                    }
                }
                // Check em Português
                else
                {
                    if (comando.Equals("acorde"))
                    {
                        comando_acordar = true;
                    }
                }

                if (comando_acordar == true)
                {
                    try
                    {
                        cumi.Pensar_Diretorio(comando);
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

        private void tela_inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
