using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class SoulMaster : DarkWizard
    {
        public string Name { get; set; }
        public SoulMaster(string username, int level) : base(username, level)
        {
        }
    }
}
