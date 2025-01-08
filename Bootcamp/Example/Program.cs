using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);

            Battle.StartFight(thor, loki);

        }
    }
}