using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        static Random rng = new Random();

        private const double HERO_STARTING_HEALTH = 100;
        private const double VILLAIN_STARTING_HEALTH = 100;
        private const int HWEAPON_HEALTH = 5;
        private const int VWEAPON_HEALTH = 5;
        private const double HERO_STARTING_MANA = 50;
        private const double VILLAIN_STARTING_MANA = 50;

        private readonly Faction FACTION;

        private double health;
        private double mana;
        private string name;
        private int durability;
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
                    durability = HWEAPON_HEALTH;
                    break;
                case Faction.Villain:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = VILLAIN_STARTING_HEALTH;
                    mana = VILLAIN_STARTING_MANA;
                    durability = VWEAPON_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            double damage = weapon.Damage / enemy.armor.ArmorPoints;
            if (rng.Next(1, 6) > 4)
            {
                damage = damage * 2;
                Console.WriteLine("Critical strike landed !!!!!" );
            }
            enemy.health -= damage;

            if (rng.Next(1, 6) > 3)
            {
                durability -= 1;
            }

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} died pathetically like the worm that he was", ConsoleColor.DarkBlue);
                Tools.ColorfulWriteLine($"The legendary {name} arises victorious from this bloody battle\n", ConsoleColor.Green);
                
            } else
            {
                if (health < 40 && mana >= 10)
                {
                    Console.WriteLine("Your have {0} mana", mana);
                    Console.WriteLine($"The situation is desperate {name}, do you wanna try to use magic?\n<<Music intesifies>>\nAnswer with 'YES/NO' fast.\tWHAT SAY YOU?");
                    Console.WriteLine("The situation is desperate"); Tools.ColorfulWriteLine($"{name}", ConsoleColor.DarkBlue); Console.WriteLine("do you wanna try to use magic?\n<<Music intesifies>>\nAnswer with 'YES/NO' fast.\tWHAT SAY YOU?");
                    string answer = Console.ReadLine();
                    if (answer.Equals("YES") || answer.Equals("yes"))
                    {
                        mana -= 10;
                        int randomMagic = rng.Next(1, 4);
                        if (rng.Next(1, 4) == 1) {
                            switch (randomMagic)
                            {
                                case 1:
                                    Tools.ColorfulWriteLine($"{name} used the powerful magic of thunderbolt", ConsoleColor.Yellow);
                                    Console.WriteLine("The enemy has {0} health", enemy.health);
                                    enemy.health -= 10;
                                    Console.WriteLine("Now he has {0} health", enemy.health);
                                    break;
                                case 2:
                                    Tools.ColorfulWriteLine($"{name} used the powerful magic of fire blast", ConsoleColor.DarkRed);
                                    Console.WriteLine("The enemy has {0} health", enemy.health);
                                    enemy.health -= 7;
                                    Console.WriteLine("Now he has {0} health", enemy.health);
                                    break;
                                case 3:
                                    Tools.ColorfulWriteLine($"{name} used the powerful magic of ice beam", ConsoleColor.Cyan);
                                    Console.WriteLine("The enemy has {0} health", enemy.health);
                                    enemy.health -= 8.5;
                                    Console.WriteLine("Now he has {0} health", enemy.health);
                                    break;
                                default:
                                    break;
                            }
                        } else
                        {
                            Tools.ColorfulWriteLine("You failed to use magic you pathetic worm. 10 Mana went to waste", ConsoleColor.DarkMagenta);
                        }
                    }
                    //rng.Next(1,2) 
                }
                Console.WriteLine($"The great {name} ATTACKED {enemy.name} | {enemy.name} got inflicted this much tremendous ammount of painful damage {damage}, and has {enemy.health} remaining health ");
                if (durability > 0)
                {
                    Console.WriteLine($"Your weapon has {durability} hp left"); //and the enemy's weapon {enemy.durability} hp");
                } else 
                {
                    Console.WriteLine("Your great EXTRA weapon is broken {0}, hands only now", name);
                }
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
            }
        }
    }
}
