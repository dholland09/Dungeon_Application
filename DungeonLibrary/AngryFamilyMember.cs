using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class AngryFamilyMember : Monster
    {
        public bool IsAngry { get; set; }

        public AngryFamilyMember(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isAngry)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsAngry = isAngry;
        }

        public AngryFamilyMember()
        {
            Name = "Karen Squared";
            MaxLife = 40;
            Life = 36;
            HitChance = 15;
            Block = 10;
            MinDamage = 1;
            MaxDamage = 4;
            Description = "I want to speak to a SUPERVISOR!!!";
            IsAngry = true;
        }

        public override string ToString()
        {
            return base.ToString() + (IsAngry ? "Infuriated" : "Looks like things could escalte.");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

          
            if (IsAngry)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
