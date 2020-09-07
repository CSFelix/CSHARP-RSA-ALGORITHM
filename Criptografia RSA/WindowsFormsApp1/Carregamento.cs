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

namespace WindowsFormsApp1
{
    public partial class Carregando : Form
    {
        bool status_cumi, idioma_internacional, cumi_som;
        CUMI cumi = null;

        public Carregando(bool status_cumi, bool idioma_internacional, bool cumi_som)
        {
            this.status_cumi = status_cumi;
            this.idioma_internacional = idioma_internacional;
            this.cumi_som = cumi_som;
            cumi = new CUMI(this.status_cumi, this.idioma_internacional, this.cumi_som);
            InitializeComponent();
        }

        /// <summary>
        /// Contagem do timer, incrementação da progressbar e exibição da tela inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Carregamento em andamento e incrementação da progressbar em andamento.
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
                label2.Text = progressBar1.Value + "%";
            }

            // Carregamento completo e exibição da tela inicial.
            else
            {
                timer1.Enabled = false;
                this.Hide();

                // Instanciação da tela inicial
                Inicio inicio = new Inicio(cumi.Check_Status(), cumi.Check_Idioma_Internacional(), cumi.Check_Som());
                inicio.Show();

                if (cumi.Check_Status() == true)
                {
                    try
                    {
                        cumi.Pensar_Fala(0, 1);
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
            }
        }


        private void Carregando_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
