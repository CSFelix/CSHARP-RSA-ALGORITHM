using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace CUMI
{

    class VoiceBot
    {
        // Atributos
        SpeechSynthesizer cumi = new SpeechSynthesizer();
    

        // Métodos
        public void Saudacao()
        {
            cumi.Speak("Liku Startu");
            cumi.Speak("Seja bem-vindo ao Safety at Sea Crypto");
            cumi.Speak("Eu sou CUMI, sua assistiente virtual");
        }

        public void Descricao(int numero)
        {
           switch (numero)
           {

                case 0:
                    cumi.Speak("Acesso à descrição e imagens do acidente ambiental");
                    break;

                case 1:
                    cumi.Speak("Acesso à área de encriptação e descriptação de dados e imagens");
                    break;

                case 2:
                    cumi.Speak("Acesso à uma experiência comunicativa comigo");
                    cumi.Speak("É necessário possuir permissão par aacessar essa janela");
                    break;
            }
        }

        public void Erros(int numero)
        {
            switch (numero)
            {
                case 0:
                    cumi.Speak("Informe a chave privada antes de descriptar");
                    break;

                case 1:
                    cumi.Speak("Você não tem permissão para visualizar as imagens");
                    break;

                case 2:
                    cumi.Speak("Chave pública e campo de mensagem não informados.\nPor favor, informe-os antes de encriptar");
                    break;

                case 3:
                    cumi.Speak("Chave públcia não informada");
                    break;

                case 4:
                    cumi.Speak("Mensagem a encriptar não informada");
                    break;

                case 5:
                    cumi.Speak("Chave privada e campo de mensagem não informados.\nPor favor, informe-os antes de encriptar");
                    break;

                case 6:
                    cumi.Speak("Mensagem a descriptar não informada");
                    break;
            }
        }


        // Construtor
        public VoiceBot()
        { }

        // Destruidor
        ~VoiceBot()
        { }

    }
}
