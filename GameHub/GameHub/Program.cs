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
            PlayersRepository players = new PlayersRepository();
            int option;
            do
            {
                
                UserInterface.Header();
                option = UserInterface.MainMenu();

                switch (option)
                {
                    case 1:
                        Player player1 = new Player();
                        Console.Write("Nome do jogador: ");
                        player1.userName = Console.ReadLine();
                        players.CreatePlayer(player1);
                        break;
                    case 2:
                        Player[] ranking = players.getRanking();
                        Console.WriteLine("JOGADOR | SCORE");
                        for (int i = 0; i < ranking.Length; i++)
                        {
                            Console.WriteLine($"{i + 1} lugar -> {ranking[i].userName} | {ranking[i].score}");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        ticTacToeGame.run(players);
                        break;
                }
            } while (option != 0);
        }
    }
}