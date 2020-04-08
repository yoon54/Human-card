using System;
using System.Collections.Generic;

namespace DemoOOP.Models
{
    public class Human
    {
        public string Name;
        public int Dexterity;
        public int Strength;
        public int Speed;
        protected int health;

        public Human(string name)
        {
            Name = name;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
        }

        public Human(string name, int dex, int str, int spd)
        {
            Name = name;
            Dexterity = dex;
            Strength = str;
            Speed = spd;
            health = 100;
        }


        public int Attack(Human target)
        {
            if( target is Human )
            {
                int dmg = 5 * Strength;
                target.health -= dmg;
                Console.WriteLine($"{Name} just gave a swift and just kick to {target.Name}");
                return target.health;
            }
            else
            {
                throw new Exception("That wasn't a proper Attack!!!");
            }
        }

        public int TakeDmg(int dmg)
        {
            health -= dmg;
            return health;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }
    }
}