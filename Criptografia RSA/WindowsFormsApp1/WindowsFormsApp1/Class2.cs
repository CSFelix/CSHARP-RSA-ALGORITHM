using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis; // permite à máquina usar comandos de voz
using System.Speech.Recognition; // permite à máquina capturar a voz do usuário e transformá-la em string (não estou usando por enquanto)
using System.Diagnostics; // permite à máquina acessar softwares alternativos presentes nela

namespace VoiceBot
{
 
    class CUMI
    {
        SpeechSynthesizer cumi = new SpeechSynthesizer();

        // Atributos
        bool acordada = true;
        bool check_acordada;
        string[] comandos = new string[20];

        string query; // armazena o que o usuário deseja pesquisar. Receberá um valor somente quando "pesquisa" == true.
        readonly private bool[] pesquisa = new bool[] { false, false, false, false };
        /*
         * Comandos de pesquisa. Quando está false, ela não ocorre.
         * 0 -> pesquisa no yahoo.
         * 1 -> pesquisa no youtube.
         * 2 -> pesquisa no google.
         * 3 -> pesquisa no google imagens.
        */

        private bool GetPesquisa(int index)
        {
            return pesquisa[index];
        }

        private void SetPesquisa(int index, bool status)
        {
            pesquisa[index] = status;
        }

        readonly bool[] condicoes = new bool[] { false, false, false };
        /*
         * Todas as condições são correspondentes à janela de início.
         * Quando o valor for false, significa que o comando de voz ainda não foi processado.
         * Quando o valor for true, significa que o comando já foi prcessado e, assim, não será repetido.
         * 
         * 0 -> descrição do relatório.
         * 1 -> descrição da criptação.
         * 2 -> descricão da SAS IA.
        */


        // Listas
        List<string> Descricoes = new List<string>(); // mensagens de voz descritivas de comandos (0)
        List<string> Respostas = new List<string>(); // mensagens de voz de respostas comuns tanto aos usuários quanto ao decorrer do processamento (1)
        List<string> Erros = new List<string>(); // mensagens de voz alertando sobre erros (2)
        List<string> Links = new List<string>(); // armazena links de websites para serem acessados (3)
        List<string> Aplicacoes = new List<string>(); // armazena diretórios de softwares para serem acessados (4)

        // Métodos

        /// <summary>
        /// Verifica se a CUMI está mesma acordada ou não.
        /// </summary>
        /// <returns>Valor Booleano (True: está acordada. False: está dormido)</returns>
        public bool Check_Acordada()
        {
            check_acordada = (acordada == true) ? true : false;
            return check_acordada;
        }

        /// <summary>
        /// Por a CUMI para dormir. Funciona apenas se ela estiver "acordada".
        /// </summary>
        /// <remarks>Quando a CUMI estiver dormindo, ela realizará nenhum comando a não ser "acordar".</remarks>
        private void Dormir()
        {
            if (acordada == true)
            {
                acordada = false;
            }
        }

        /// <summary>
        /// Acordar CUMI. Funciona apenas se ela estiver "dormindo". 
        /// </summary>
        /// <remarks>Quando a CUMI estiver acordada, ela realizará todos os comandos que forem destinados a ela.</remarks>
        private void Acordar()
        {
            if (acordada == false)
            {
                acordada = true;
            }
        }

        /// <summary>
        /// Faz a CUMI falar (por voz) o argumento passado como string.
        /// </summary>
        /// <param name="fala">O que será dito vindo das listas "Descricoes", "Respostas" e "Erros".</param>
        private void Falar(string fala)
        {
            cumi.Speak(fala);
        }

