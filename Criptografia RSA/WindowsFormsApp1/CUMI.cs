using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis; // permite à máquina usar comandos de voz
using System.Speech.Recognition; // permite à máquina capturar a voz do usuário e transformá-la em string (não estou usando por enquanto)
using System.Diagnostics; // permite à máquina acessar softwares alternativos presentes nela

namespace AssistenteVirtual
{
    class CUMI
    {
        // Objeto
        SpeechSynthesizer cumi = new SpeechSynthesizer();

        // Atributos
        bool status, som;
        readonly bool idioma_internacional;
        string query; // armazena o que o usuário deseja pesquisar na web

        // Propriedades
        private string[] comandos = new string[21];

        /// <summary>
        /// Envia uma string ao array de comandos
        /// </summary>
        /// <param name="index">Posição aonde o comando será enviado (int)</param>
        /// <param name="comando">Comando a ser enviado (string)</param>
        private void SetComandos(int index, string comando)
        {
            comandos[index] = comando;
        }

        /// <summary>
        /// Retorna o comando armazenado na posição solicitada no array comandos
        /// </summary>
        /// <param name="index">Posição do valor a ser retornado (int)</param>
        /// <returns>String: comando selecionado</returns>
        private string GetComandos(int index)
        {
            return comandos[index];
        }

        /*
         * 0 -> pesquisa no google
         * 1 -> pesquisa no google imagens
         * 2 -> pesquisa no yahoo
         * 3 -> pesquisa no youtube
         * 4 -> tradução google tradutor (pt - en)
         * 5 -> tradução google tradutor (en - pt)
        */
        readonly private bool[] pesquisa = new bool[] { false, false, false, false, false, false };

        /// <summary>
        /// Envio de valor booleano no array pesquisa
        /// </summary>
        /// <param name="index">Posição aonde o valor será enviado (int)</param>
        /// <param name="valor">Valor booleano (bool)</param>
        private void SetPesquisa(int index, bool valor)
        {
            pesquisa[index] = valor;
        }

        /// <summary>
        /// Retorno do valor de alguma função a fim de saber se ela está ativada ou não 
        /// </summary>
        /// <param name="index">Posição do valor a ser retornado (int)</param>
        /// <returns>Bool: pesquisa ativada (true) ou não (false)</returns>
        private bool GetPesquisa(int index)
        {
            return pesquisa[index];
        }

        /*
         * Todas as condições são correspondentes à janela de início.
         * Quando o valor for false, significa que o comando de voz ainda não foi processado.
         * Quando o valor for true, significa que o comando já foi prcessado e, assim, não será repetido.
         * 
         * 0 -> descrição da janela de relatório
         * 1 -> descrição da janela de cifração
         * 2 -> descrição da própria CUMI
        */
        readonly private bool[] descricao = new bool[] { false, false, false };

        /// <summary>
        /// Envio de valor booleano no array descricao
        /// </summary>
        /// <param name="index">Posição do valor a ser enviado (int)</param>
        /// <param name="valor">Valor a ser enviado: não dito (false), já dito (true)</param>
        private void SetDescricao(int index, bool valor)
        {
            descricao[index] = valor;
        }

        /// <summary>
        /// Retorna um valor do array descricao a fim de saber se alguma descrição já foi dita ou não
        /// </summary>
        /// <param name="index">Posição do valor a ser retornado (int)</param>
        /// <returns>Bool: descrição já foi dita (true), descrição não foi dita (false)</returns>
        private bool GetDescricao(int index)
        {
            return descricao[index];
        }

        // Listas
        private List<string> Respostas = new List<string>(); // respostas padrões da CUMI
        private List<string> Descricoes = new List<string>(); // descrições das janelas
        private List<string> Erros = new List<string>(); // avisos de erros
        private List<string> Links = new List<string>(); // diretórios de links web
        private List<string> Aplicacoes = new List<string>(); // diretórios de softwares instalados na máquina

