using System.ComponentModel.Design;

namespace Adivinhar
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();
           int aleatorio = rand.Next(3);   

            while (true)
            {
                Console.WriteLine("Adivinhe o numero");
                string input = Console.ReadLine();

                if (!int.TryParse (input, out int palpite))
                {
                    Console.WriteLine("Digite um numero valido ");
                    continue;
                }

                if (palpite > aleatorio )
                {
                    Console.WriteLine("seu palpite é maior ");
                    
                }   
                else if (palpite < aleatorio)
                {
                    Console.WriteLine("Seu palpite é menor");
                    
                }
                else
                {
                    Console.WriteLine("Você acertou");
                    break;
                }
            } 

        }   

    }
}