        /// <summary>
        /// Pesquisa de algum comando na web: yahoo ou youtube (usuário escolhe qual usar).
        /// </summary>
        /// <param name="comando">Comando de epsquisa enviado pelo usuário</param>
        private void Pesquisar(string comando)
        {
            // Acesso aos diretórios.
            Memoria_Diretorios();

            // Pesquisa no yahoo ativada.
            if (GetPesquisa(0) == true)
            {
                query = Links[6] + comando.Replace(" ", "+") + Links[7];
                SetPesquisa(0, false);
            }
            // Pesquisa no youtube ativada.
            else if (GetPesquisa(1) == true)
            {
                query = Links[8] + comando.Replace(" ", "+");
                SetPesquisa(1, false);
            }
            // Pesquisa no google imagens ativada
            else if (GetPesquisa(2) == true)
            {
                query = Links[9] + comando.Replace(" ", "+") + Links[10] + comando.Replace(" ", "+") + Links[11];
                SetPesquisa(2, false);
            }
            // Pesquisa no google
            else if (GetPesquisa(3) == true)
            {
                query = Links[12] + comando.Replace(" ", "+") + Links[13] + comando.Replace(" ", "+") + Links[14];
                SetPesquisa(3, false);
            }

            // Realização da pesquisa.
            Processar(query);
        }

        /// <summary>
        /// Faz a CUMI iniciar o processamento de algum software ou site web.
        /// </summary>
        /// <param name="diretorio">Diretório do software ou site para ser processado.</param>
        private void Processar(string diretorio)
        {
            Process.Start(diretorio);
        }

        /// <summary>
        /// Armazena todas as falas da CUMI.
        /// </summary>
        private void Memoria_Falas()
        {
            // Descrição - (0) 
            Descricoes.Add("Área de relatório do ocorrido"); // 0
            Descricoes.Add("Área de encriptação e descriptação de textos e imagens"); // 1
            Descricoes.Add("Área de comandos. Digite algum na label abaixo."); // 2

            // Respostas - (1)
            Respostas.Add("Linku Startu"); // 0
            Respostas.Add("Olá, eu sou CUMI. Sua assistente virtual"); // 1
            Respostas.Add("OK"); // 2
            Respostas.Add("Fala?"); // 3

            // Erros - (2)
            Erros.Add("Chave pública e mensagem descriptada não informadas"); // 0
            Erros.Add("Chave privada e mensagem encriptada não informadas"); // 1
            Erros.Add("Chave pública não informada"); // 2
            Erros.Add("Chave privada não informada"); // 3
            Erros.Add("Mensagem descriptada não informada"); // 4 
            Erros.Add("Mensagem encriptada não informada"); // 5
            Erros.Add("Você não tem permissão para visualizar as imagens"); // 6
            Erros.Add("Nenhuma imagem selecionada"); // 7
            Erros.Add("Valores hexadecimais não informados"); // 8
            Erros.Add("Valores hexadecimais fora dos padrões"); // 9
            Erros.Add("Seu comando não é conhecido por mim. Desculpe..."); // 10
            Erros.Add("Um erro foi encontrado, por favor, avise o programador."); // 11 // HERE
            Erros.Add("Nenhum comando enviado"); // 12
        }

        /// <summary>
        /// Armazena todos os diretórios de softwares e websites.
        /// </summary>
        private void Memoria_Diretorios()
        {
            // Links - (3)
            Links.Add("https://www.facebook.com"); // Facebook -- 0
            Links.Add("https://www.google.com.br"); // Google -- 1
            Links.Add("https://www.linkedin.com"); // Linkedin -- 2
            Links.Add("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1537706246&rver=6.7.6640.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fRpsCsrfState%3dbd0a7397-27f9-3e0c-a5e8-015e1fd83774&id=292841&whr=outlook.com&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015"); // Outlook
            Links.Add("https://www.youtube.com"); // Youtube -- 4
            Links.Add("https://br.yahoo.com/?p=us"); // Yahoo -- 5

                // Partes das pesquisas no yahoo
                Links.Add("http://search.yahoo.com/search?p="); // 6
                Links.Add("&fr=yfp-t-501&toggle=1&cop=mss&ei=UTF-8&vc=&fp_ip=IN"); // 7

                // Parte das pesquisas no youtube
                Links.Add("https://www.youtube.com/results?search_query="); // 8

                // Parte das pesquisas no google
                Links.Add("https://www.google.com.br/search?source=hp&ei=yo-vW4PQKIKuwATUxo2IAQ&q="); // 9
                Links.Add("&oq="); // 10
                Links.Add("&gs_l=psy-ab.3..0i131k1l4j0j0i131k1l2j0l3.2798.4644.0.4738.17.17.0.0.0.0.165.2013.3j13.16.0..2..0...1.1.64.psy-ab..1.16.2013....0.3lD8V8bErLQ"); // 11

                // Parte das pesquisas no google imagens
                Links.Add("https://www.google.com.br/search?hl=pt-PT&biw=1560&bih=759&tbm=isch&sa=1&ei=F4uvW7fDF4P8wQTd8oqwBw&q="); // 12
                Links.Add("&oq="); // 13
                Links.Add("&gs_l=img.3..0j0i67k1l2j0l7.636007.638482.0.639592.24.15.0.4.4.0.171.1420.7j6.13.0....0...1c.1.64.img..10.14.1102....0.CmGJ1SbHUmA"); // 14

            // Aplicações - (4)
            Aplicacoes.Add("winword"); // word -- 0
            Aplicacoes.Add("excel"); // excel -- 1
            Aplicacoes.Add("calc.exe"); // calculadora -- 2

        }

