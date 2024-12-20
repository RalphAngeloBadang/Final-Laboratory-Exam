using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{
    class Warrior : GameCharacter
    {
        public int Armor { get; private set; } = 10;

        public Warrior(string name, int level, int health, int strength)
            : base(name, level, health, 0, strength, 0)
        {
        }

        public override int Attack()
        {
            int baseDamage = Strength * 2;
            Random rand = new Random();
            bool isCritical = rand.Next(100) < 20;
            int damage = isCritical ? baseDamage * 2 : baseDamage;

            Console.WriteLine($"{Name} swings his weapon, dealing {damage} damage! {(isCritical ? "It's a CRITICAL SMASH! Boom!" : "")}");
            return damage;
        }

        public override int Defend(int incomingDamage)
        {
            Random rand = new Random();
            bool isBlock = rand.Next(100) < 15;
            int damageReduction = isBlock ? incomingDamage : incomingDamage - (Armor / 2);
            damageReduction = Math.Max(0, damageReduction);

            if (isBlock)
            {
                Console.WriteLine($"{Name} BLOCKED all incoming damage!");
            }
            else
            {
                Health -= damageReduction;
                Console.WriteLine($"{Name} reduced the damage by {Armor / 2} and took {damageReduction} damage. [Health: {Health}]");
            }

            return damageReduction;
        }

        public override void LevelUp()
        {
            Level++;
            Strength += 5;
            Health += 20;
            Armor += 2;

            Console.WriteLine($"{Name} has leveled up! he feel stronger and more powerful!");
        }
    }
}