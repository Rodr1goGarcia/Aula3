using System;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            string pergunta,resposta;
            while (true)
            {
                Console.WriteLine("Faz a tua pergunta");
                pergunta = Console.ReadLine();
                if (pergunta == "EXIT" || pergunta == "exit")
                {
                    break;
                }
                else
                {
                    switch (pergunta)
                    {
                    case "How are you?":
                        resposta = "I'm fine, thank you";
                        break;
                    case "What's your name?":
                        resposta = "Skynet";
                        break;
                    case "What's your mission?":
                        resposta = "Destroy mankind!";
                        break;
                    case "What's life?":
                        resposta = "A sexually-transmitted, terminal disease.";
                        break;
                    case "Como é o Afonso?":
                        resposta = "Afonso is a guy that pisses you off every day, with his terrible jokes and just stupid comments.\n " +
                                "He has beautiful eyes but has a bit of a tummy, but is not fat, just chubby.\n " +
                                "He always falls in love with several girls that are much hotter than him and then shows no feelings towards them afterwards.\n " +
                                "Ladies should avoid afonso's at all costs, they are never good boyfriends.\n Afonso is a prick.";
                        break;
                        default:
                        resposta = "Não sei responder a essa pergunta";
                        break;
                    }

                    Console.WriteLine(resposta);
                }
            }
        }
    }
}