        /// <summary>
        /// Set de conteúdos em Portugês e Inglês nas listas "Respostas", "Descricoes" e "Erros" 
        /// </summary>
        private void Memoria_Falas()
        {
            // Inglês
            if (this.idioma_internacional == true)
            {
                // Respostas -- (0)
                Respostas.Add("Linku Startu"); // 0
                Respostas.Add("Hello, I am CUMI, your virtual assistant.\nWelcome at Safety At Sea Crypto"); // 1
                Respostas.Add("Ok"); // 2
                Respostas.Add("What?"); // 3

                // Descrições -- (1)
                Descricoes.Add("Report area"); // 0
                Descricoes.Add("Messages encryption area and images storage"); // 1
                Descricoes.Add("Commands area.\nType in the space below and click the button for processing."); // 2

                // Erros -- (2)
                Erros.Add("No Commands Sent"); // 0
                Erros.Add("Unknown command, sorry."); // 1
                Erros.Add("You do not have permission to view the images"); // 2
                Erros.Add("Message, mixed and public key not informed"); // 3
                Erros.Add("Message, mixed and private key not informed"); // 4
                Erros.Add("Message and mixed key not informed"); // 5
                Erros.Add("Message and public key not informed"); // 6
                Erros.Add("Message and private key not informed"); // 7
                Erros.Add("Mixed and public key not informed"); // 8
                Erros.Add("Mixed and private key not informed"); // 9
                Erros.Add("Mixed key not informed"); // 10
                Erros.Add("Public key not informed"); // 11 
                Erros.Add("Private key not informed"); // 12
                Erros.Add("Uninformed Hex Values"); // 13
                Erros.Add("Out-standard hexadecimal values"); // 14
                Erros.Add("Image not selected"); // 15
                Erros.Add("A serious error has been encountered.\nPlease tell the programmer"); // 16
                Erros.Add("Message not informed"); // 17
                Erros.Add("Decryption field or Mixed Key field not fill"); // 18
                Erros.Add("Value mixed key very big or wrong"); // 19
            }

            // Português
            else
            {
                // Respostas -- (0)
                Respostas.Add("Início do link"); // 0
                Respostas.Add("Olá, eu sou CUMI, sua assistente virtual.\nSeja bem-vindo ao Safety At Sea Crypto"); // 1
                Respostas.Add("Ok"); // 2
                Respostas.Add("Diga?"); // 3

                // Descrições -- (1)
                Descricoes.Add("Área de relato do ocorrido."); // 0
                Descricoes.Add("Área de cifração de mensagens e armazenamento de imagens."); // 1
                Descricoes.Add("Área de comandos.\nDigite no espaço abaixo e clique no botão para o processamento"); // 2

                // Erros -- (2)
                Erros.Add("Nenhum comando enviado"); // 0
                Erros.Add("Comando desconhecido, desculpe"); // 1
                Erros.Add("Você não tem permissão para visualizar as imagens"); // 2
                Erros.Add("Chave mista, pública e mensagem não informadas"); // 3
                Erros.Add("Chave mista, privada e mensagem não informadas"); // 4
                Erros.Add("Chave mista e mensagem não informadas"); // 5
                Erros.Add("Chave pública e mensagem não informadas"); // 6
                Erros.Add("Chave privada e mensagem não informadas"); // 7
                Erros.Add("Chave mista e pública não informadas"); // 8
                Erros.Add("Chave mista e privada não informadas"); // 9
                Erros.Add("Chave mista não informada"); // 10
                Erros.Add("Chave pública não informada"); // 11 
                Erros.Add("Chave privada não informada"); // 12
                Erros.Add("Valores hexadecimais não informados"); // 13
                Erros.Add("Valores hexadecimais fora dos padrões"); // 14
                Erros.Add("Imagem não selecionada"); // 15
                Erros.Add("Um erro grave foi encontrado.\nPor favor, avise ao programador"); // 16
                Erros.Add("Mensagem não informada"); // 17
                Erros.Add("Campos de Decriptação ou Chave-Mista não preenchidos"); // 18
                Erros.Add("Valor da Chave-Mista muito grande ou equivocado."); // 19
            }
        }

