using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        private const double HERO_STARTING_HEALTH = 100;
        private const double VILLAIN_STARTING_HEALTH = 100;
        private const double HERO_STARTING_MANA = 50;
        private const double VILLAIN_STARTING_MANA = 70;

        private readonly Faction FACTION;

        private double health;
        private double mana;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)//, Weapon weapon)
        {
            this.name = name;
            FACTION = faction;
            //this.weapon = weapon;
            isAlive = true;

            switch (faction)
            {
                case Faction.Hero:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = HERO_STARTING_HEALTH;
                    mana = HERO_STARTING_MANA;
                    break;
                case Faction.Villain:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = VILLAIN_STARTING_HEALTH;
                    mana = VILLAIN_STARTING_MANA;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            double damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} died pathetically like the worm that he was", ConsoleColor.DarkBlue);
                Tools.ColorfulWriteLine($"The legendary {name} arises victorious from this bloody battle\n", ConsoleColor.Green);
                
            } else
            {
                System.Console.WriteLine($"The great {name} ATTACKED {enemy.name} | {enemy.name} got inflicted this much damage {damage}, and has {enemy.health} remaining health ");
            }
        }
    }
}
