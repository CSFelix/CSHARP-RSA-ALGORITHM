using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA_Crypto;

namespace WindowsFormsApp1
{
    public partial class Densidade_Mensagens : Form
    {
        // Objetos
        Densidade d = new Densidade();

        // Atributos
        string msg_de, msg_en;
        int qnt_digitos_cm;

        public Densidade_Mensagens(string msg_de, string msg_en, int qnt_digitos_chave_mista)
        {
            InitializeComponent();

            /* Atribuições */
            this.msg_de = msg_de;
            this.msg_en = msg_en;
            qnt_digitos_cm = qnt_digitos_chave_mista;

            /* Sets na variável "Retornos" */
            var retornos = d.Retorno(this.msg_de, this.msg_en, qnt_digitos_cm);
            /*
             * Item 1 → Mensagem Decriptada;
             * Item 2 → Bytes da Mensagem Decriptada (tamanho);
             * Item 3 → Mensagem Encriptada;
             * Item 4 → Bytes da Mensagem Encriptada (tamanho);
             * Item 5 → Densidade;
             * Item 6 → Porcentagem da Densidade;
             * Item 7 → Porcentagem do Aumento do Tamanho das Mensagens (sentido decriptada → encriptada).
             */

            /* Sets de Informações nas Labels */
            msg_decriptada.Text = retornos.Item1;
            msg_decriptada_bytes.Text = retornos.Item2 + " bytes (" + retornos.Item2 * 8 + " bits)";
            msg_encriptada.Text = retornos.Item3;
            msg_encriptada_bytes.Text = retornos.Item4 + " bytes (" + retornos.Item4 * 8 + " bits)";
            densidade.Text = retornos.Item5 + " (" + Convert.ToString(qnt_digitos_cm) + " bytes cifrados para 1 byte decifrado)";
            porcentagem_densidade.Text = retornos.Item6 + "% de bytes decifrados para cada elemento cifrado";
            desvio_comprimento.Text = retornos.Item7 + "% de aumento no comprimento da mensagem decriptada para a encriptada";
        }       
    }
}
