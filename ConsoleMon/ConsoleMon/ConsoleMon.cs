using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    enum Element
    {
        Fire = 1,
        Water = 2,
        Earth = 3,
        Air = 4,
    }

    internal class ConsoleMon
    {
        int Health = 5;
        int Energy = 0;
        string name = "Chimchar";
        Element weakness = Element.Water; //Geen string maar element

        List<Skill> skills = new List<Skill>();

        public void TakeDamage(int Damage)
        {

            Health = -Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = -energy;
        }

    }
}
