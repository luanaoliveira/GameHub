using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public class Player
    {
        public string userName { get; set; }
        public int score { get; set; }
        public string type { get; set; }
        public Player()
        {
            this.userName = string.Empty;
            this.score = 0;
        }
    }
}
