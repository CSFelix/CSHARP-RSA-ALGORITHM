using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sair : Form
    {
        public sair()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Logout confirmado e retorno à tela de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
     
            tela_login login = new tela_login();
            login.Show();
        }


        /// <summary>
        /// Logout recusado e retorno à tela inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sair_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }


}
