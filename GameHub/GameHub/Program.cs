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

            /*Console.WriteLine("Jogador1 == X | Jogador2 == O");
            Console.WriteLine("\n");
            Console.WriteLine($"{posicao[0]} {posicao[1]} {posicao[2]}");
            Console.WriteLine($"{posicao[3]} {posicao[4]} {posicao[5]}");
            Console.WriteLine($"{posicao[6]} {posicao[7]} {posicao[8]}");
            Console.WriteLine("\n");

            for (int i = 0; i <= posicao.Length; i++)
            {
                Console.WriteLine("Digite a posição do Jogador1");
                jogadorX = Console.ReadLine();

                if (jogadorX == posicao[i])
                    {
                        posicao[i] = "X";

                        Console.WriteLine($"{posicao[0]} {posicao[1]} {posicao[2]}");
                        Console.WriteLine($"{posicao[3]} {posicao[4]} {posicao[5]}");
                        Console.WriteLine($"{posicao[6]} {posicao[7]} {posicao[8]}");
                    }
            } */

           /*int[,] posicao = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Escolha");

                    posicao[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{posicao[i, j]}");
                }
            }

            Console.WriteLine($"{posicao[0, 0]} {posicao[0, 1]} {posicao[0, 2]}");
            Console.WriteLine($"{posicao[1, 0]} {posicao[1, 1]} {posicao[1, 2]}");
            Console.WriteLine($"{posicao[2, 0]} {posicao[2, 1]} {posicao[2, 2]}");*/
        }
    }
}