using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    internal class TicTacToeGame
    {
        private string[,] board;

        public TicTacToeGame()
        {
            this.board = new string[3, 3];
        }

        public void run ()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            this.bootstrap();
            int count = 1;
            bool done = false;
            Dictionary<string, int> columns = new Dictionary<string, int>();
            columns.Add("a", 0);
            columns.Add("b", 1);
            columns.Add("c", 2);
            do
            {
                Console.Clear();
                Console.WriteLine("Jogo da velha\n");
                this.displayBoard();

                if (this.isDone("X"))
                {
                    done = true;
                    Console.WriteLine("\nX ganhou!");
                    Console.ReadKey();
                }

                if (this.isDone("O"))
                {
                    done = true;
                    Console.WriteLine("\nO ganhou!");
                    Console.ReadKey();
                }

                Console.WriteLine();
                if (count % 2 == 0)
                {
                    Console.WriteLine("Vez de O");
                    Console.Write("Escola a casa: ");
                    string square = Console.ReadLine();
                    int x = int.Parse(square[0].ToString());
                    int y = columns[square[1].ToString()];
                    this.play(x, y, "O");

                }
                else
                {
                    Console.WriteLine("Vez de X");
                    Console.Write("Escola a casa: ");
                    string square = Console.ReadLine();
                    int x = int.Parse(square[0].ToString());
                    int y = columns[square[1].ToString()];
                    this.play(x, y, "X");

                }
                count++;
            } while (!done);
        }
        private void bootstrap()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.board[i, j] = "_";
                }
            }
        }

        private void displayBoard()
        {
            Console.WriteLine($"  a b c");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{this.board[i, j]} ");
                }
                Console.WriteLine("");
            }
        }

        private void play(int x, int y, string symbol)
        {
            this.board[x, y] = symbol;
        }

        private bool isDone(string symbol)
        {
            if (this.board[0, 0] == symbol && board[0, 1] == symbol && board[0, 2] == symbol)
            {
                return true;
            }
            if (this.board[1, 0] == symbol && board[1, 1] == symbol && board[1, 2] == symbol)
            {
                return true;
            }
            if (this.board[2, 0] == symbol && board[2, 1] == symbol && board[2, 2] == symbol)
            {
                return true;
            }
            if (this.board[0, 0] == symbol && board[1, 0] == symbol && board[2, 0] == symbol)
            {
                return true;
            }
            if (this.board[0, 1] == symbol && board[1, 1] == symbol && board[2, 1] == symbol)
            {
                return true;
            }
            if (this.board[0, 2] == symbol && board[1, 2] == symbol && board[2, 2] == symbol)
            {
                return true;
            }
            if (this.board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
            {
                return true;
            }
            if (this.board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
            {
                return true;
            }
            return false;
        }
    }
}