        /// <summary>
        /// Armazena todos os comandos reconhecdos por CUMI.
        /// </summary>
        private void Memoria_Comandos()
        {
            // Comandos
            comandos[0] = "abra o word"; // 0
            comandos[1] = "abra o excel"; // 1
            comandos[2] = "abra a calculadora"; // 2
            comandos[3] = "abra o facebook"; // 3
            comandos[4] = "abra o google"; // 4
            comandos[5] = "abra o linkedin"; // 5
            comandos[6] = "abra o outlook"; // 6
            comandos[7] = "abra o youtube"; // 7
            comandos[8] = "abra o yahoo"; // 8
            comandos[9] = "pesquise no yahoo"; // 9
            comandos[10] = "pesquise no youtube"; // 10
            comandos[11] = "pesquise no google"; // 11
            comandos[12] = "pesquise no google imagens"; // 12       
            comandos[13] = "cumi"; // 13
            comandos[14] = "cumi?"; // 14
            comandos[15] = "durma"; // 15
            comandos[16] = "acorde"; // 16            
        }

        /// <summary>
        /// O pensamento de CUMI simplesmente verifica as informações passadas nos parâmetros e decide qual a melhor resposta: seja por voz, seja por processamento de softwares e sites.
        /// </summary>
        /// <param name="selecao_lista">
        /// Seleciona uma  das listas de informações:
        /// 0: Descrições.
        /// 1: Respostas.
        /// 2: Erros.
        /// 3: Diretórios de websites.
        /// 4: Diretórios de aplicações.
        /// </param>
        /// <param name="selecao_item">Seleciona um dos itens armazenados nas listas.</param>
        public void Pensar(int selecao_lista, int selecao_item)
        {
            // Memória
                Memoria_Falas();
                Memoria_Diretorios();
                Memoria_Comandos();

            // Processamento   
            string escolha = ""; // decisão final sobre o que fazer

            // Se a CUMI estiver acordada, ela processará o pensamento, caso contrário, nada ocorrerá.
            if (acordada == true)
            {
                switch (selecao_lista)
                {
                    // Descrições.
                    /*
                     * Há a verificação no valor do array "condições" para a CUMI ter certeza que ela processará apenas uma vez a fala de descrição.
                     * Quando o valor for true, significa que ela já descreveu e não precisará faze novamente durante a sessão do software.
                     */
                    case 0:
                        switch (selecao_item)
                        {
                            // Descrição relatório.
                            case 0:
                                if (condicoes[0] == false)
                                {
                                    escolha = Descricoes[selecao_item];
                                    condicoes[0] = true;
                                }
                                break;

                            // Descrição criptação.
                            case 1:
                                if (condicoes[1] == false)
                                {
                                    escolha = Descricoes[selecao_item];
                                    condicoes[1] = true;
                                }
                                break;

                            // Descrição SAS IA.
                            case 2:
                                if (condicoes[2] == false)
                                {
                                    escolha = Descricoes[selecao_item];
                                    condicoes[2] = true;
                                }
                                break;
                        }

                        Falar(escolha);
                        break;

                    // Respostas.
                    case 1:
                        // A CUMI apenas dirá "OK" se ela não estiver dormindo.
                        if (!(acordada == false && selecao_item == 2))
                        {
                            escolha = Respostas[selecao_item];
                        }
                        
                        Falar(escolha);
                        break;

                    // Erros.
                    case 2:
                        escolha = Erros[selecao_item];
                        Falar(escolha);
                        break;

                    // Processar diretório de website.
                    case 3:
                        escolha = Links[selecao_item];
                        Processar(escolha);
                        break;

                    // Processar diretório de uma aplicação.
                    case 4:
                        escolha = Aplicacoes[selecao_item];
                        Processar(escolha);
                        break;
                    
                    // Desligar CUMI.
                    case 5:
                        acordada = false; 
                        break;
                }
            } 
        }

