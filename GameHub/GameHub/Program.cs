using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace GameHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PlayersRepository players = new PlayersRepository();
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            NavalBattle navalBattle = new NavalBattle();
            
            int option;

            do
            {
                UserInterface.Header();
                option = UserInterface.MainMenu();

                switch (option)
                {
                    case 1:
                        Player player = new Player();
                        player.userName = UserInterface.InputPlayerName();
                        players.CreatePlayer(player);
                        break;
                    case 2:
                        Player[] ranking = players.GetRanking();
                        UserInterface.DisplayRanking(ranking);
                        break;
                    case 3:
                        ticTacToeGame.Run(players);
                        break;
                    case 4:
                        navalBattle.Run(players);
                        break;
                }
            } while (option != 0);
        }
    }
}