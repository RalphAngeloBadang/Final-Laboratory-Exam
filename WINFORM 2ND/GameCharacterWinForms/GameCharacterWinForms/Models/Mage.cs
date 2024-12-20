using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{
    class Mage : GameCharacter
    {
        public int SpellPower { get; private set; } = 10;

        public Mage(string name, int level, int health, int mana, int intelligence)
            : base(name, level, health, mana, 0, intelligence)
        {
        }

        public override int Attack()
        {
            int baseDamage = Intelligence * 3 + SpellPower;
            Random rand = new Random();
            bool isBurning = rand.Next(100) < 25;

            Console.WriteLine($"{Name} casts a fireball spell, dealing {baseDamage} damage! {(isBurning ? "The enemy is BURNINGGGG!" : "")}");
            return baseDamage;
        }

        public override int Defend(int incomingDamage)
        {
            Random rand = new Random();
            bool isEvade = rand.Next(100) < 20;
            int damageReduction = isEvade ? incomingDamage : incomingDamage - (Mana / 4);
            damageReduction = Math.Max(0, damageReduction);

            if (isEvade)
            {
                Console.WriteLine($"{Name} DODGES the attack completely!");
            }
            else
            {
                Health -= damageReduction;
                Console.WriteLine($"{Name} reduced the damage by {Mana / 4} and took {damageReduction} damage. [Health: {Health}]");
            }

            return damageReduction;
        }

        public override void LevelUp()
        {
            Level++;
            Intelligence += 5;
            Mana += 15;
            SpellPower += 3;

            Console.WriteLine($"{Name} has leveled up! her magic is now even more powerful!");
        }
    }

}
