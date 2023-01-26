using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace GameHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.run();
        }
    }
}