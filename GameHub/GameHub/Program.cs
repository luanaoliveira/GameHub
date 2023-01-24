using System.Security.Cryptography.X509Certificates;

namespace GameHub
{
    public class Program
    {
        public static void bootstrap(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    board[i, j] = "_";
                }
            }
        }

        public static void displayBoard(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i, j]} ");
                }
                Console.WriteLine("");
            }
        }

        public static void play(string[,] board, int x, int y, string simbol)
        {
            board[x, y] = simbol;
        }
        public static void Main(string[] args)
        {
            string[,] board = new string[3, 3];
            bootstrap(board);
            int count = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Jogo da velha\n");
                displayBoard(board);
                Console.WriteLine();
                if (count % 2 == 0)
                {
                    Console.WriteLine("Vez de O");
                    Console.Write("L: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("C: ");
                    int y = int.Parse(Console.ReadLine());
                    play(board, x, y, "O");
                } else
                {
                    Console.WriteLine("Vez de X");
                    Console.Write("L: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("C: ");
                    int y = int.Parse(Console.ReadLine());
                    play(board, x, y, "X");
                }
                count ++;
            } while (true);
        }
    }
}