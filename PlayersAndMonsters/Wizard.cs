using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Wizard : Hero
    {
        public string Name { get; set; }
        public Wizard(string username, int level) : base(username, level)
        {
        }
    }
}
