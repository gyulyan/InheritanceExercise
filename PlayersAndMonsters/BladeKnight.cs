using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class BladeKnight : DarkWizard
    {
        public string Name { get; set; }
        public BladeKnight(string username, int level) : base(username, level)
        {
        }
    }
}
