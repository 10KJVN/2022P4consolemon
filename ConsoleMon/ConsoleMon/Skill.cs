using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        float Damage = 16;
        float EnergyCost = 4;
        string Name = "Ember";
        Element element = Element.Fire; //Element. om te kiezen van de Enums

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(5);
            target.TakeDamage(5);
        }

        internal Skill()
        {
           
        }

        internal Skill(Skill copyFrom)
        {
            this.Damage = copyFrom.Damage;
            this.EnergyCost = copyFrom.EnergyCost;
            this.Name = copyFrom.Name; 
        }

    }

}