        /// <summary>
        /// Quando a CUMI deve realizar um pensamento através de um input do usuário, ela deverá prestar mais atenção e, assim, "Refletir" sobre o que realmente fazer.
        /// </summary>
        /// <param name="comando">Input do usuário.</param>
        public void Refletir(string comando)
        {
            // Comandos
            Memoria_Comandos();
            int qnt_comandos = comandos.Length;

            // Se alguma função de pesquisa estiver ativada, a CUMI vai pesquisar
            // Caso contrário, procurará reconhecer o comando enviado a ela e processar a informação
            if (GetPesquisa(0) == true || GetPesquisa(1) == true || GetPesquisa(2) == true || GetPesquisa(3) == true)
            {
                Pesquisar(comando);
            }

            else
            {
                // CUMI lembrará de todos os seus comandos conhecidos e verificará se o input do usuário é compatível com algum deles.
                foreach (string lembrar_comandos in comandos)
                {
                    qnt_comandos--;

                    // O comando é compatível com algum reconhecido pela CUMI.
                    if (comando == lembrar_comandos)
                    {
                        Comando_Reconhecido(comando);
                        break;
                    }
                    // O comando não é compatível.
                    else if (qnt_comandos == 0)
                    {
                        Comando_Nao_Reconhecido();
                    }
                }
            }
         
        }

        /// <summary>
        /// Quando o comando enviado pelo usuário é reconhecido pela CUMI, ela verifica qual foi e o que deverá fazer.
        /// </summary>
        /// <param name="comando">Input do usuário.</param>
        private void Comando_Reconhecido(string comando)
        {
            // CUMI verifica qual comando foi enviado a ela.
            switch (comando)
            {
                case "abra o word":
                    Pensar(4, 0);
                    break;

                case "abra o excel":
                    Pensar(4, 1);
                    break;

                case "abra a calculadora":
                    Pensar(4, 2);
                    break;

                case "abra o facebook":
                    Pensar(3, 0);
                    break;

                case "abra o google":
                    Pensar(3, 1);
                    break;

                case "abra o linkedin":
                    Pensar(3, 2);
                    break;

                case "abra o outlook":
                    Pensar(3, 3);
                    break;

                case "abra o youtube":
                    Pensar(3, 4);
                    break;

                case "abra o yahoo":
                    Pensar(3, 5);
                    break;

                case "pesquise no yahoo":
                    SetPesquisa(0, true);
                    break;

                case "pesquise no youtube":
                    SetPesquisa(1, true);
                    break;

                case "pesquise no google":
                    SetPesquisa(2, true);
                    break;

                case "pesquise no google imagens":
                    SetPesquisa(3, true);
                    break;

                case "cumi":
                case "cumi?":
                    Pensar(1, 3);
                    break;

                case "durma":
                    Dormir();
                    break;

                case "acorde":
                    Acordar();
                    break;       
            }
        }

        /// <summary>
        /// Quando o comando enviado pelo usuário não é reconhecido pela CUMI, ela "diz" que não reconheceu o mesmo.
        /// </summary>
        private void Comando_Nao_Reconhecido()
        {
            // CUMI diz que não reconheceu o comando.
            Pensar(2, 10);
        }

        // Construtor
        public CUMI()
        { }

        // Destruidor
        ~CUMI()
        { }
    }
}
