using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    internal class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player p1, Player p2)
        {
            return p2.score.CompareTo(p1.score);
        }
    }
    public class PlayersRepository
    {
        public Player[] players;
        public PlayersRepository()
        {
            this.players = new Player[0];
        }

        public void CreatePlayer(Player player)
        {
            this.players = this.players.Append(player).ToArray();
        }

        public Player getPlayer(string name)
        {
            for (int i = 0; i < this.players.Length; i++)
            {
                if (this.players[i].userName == name)
                    return this.players[i];
            }
            throw new IndexOutOfRangeException("Jogador inexistente!");
        }

        public Player[] getRanking()
        {
            Array.Sort(this.players, new PlayerComparer());
            return this.players;
        }

    }

}
