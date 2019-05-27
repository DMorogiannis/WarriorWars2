using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        //Random rng = new Random();

        private const double HERO_DAMAGE = 5;
        private const double VILLAIN_DAMAGE = 5;

        private double damage;
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
            Random rng = new Random();
            //if (rng.Next(1, 5) > 1)
            //{
            //    HERO_DAMAGE = 10;
            //}


            durability = 10;
            switch (faction)
            {
                case Faction.Hero:
                    damage = HERO_DAMAGE;
                    break;
                case Faction.Villain:
                    damage = VILLAIN_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}