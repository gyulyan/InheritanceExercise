using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Elf : Hero
    {
        public string Name { get; set; }
        public Elf(string username, int level) : base(username, level)
        {
        }
    }
}
