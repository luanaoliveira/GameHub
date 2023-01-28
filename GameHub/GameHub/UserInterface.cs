using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public class UserInterface
    {
        static public void Header()
        {
            Console.Clear();
            Console.WriteLine(">>>>> GAMEHUB <<<<<");
            Console.WriteLine();
        }

        static public int MainMenu()
        {
            Console.WriteLine("1 - Criar jogador");
            Console.WriteLine("2 - Ver Ranking");
            Console.WriteLine("3 - Jogo da velha");
            Console.WriteLine();
            Console.Write("Opção: ");
            return int.Parse(Console.ReadLine());
        }

        static public string InputPlayerName()
        {
            Console.Write("Nome do jogador: ");
            string playerName = Console.ReadLine();
            return playerName;
        }

        static public void DisplayRanking(Player[] ranking)
        {
            Console.Clear();
            Console.WriteLine("POSIÇÃO | SCORE | JOGADOR\n");
            for (int i = 0; i < ranking.Length; i++)
            {
                Console.WriteLine($"{i + 1}º | {ranking[i].score} pts | {ranking[i].userName}");
            }
            Console.ReadKey();
        }
    }
}