        /// <summary>
        /// Set de conteúdos nas listas "Links" e "Diretórios"
        /// </summary>
        private void Memoria_Diretorios()
        {
            // Links -- (3)
            // Gerais
            Links.Add("https://www.facebook.com"); // Facebook -- 0
            Links.Add("https://www.google.com"); // Google -- 1
            Links.Add("https://www.google.com.br/imghp?hl="); // Google Image -- 2
            Links.Add("https://www.linkedin.com"); // Linkedin -- 3
            Links.Add("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1537706246&rver=6.7.6640.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fRpsCsrfState%3dbd0a7397-27f9-3e0c-a5e8-015e1fd83774&id=292841&whr=outlook.com&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015"); // Outlook -- 4
            Links.Add("https://br.yahoo.com/?p=us"); // Yahoo -- 5
            Links.Add("https://www.youtube.com"); // Youtube -- 6
            Links.Add("https://translate.google.com.br/?hl=pt-BR#pt/en/"); // Google Tradutor: PT to EN -- 7
            Links.Add("https://translate.google.com.br/?hl=en-EN#en/pt/"); // Google Tradutor: EN to PT -- 8

            // Partes para as pesquisas
            // Google
            Links.Add("https://www.google.com.br/search?source=hp&ei=yo-vW4PQKIKuwATUxo2IAQ&q="); // 9
            Links.Add("&oq="); // 10
            Links.Add("&gs_l=psy-ab.3..0i131k1l4j0j0i131k1l2j0l3.2798.4644.0.4738.17.17.0.0.0.0.165.2013.3j13.16.0..2..0...1.1.64.psy-ab..1.16.2013....0.3lD8V8bErLQ"); // 11

            // Google Image
            Links.Add("https://www.google.com.br/search?hl=pt-PT&biw=1560&bih=759&tbm=isch&sa=1&ei=F4uvW7fDF4P8wQTd8oqwBw&q="); // 12
            Links.Add("&oq="); // 13
            Links.Add("&gs_l=img.3..0j0i67k1l2j0l7.636007.638482.0.639592.24.15.0.4.4.0.171.1420.7j6.13.0....0...1c.1.64.img..10.14.1102....0.CmGJ1SbHUmA"); // 14

            // Yahoo
            Links.Add("http://search.yahoo.com/search?p="); // 15
            Links.Add("&fr=yfp-t-501&toggle=1&cop=mss&ei=UTF-8&vc=&fp_ip=IN"); // 16

            // Youtube
            Links.Add("https://www.youtube.com/results?search_query="); // 17

            // Aplicações -- (4)
            Aplicacoes.Add("calc.exe"); // calculadora -- 0
            Aplicacoes.Add("excel"); // excel -- 1
            Aplicacoes.Add("winword"); // word -- 2		            
        }

        /// <summary>
        /// Set de conteúdos em Portugês e Inglês na lista "Conteúdos"
        /// </summary>
        private void Memoria_Comandos()
        {
            if (idioma_internacional == true)
            {
                SetComandos(0, "sleep"); // 0
                SetComandos(1, "wake"); // 1
                SetComandos(2, "mute"); // 2
                SetComandos(3, "sound"); // 3
                SetComandos(4, "cumi"); // 4
                SetComandos(5, "facebook"); // 5
                SetComandos(6, "google"); // 6
                SetComandos(7, "google image"); // 7
                SetComandos(8, "linkedin"); // 8
                SetComandos(9, "outlook"); // 9
                SetComandos(10, "yahoo"); // 10
                SetComandos(11, "youtube"); // 11
                SetComandos(12, "google search"); // 12
                SetComandos(13, "google image search"); // 13
                SetComandos(14, "yahoo search"); // 14
                SetComandos(15, "youtube search"); // 15
                SetComandos(16, "calculator"); // 16
                SetComandos(17, "excel"); // 17
                SetComandos(18, "word"); // 18
                SetComandos(19, "google traslate en - pt"); // 19
                SetComandos(20, "google translate pt - en"); // 20
            }
            else
            {
                // Comandos
                SetComandos(0, "durma"); // 0
                SetComandos(1, "acorde"); // 1
                SetComandos(2, "mudo"); // 2
                SetComandos(3, "som"); // 3
                SetComandos(4, "cumi"); // 4
                SetComandos(5, "facebook"); // 5
                SetComandos(6, "google"); // 6
                SetComandos(7, "google image"); // 7
                SetComandos(8, "linkedin"); // 8
                SetComandos(9, "outlook"); // 9
                SetComandos(10, "yahoo"); // 10
                SetComandos(11, "youtube"); // 11
                SetComandos(12, "google pesquisa"); // 12
                SetComandos(13, "google image pesquisa"); // 13
                SetComandos(14, "yahoo pesquisa"); // 14
                SetComandos(15, "youtube pesquisa"); // 15
                SetComandos(16, "calculadora"); // 16
                SetComandos(17, "excel"); // 17
                SetComandos(18, "word"); // 18
                SetComandos(19, "google tradutor en - pt"); // 19
                SetComandos(20, "google tradutor pt - en"); // 20              
            }
        }

