using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public struct Position
    {
        public string content { get; set; }
        public bool reached { get; set; }
    };

    internal class NavalBattle
    {
        private Position[,] board;
        private int countPlayer1 = 0;
        private int countPlayer2 = 0;

        public NavalBattle()
        {
            this.board = new Position[8, 8];
        }

        public void Run(PlayersRepository players)
        {
            NavalBattle naval = new NavalBattle();
            this.Bootstrap();
            this.positionFirstPlayerShips();
            this.positionSecondPlayerShips();

            int count = 1;
            bool done = false;

            Console.WriteLine("Escolha o jogador 1: ");
            string name1 = Console.ReadLine();
            Player player1;
            try
            {
                player1 = players.GetPlayer(name1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }


            Console.WriteLine("Escolha o jogador 2: ");
            string name2 = Console.ReadLine();
            Player player2;

            try
            {
                player2 = players.GetPlayer(name2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

            Dictionary<string, int> columns = new Dictionary<string, int>();
            columns.Add("a", 0);
            columns.Add("b", 1);
            columns.Add("c", 2);
            columns.Add("d", 3);
            columns.Add("e", 4);
            columns.Add("f", 5);
            columns.Add("g", 6);
            columns.Add("h", 7);

            do
            {
                Console.Clear();
                Console.WriteLine("Batalha naval\n");
                Console.WriteLine($"{name1} (1): {this.countPlayer1}");
                Console.WriteLine($"{name2} (2): {this.countPlayer2}\n");
                this.DisplayBoard();

                if (this.countPlayer1 == 5)
                {
                    done = true;
                    players.UpdateScore(name1, 1);
                    Console.WriteLine($"\n{name1} ganhou!");
                    Console.ReadKey();
                    break;
                }

                if (this.countPlayer2 == 5)
                {
                    done = true;
                    players.UpdateScore(name2, 1);
                    Console.WriteLine($"\n{name2} ganhou!");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine();
                if (count % 2 == 0)
                {
                    Console.Write($"Vez de {player2.userName} (O): ");
                    string square = Console.ReadLine();
                    int x = int.Parse(square[0].ToString());
                    int y = columns[square[1].ToString()];
                    this.Play(x, y);
                }
                else
                {
                    Console.Write($"Vez de {player1.userName} (X): ");
                    string square = Console.ReadLine();
                    int x = int.Parse(square[0].ToString());
                    int y = columns[square[1].ToString()];
                    this.Play(x, y);
                }
                count++;
            } while (!done);
        }
        private void Bootstrap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.board[i, j].reached = false;
                    this.board[i, j].content = "W";
                }
            }
        }

        private void positionFirstPlayerShips()
        {
            Random randNum = new Random();
            int count = 5;
            while (count != 0)
            {
                int i = randNum.Next(0, 8);
                int j = randNum.Next(0, 8);
                if (this.board[i, j].content == "W")
                {
                    this.board[i, j].content = "1";
                    count--;
                }
            }
        }

        private void positionSecondPlayerShips()
        {
            Random randNum = new Random();
            int count = 5;
            while (count != 0)
            {
                int i = randNum.Next(0, 8);
                int j = randNum.Next(0, 8);
                if (this.board[i, j].content == "W")
                {
                    this.board[i, j].content = "2";
                    count--;
                }
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine($"  a b c d e f g h ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < 8; j++)
                {
                    if (this.board[i, j].reached)
                    {
                        Console.Write($"{this.board[i, j].content} ");
                    } else
                    {
                        Console.Write($"~ ");
                    }
                    
                }
                Console.WriteLine("");
            }
        }

        private void Play(int x, int y)
        {
            if (this.board[x, y].reached) return;

            this.board[x, y].reached = true;

            if (this.board[x, y].content == "1")
            {
                this.countPlayer2 += 1;
                return;
            }

            if (this.board[x, y].content == "2")
            {
                this.countPlayer1 += 1;
                return;
            }
        }
    }
}
