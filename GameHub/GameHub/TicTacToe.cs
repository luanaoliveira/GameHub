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
                    Console.Write("L: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("C: ");
                    int y = int.Parse(Console.ReadLine());
                    this.play(x, y, "O");

                }
                else
                {
                    Console.WriteLine("Vez de X");
                    Console.Write("L: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("C: ");
                    int y = int.Parse(Console.ReadLine());
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
            for (int i = 0; i < 3; i++)
            {
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
