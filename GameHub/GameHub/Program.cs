using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace GameHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            int option;
            do
            {
                Console.WriteLine("Escolha seu jogo!\n");
                Console.WriteLine("1 - Jogo da Velha");
                Console.Write("\nOpção: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ticTacToeGame.run();
                        break;
                }
            } while (option != 0);
        }
    }
}