        // Métodos Secundários
        
        /// <summary>
        /// Desativa a CUMI (false) caso ela esteja ativada (true)
        /// </summary>
        private void Dormir()
        {
            status = (status == true) ? false : status;
        }

        /// <summary>
        /// Ativa a CUMI (true) caso ela esteja desativada (false)
        /// </summary>
        private void Acordar()
        {
            status = (status == false) ? true : status;
        }

        /// <summary>
        /// Retorna a condição da CUMI
        /// </summary>
        /// <returns>Bool: ativada (true), desativada (false)</returns>
        public bool Check_Status()
        {
            return status;
        }

        /// <summary>
        /// Desativa os comandos de voz da CUMI caso tanto a CUMI quanto os comandos estejam ativados
        /// </summary>
        private void Desativar_Som()
        {
            if (status == true)
            {
                som = (som == true) ? false : som;
            }
        }

        /// <summary>
        /// Ativa os comandos de voz da CUMI caso a CUMI esteja ativada, e os comandos de voz, desativados
        /// </summary>
        private void Ativar_Som()
        {
            if (status == true)
            {
                som = (som == false) ? true : som;
            }
        }

        /// <summary>
        /// Retorna a condição dos comandos de voz
        /// </summary>
        /// <returns>Bool: ativados (true), desativados (false)</returns>
        public bool Check_Som()
        {
            return som;
        }

        /// <summary>
        /// Retorna a condição do idioma escolhido
        /// </summary>
        /// <returns>Bool: Inglês (true), Português (false)</returns>
        public bool Check_Idioma_Internacional()
        {
            return idioma_internacional;
        }

        /// <summary>
        /// Retorno de string por meio de voz pela CUMI
        /// </summary>
        /// <param name="fala">Aquilo que será dito pela CUMI</param>
        private void Falar(string fala)
        {
            cumi.Speak(fala);
        }

        /// <summary>
        /// Processamento de algum endereço web ou diretório de softwares instalados na máquina
        /// </summary>
        /// <param name="diretorio">Endereço tanto do web site quanto do software a ser inicializado</param>
        private void Processar(string diretorio)
        {
            Process.Start(diretorio);
        }


        // Métodos Principais

        /// <summary>
        /// Escolha sobre o que será dito pela CUMI
        /// </summary>
        /// <param name="selecao_lista">Selecionamento de alguma lista de falas:</param>
        /// <remarks>
        /// 0 -> Respostas
        /// 1 -> Descricoes
        /// 2 -> Erros
        /// </remarks>
        /// <param name="selecao_item">Selecionamento de algum item da lista escolhida (int)</param>
        public void Pensar_Fala(int selecao_lista, int selecao_item)
        {
            /* Memória */
            Memoria_Falas();

            /* Processamento */
            string escolha = ""; // decisão final sobre o que fazer

            // CUMI ativada
            if (status == true && som == true)
            {
                // Seleção da lista
                switch (selecao_lista)
                {
                    // Respostas
                    case 0:
                        escolha = Respostas[selecao_item];
                        break;

                    // Descrições
                    case 1:
                        if (descricao[selecao_item] == false)
                        {
                            escolha = Descricoes[selecao_item];
                            SetDescricao(selecao_item, true);
                        }
                        else
                        {
                            escolha = "";
                        }
                        break;

                    // Erros
                    case 2:
                        escolha = Erros[selecao_item];
                        break;
                }

                /* Retorno */
                Falar(escolha);
            }
        }

