using System;
using System.Collections.Generic;
using System.Text;
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        static Random rng = new Random();

        double hero_damage = 5;
        double villain_damage = 5;

        private double damage;

        //private TypeWeapon type;

        public double Damage
        {
            get
            {
                return damage;
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

            switch (faction)
            {
                case Faction.Hero:
                    damage = hero_damage;
                    break;
                case Faction.Villain:
                    damage = villain_damage;
                    break;
                default:
                    break;
            }
        }
    }
}