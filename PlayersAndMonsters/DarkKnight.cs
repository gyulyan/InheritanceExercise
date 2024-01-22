using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class DarkKnight : Knight
    {
        public string Name { get; set; }
        public DarkKnight(string username, int level) : base(username, level)
        {
        }
    }
}