        /// <summary>
        /// Escolha sobre o que será processado pela CUMI
        /// </summary>
        /// <param name="comando">String enviada pela usuário na janela inicial</param>
        public void Pensar_Diretorio(string comando)
        {
            /* Processamento */
     
            // Função de pesquisa desativada
            if (GetPesquisa(0) == false && GetPesquisa(1) == false && GetPesquisa(2) == false && GetPesquisa(3) == false && GetPesquisa(4) == false && GetPesquisa(5) == false)
            {
                /* Memória */
                Memoria_Diretorios();
                Memoria_Comandos();

                /* Variáveis */
                int qnt_comandos = comandos.Length;
                int posicao = 0;

                // CUMI ativada
                if (status == true)
                {
                    foreach (string verificar_comando in comandos)
                    {
                        qnt_comandos--;

                        // Comando reconhecido pela CUMI -> CUMI verificará qual será sua função
                        if (comando.Equals(verificar_comando))
                        {
                            Comando_Reconhecido(posicao);
                            break;
                        }
                        // Comando não reconhecido -> uma mensagem de erro é exibida
                        else if (qnt_comandos == 0)
                        {
                            Comando_Nao_Reconhecido();
                        }

                        posicao++;
                    }
                }

                // CUMI desativada -- o único comando que será verificado é o de acordar
                else
                {
                    // Verificação em Inglês
                    if (idioma_internacional == true)
                    {
                        if (comando.Equals("wake"))
                        {
                            Acordar();
                        }
                    }

                    // Verificação em Português
                    else
                    {
                        if (comando.Equals("acorde"))
                        {
                            Acordar();
                        }
                    }
                }

            }

            // Função de pesquisa ativada
            else
            {
                Pesquisar(comando);
            }
        }

        /// <summary>
        /// Quando o comando é reconhecido, a CUMI checará qual deles foi
        /// </summary>
        /// <param name="comando">String enviada pelo usuário na janela inicial</param>
        private void Comando_Reconhecido(int posicao)
        {
            string escolha = ""; // decisão final sobre o que fazer

            // Verifica em qual posição está, no array de comandos, o comando reconhecido
            switch (posicao)
            {
                // Ações comuns sem a necessidade de processamento ou ativação das funções de pesquisa
                case int numero when (numero <= 4):
                    switch (numero)
                    {
                        // "Sleep" ou "Durma"
                        case 0:
                            Dormir();
                            break;

                        // "Wake" ou "Acorde"
                        case 1:
                            Acordar();
                            break;

                        // "Mute" ou "Mudo"
                        case 2:
                            Desativar_Som();
                            break;

                        // "Sound" ou "Som"
                        case 3:
                            Ativar_Som();
                            break;

                        // "Cumi"
                        case 4:
                            Pensar_Fala(0, 3);
                            break;
                    }

                    break;

                // Ações de processamento de links na web
                case int numero when (numero >= 5 && numero <= 11):
                    switch (numero)
                    {
                        // "Facebook"
                        case 5:
                            escolha = Links[0];
                            break;

                        // "Google"
                        case 6:
                            escolha = Links[1];
                            break;

                        // "Google Image"
                        case 7:
                            escolha = Links[2];
                            break;

                        // "Linkedin"
                        case 8:
                            escolha = Links[3];
                            break;

                        // "Outlook"
                        case 9:
                            escolha = Links[4];
                            break;

                        // "Yahoo"
                        case 10:
                            escolha = Links[5];
                            break;

                        // "Youtube"
                        case 11:
                            escolha = Links[6];
                            break;
                    }

                    Processar(escolha);
                    break;

                // Ações de ativação das funções de pesquisa e tradução
                case int numero when ((numero >= 12 && numero <= 15) || (numero == 19 || numero == 20)):

                    int numero2 = 0; // posição da função a ser ativada

                    switch (numero)
                    {
                        // "Google Search" ou "Google Pesquisa"
                        case 12:
                            numero2 = 0;
                            break;

                        // "Google Image Search" ou "Google Imagem Pesquisa"
                        case 13:
                            numero2 = 1;
                            break;

                        // "Yahoo Search" ou "Yahoo Pesquisa"
                        case 14:
                            numero2 = 2;
                            break;

                        // "Youtube Search" ou "Youtube Pesquisa"
                        case 15:
                            numero2 = 3;
                            break;

                        // "Google Translate PT - EN" ou "Google Tradutor PT - EN"
                        case 19:
                            numero2 = 4;
                            break;

                        // "Google Translate EN - PT" ou "Google Tradutor EN - PT"
                        case 20:
                            numero2 = 5;
                            break;
                    }

                    SetPesquisa(numero2, true);
                    break;

                // Ações de processamento dos softwares já instalados na máquina
                case int numero when (numero >= 16 && numero <= 18):
                    switch (numero)
                    {
                        // "Calculator" ou "Calculadora"
                        case 16:
                            escolha = Aplicacoes[0];
                            break;

                        // "Word"
                        case 17:
                            escolha = Aplicacoes[1];
                            break;

                        // "Excel"
                        case 18:
                            escolha = Aplicacoes[2];
                            break;
                    }

                    Processar(escolha);
                    break;                          
            }          
        }

