using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DevilsGate
{
    public class Level1 : IAbilities, IItems
    {
        public void AbilitiesOfPlayer()
        {
            Hashtable abilities = new()
            {
                { "Critical Hits", false },
                { "Blocker", false },
                { "Life Steal", false },
                { "Ranged Attack", false }
            };
        }
        public void ItemsOfPlayer()
        {
            Hashtable items = new()
            {
                { "Bare Hands", true },
                { "Sword", false },
                { "Shield", false },
                { "Armour", false },
                { "Bow", false }
            };
        }
    }
}
