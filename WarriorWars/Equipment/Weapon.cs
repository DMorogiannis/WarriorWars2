using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        //Random rng = new Random();
        static Random rng = new Random();

        double hero_damage = 5;
        double villain_damage = 5;

        private double damage;
        int hero_durability = 5;
        int villain_durability = 5;
        private int durability;
        //private TypeWeapon type;

        public double Damage
        {
            get
            {
                return damage;
            }
        }

        public int Durability
        {
            get
            {
                return durability;
            }
        }

        //public TypeWeapon Type
        //{
        //    get
        //    {
        //        return type;
        //    }
        //}

        public Weapon(Faction faction)
        {

            //if (rng.Next(1, 6) > 3)
            //{
            //    hero_damage = 10;
            //} 
            //if (rng.Next(1, 6) <= 3)
            //{
            //    villain_damage = 10;
            //}




            //switch (faction)
            //{
            //    case Faction.Hero:
            //        if (rng.Next(1, 6) == 1)
            //        {
            //            hero_durability -= 1;
            //        }
            //        break;
            //    case Faction.Villain:
            //        if (rng.Next(1, 6) == 1)
            //        {
            //            villain_durability -= 1;
            //        }
            //        break;
            //    default:
            //        break;
            //}


            // durability = 5;
            switch (faction)
            {
                case Faction.Hero:
                    damage = hero_damage;
                    if (rng.Next(1, 6) == 1)
                    {
                        hero_durability -= 1;
                    }
                    durability = hero_durability;
                    break;
                case Faction.Villain:
                    damage = villain_damage;
                    if (rng.Next(1, 6) == 1)
                    {
                        villain_durability -= 1;
                    }
                    durability = villain_durability;
                    break;
                default:
                    break;
            }
        }
    }
}