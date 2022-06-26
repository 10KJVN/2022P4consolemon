using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    //Enums
    enum Element
    {
        Fire = 1,
        Water = 2,
        Earth = 3,
        Air = 4,
    }

    public class ConsoleMon
    {
        //Waardes
        public int Health = 100;
        public int Energy = 100;
        string Name = "Chimchar";
        public int Damage;
        Element weakness = Element.Water; //Geen string maar element

        internal List<Skill> skills = new List<Skill>();

        //Functies
        public void TakeDamage(int Damage)
        {
            Health = -Damage;
        }

        public void DepleteEnergy(int Energy)
        {
            Energy = -Energy;
        }

        //Constructors
        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.Name = copyFrom.Name;
            this.Health = copyFrom.Health;
            this.Energy = copyFrom.Energy;

            Damage = copyFrom.Damage;
            //[attack, fireball, screech]

            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.skills[i];
                Skill clone = new Skill(copyFromThisSkill);

                this.skills.Add(clone);
            }
         
        }

    }
}

