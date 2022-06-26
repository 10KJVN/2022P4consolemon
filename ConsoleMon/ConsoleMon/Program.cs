using System;
using System.Collections.Generic;

namespace ConsoleMon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon a = new ConsoleMon();

            ConsoleMon b = new ConsoleMon();
            
            Skill fire = new Skill();
            Skill water = new Skill();
            Skill lightning = new Skill();
            Skill shadow = new Skill();

            a.skills.Add(fire);
            a.skills.Add(water);

            b.skills.Add(lightning);
            b.skills.Add(shadow);

            ConsoleMonArena arena = new ConsoleMonArena();
            arena.DoBattle(a, b);
        }
    }

    /*enum Elements
    {
        Fire,
        Water,
        Lightning,
        Shadow
    }
    */
}
