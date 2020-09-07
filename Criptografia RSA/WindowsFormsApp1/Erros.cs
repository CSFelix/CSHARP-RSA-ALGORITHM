using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erros
{
    class Conteudo_Erros
    {
        // Atributo
        private string retorno_msg = "", retorno_titulo = "";

        // Listas
        List<string> Erro_Login = new List<string>();
        List<string> Titulo_Erro_Login = new List<string>();
        List<string> Erro_Processo = new List<string>();
        List<string> Titulo_Erro_Processo = new List<string>();

        // Métodos Set de valores nas listas
        private void Set_Erro_Login()
        {
            Erro_Login.Add("Os campos estão vazios, por favor, preencha-os antes de entrar. \n\n The fields are empty, please fill them out before entering."); // 0
            Erro_Login.Add("Algum(ns) dos campos está(ão) vazio(s), por favor, preencha-o(s) antes de entrar. \n\n Some of the fields are empty, please, fill in the blank before entering."); // 1
            Erro_Login.Add("Login inválido. \n\n Invalid login"); // 2
            Erro_Login.Add("Senha inválida \n\n Invalid password"); // 3
            Erro_Login.Add("O status da CUMI não foi informado corretamente. Verifique se você enviou \"ON - EN ou PT\" ou \"OFF - EN ou PT\", ou se está com o capslock desativado. \n\n The CUMI status was not entered correctly. Make sure you sent \" ON - EN or PT \" or \" OFF - EN or PT \", or if you have caps lock turned off."); // 4
        }

        private void Set_Titulo_Erro_Login()
        {
            Titulo_Erro_Login.Add("Preenchimento Inválido \\ Invalid Fill");
        }

        private void Set_Erro_Processo(bool idioma_internacional)
        {
            // Inglês
            if (idioma_internacional == true)
            {
                Erro_Processo.Add("No Commands Sent"); // 0
                Erro_Processo.Add("Unknown command, sorry."); // 1
                Erro_Processo.Add("You do not have permission to view the images"); // 2
                Erro_Processo.Add("Message, mixed and public key not informed"); // 3
                Erro_Processo.Add("Message, mixed and private key not informed"); // 4
                Erro_Processo.Add("Message and mixed key not informed"); // 5
                Erro_Processo.Add("Message and public key not informed"); // 6
                Erro_Processo.Add("Message and private key not informed"); // 7
                Erro_Processo.Add("Mixed and public key not informed"); // 8
                Erro_Processo.Add("Mixed and private key not informed"); // 9
                Erro_Processo.Add("Mixed key not informed."); // 10
                Erro_Processo.Add("Public key not informed"); // 11 
                Erro_Processo.Add("Private key not informed"); // 12
                Erro_Processo.Add("Uninformed Hex Values"); // 13
                Erro_Processo.Add("Out-standard hexadecimal values"); // 14
                Erro_Processo.Add("Image not selected"); // 15
                Erro_Processo.Add("A serious error has been encountered.\nPlease tell the programmer"); // 16
                Erro_Processo.Add("Message not informed"); // 17
                Erro_Processo.Add("Make sure the messages in the Description field and the Mixed Key have been entered."); // 18
                Erro_Processo.Add("Make sure the value of the Mixed Key is even a number. If it is letters, symbols or a very large number, it will not be possible to show the density"); // 19           
                Erro_Processo.Add("Field(s) of unfilled prime number(s)."); // 20
                Erro_Processo.Add("Primary data impossible to convert to number(s)."); // 21
            }
            // Português
            else
            {
                Erro_Processo.Add("Nenhum comando enviado"); // 0
                Erro_Processo.Add("Comando desconhecido"); // 1
                Erro_Processo.Add("Você não tem permissão para visualizar as imagens"); // 2
                Erro_Processo.Add("Mensagem, chave-mista e pública não informadas"); // 3
                Erro_Processo.Add("Mensagem, chave-mista e privada não informadas"); // 4
                Erro_Processo.Add("Mensagem e chave-mista não informadas"); // 5
                Erro_Processo.Add("Mensagem e chave-pública não informadas"); // 6
                Erro_Processo.Add("Mensagem e chave-privada não informadas"); // 7
                Erro_Processo.Add("Chave-mista e pública não informadas"); // 8
                Erro_Processo.Add("Chave-mista e privada não informadas"); // 9
                Erro_Processo.Add("Chave-mista não informada"); // 10
                Erro_Processo.Add("Chave-pública não informada"); // 11 
                Erro_Processo.Add("Chave-privada não informada"); // 12
                Erro_Processo.Add("Valores hexadecimais não informados"); // 13
                Erro_Processo.Add("Valores hexadecimais fora dos padrões"); // 14
                Erro_Processo.Add("Nenhuma imagem não selecionada"); // 15
                Erro_Processo.Add("Um sério erro ocorreu \n Por favor, avise ao programador"); // 16
                Erro_Processo.Add("Mensagem não informada"); // 17
                Erro_Processo.Add("Certifique se as mensagens do campo de Descriptação e a Chave-Mista foram informadas."); // 18
                Erro_Processo.Add("Verifique se o valor da Chave-Mista informado é mesmo um número. Caso seja letras, símbolos ou um número muito grande, não será possível mostrar a densidade"); // 19
                Erro_Processo.Add("Campo(s) de número(s) primo(s) não preenchido(s)."); // 20
                Erro_Processo.Add("Dado(s) de primo(s) impossível(is) de ser(em) convertido(s) para número(s)."); // 21
            }
        }

        private void Set_Titulo_Erro_Processo(bool idioma_internacional)
        {
            // Inglês
            if (idioma_internacional == true)
            {
                Titulo_Erro_Processo.Add("Wrong Command"); // 0
                Titulo_Erro_Processo.Add("Forgotten Input"); // 1
                Titulo_Erro_Processo.Add("Wrong Proccess Image"); // 2
                Titulo_Erro_Processo.Add("Serious Error"); // 3
                Titulo_Erro_Processo.Add("Wrong mixed key"); // 4
                Titulo_Erro_Processo.Add("Invalid input"); // 5
            }

            // Português
            else
            {
                Titulo_Erro_Processo.Add("Comando Equivocado"); // 0
                Titulo_Erro_Processo.Add("Input Esquecido"); // 1
                Titulo_Erro_Processo.Add("Erro no Processamento de Imagem"); // 2
                Titulo_Erro_Processo.Add("Erro Sério"); // 3
                Titulo_Erro_Processo.Add("Erro de Chave-Mista"); // 4
                Titulo_Erro_Processo.Add("Input inválido"); // 5
            }
        }

        // Métodos de Retorno
        public Tuple<string, string> Retorno_Erro_Login(int posicao_msg, int posicao_titulo)
        {
            /* Memória */
            Set_Erro_Login();
            Set_Titulo_Erro_Login();

            /* Sets */
            retorno_msg = Erro_Login[posicao_msg];
            retorno_titulo = Titulo_Erro_Login[posicao_titulo];

            /* Retorno */
            return Tuple.Create(retorno_msg, retorno_titulo);
        }

        public Tuple<string, string> Retorno_Erro_Processo(bool idioma_internacional, int posicao_msg, int posicao_titulo)
        {
            /* Memória */
            Set_Erro_Processo(idioma_internacional);
            Set_Titulo_Erro_Processo(idioma_internacional);

            /* Sets */
            retorno_msg = Erro_Processo[posicao_msg];
            retorno_titulo = Titulo_Erro_Processo[posicao_titulo];

            /* Retorno */
            return Tuple.Create(retorno_msg, retorno_titulo);
        }

        // Construtor
        public Conteudo_Erros() { }

        // Destruidor
        ~Conteudo_Erros() { }
    }
}
