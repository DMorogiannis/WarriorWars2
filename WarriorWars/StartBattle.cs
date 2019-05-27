using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarriorWars.Enum;


namespace WarriorWars
{
    class StartBattle
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            //string hero1 = " ";
            //string villain1 = " ";
            Console.WriteLine("Give the name of your hero : ");
            string hero1 = Console.ReadLine();
            Console.WriteLine("Give the name of the villain you are going to fight : ");
            string villain1 = Console.ReadLine();
            Warrior goodwarrior = new Warrior(hero1, Faction.Hero);
            Warrior evilwarrior = new Warrior(villain1, Faction.Villain);

            while (goodwarrior.IsAlive && evilwarrior.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodwarrior.Attack(evilwarrior);
                }
                else
                {
                    evilwarrior.Attack(goodwarrior);
                }

                Thread.Sleep(100);
            }

            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }
    }
}
