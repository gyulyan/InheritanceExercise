using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class DarkWizard : Wizard
    {
        public string Name { get; set; }
        public DarkWizard(string username, int level) : base(username, level)
        {
        }
    }
}
