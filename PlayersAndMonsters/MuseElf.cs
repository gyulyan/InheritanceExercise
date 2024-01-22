using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class MuseElf : Elf
    {
        public string Name { get; set; }
        public MuseElf(string username, int level) : base(username, level)
        {
        }
    }
}
