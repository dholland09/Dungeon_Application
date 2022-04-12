using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Anestesiologist : Monster
    {
        public bool IsArrogant { get; set; }

        public Anestesiologist(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isArrogant)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsArrogant= isArrogant;
        }

        public Anestesiologist()
        {
            Name = "Cliff Peda";
            MaxLife = 200;
            Life = 200;
            HitChance = 80;
            Block = 50;
            MinDamage = 20;
            MaxDamage = 40;
            Description = "High and mighty, nothing will bring him down.";
            IsArrogant = true;
        }

        public override string ToString()
        {
            return base.ToString() + (IsArrogant ? "Half asleep and barely standing" : "Ready to attack even the nicest person");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsArrogant)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
