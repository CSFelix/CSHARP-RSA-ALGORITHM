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
    public partial class Carregando : Form
    {
        CUMI cumi2 = new CUMI();
        bool cumi_acordada; // armazena a condição de que a CUMI está mesma acordada ou não.

        public Carregando(bool cumi_acordada)
        {
            this.cumi_acordada = cumi_acordada;
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
                Inicio inicio = new Inicio(cumi_acordada);
                inicio.Show();

                if (cumi_acordada == true)
                {
                    // Caso eu tenha passado algum parâmetro errado, a CUMI alertará o usuário junto com uma messagebox
                    try
                    {
                        cumi2.Pensar(1, 1);
                    }
                    catch
                    {
                        cumi2.Pensar(2, 11);
                        MessageBox.Show("Um erro encontrado, avise ao programador!");
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