        /// <summary>
        /// Caso o comando não for reconhecido, a CUMI dirá que não reconheceu o mesmo
        /// </summary>
        private void Comando_Nao_Reconhecido()
        {
            Pensar_Fala(2, 1);
        }

        /// <summary>
        /// Pesquisa do comando em algum site web disponível na memória (Goolge, Google Image, Yahoo e Youtube)
        /// </summary>
        /// <param name="comando">String enviada pelo usuário na janela inicial quando a função de pesquisa em algum web site está ativada</param>
        private void Pesquisar(string comando)
        {
            /* Memória */
            Memoria_Diretorios();

            /* Processamento */

            // Pesquisa no Google
            if (GetPesquisa(0) == true)
            {
                query = Links[9] + comando.Replace(" ", "+") + Links[10] + comando.Replace(" ", "+") + Links[11];
                SetPesquisa(0, false);
            }

            // Pesquisa no Google Image
            else if (GetPesquisa(1) == true)
            {
                query = Links[12] + comando.Replace(" ", "+") + Links[13] + comando.Replace(" ", "+") + Links[14];
                SetPesquisa(1, false);
            }

            // Pesqusia no Yahoo
            else if (GetPesquisa(2) == true)
            {
                query = Links[15] + comando.Replace(" ", "+") + Links[16];
                SetPesquisa(2, false);
            }

            // Pesquisa no Youtube
            else if (GetPesquisa(3) == true)
            {
                query = Links[17] + comando.Replace(" ", "+");
                SetPesquisa(3, false);
            }

            // Tradução PT - EN
            else if (GetPesquisa(4) == true)
            {
                query = Links[8] + comando.Replace(" ", "%20");
                SetPesquisa(4, false);
            }

            // Tradução EN - PT
            else
            {
                query = Links[7] + comando.Replace(" ", "%20");
                SetPesquisa(5, false);
            }

            /* Retorno */
            Processar(query);
        }


        // Construtor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status">CUMI ativada (true), e desativada (false)</param>
        /// <param name="idioma_internacional">Inglês ativado (true), Português ativado (false)</param>
        /// <param name="som">Comandos de voz ativados (true), desativados (false)</param>
        public CUMI(bool status, bool idioma_internacional, bool som)
        {
            // true -> funcionando, false -> "descansando"
            this.status = status;

            // true -> inglês, false -> português
            this.idioma_internacional = idioma_internacional;

            // true -> som ativado, false -> som desativado
            this.som = som;
        }

        // Destruidor
        ~CUMI() { }
    }

}