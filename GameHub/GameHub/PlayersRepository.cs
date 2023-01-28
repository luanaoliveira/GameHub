using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace GameHub
{
    internal class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player p1, Player p2)
        {
            return p2.score.CompareTo(p1.score);
        }
    }

    internal class Database
    {
        private readonly static string databaseFileName = "players_database.json";
        public static Player[] load()
        {
            string playersJson = File.ReadAllText(databaseFileName);
            return JsonSerializer.Deserialize<Player[]>(playersJson);
        }

        public static void save(Player[] players) {
            string jsonString = JsonSerializer.Serialize(players);
            File.WriteAllText(databaseFileName, jsonString);
        }
    }
    public class PlayersRepository
    {
        public Player[] players;
        public PlayersRepository()
        {
            this.players = Database.load();
        }

        public void CreatePlayer(Player player)
        {
            this.players = this.players.Append(player).ToArray();
            Database.save(this.players);
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

        public void updateScore(string playerName, int additionalScore)
        {
            this.getPlayer(playerName).score += additionalScore;
            Database.save(this.players);
        }

    }

}
