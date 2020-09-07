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
    public partial class CMD_cumi : Form
    {
        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;
        Conteudo_Erros msg = new Conteudo_Erros();

        public CMD_cumi(bool status_cumi, bool idioma_internacional, bool cumi_som)
        {
            this.status_cumi = status_cumi;
            this.idioma_internacional = idioma_internacional;
            this.cumi_som = cumi_som;
            cumi = new CUMI(this.status_cumi, this.idioma_internacional, this.cumi_som);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comando = comandotxt.Text;
            comandotxt.Text = "";

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
    }
}
