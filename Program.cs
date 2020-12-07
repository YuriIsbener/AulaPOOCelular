using System;
using AulaPOOCelular.classe;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            Console.WriteLine("Gostaria de ligar o aparelho? s/n");
            string escolha = Console.ReadLine();
            if (escolha == "s")
            {
                celular1.Ligar();
                Console.WriteLine("O que mais gostaria de fazer?");
                Console.WriteLine("[0] - Fazer Ligação");
                Console.WriteLine("[1] - Enviar Mensagem");
                Console.WriteLine("[2] - Desligar");
                int escolha2 = int.Parse(Console.ReadLine());
                switch (escolha2)
                {
                    case 0:
                    Console.WriteLine("Digite o número que gostaria de ligar:");
                    celular1.FazerLigação();
                        break;

                    case 1:
                    Console.WriteLine("Para quem gostaria de enviar a mensagem?");
                    Console.ReadLine();
                    Console.WriteLine("O que gostaria de enviar? ");
                    Console.ReadLine();
                        break;

                    case 2:
                    Environment.Exit(1);
                        break;
                        
                    default:
                        break;
                }
                
            }
            else
            {
                celular1.Desligar();
                Environment.Exit(1);
            }
        }
    }
}
