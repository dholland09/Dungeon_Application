﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
       public abstract class Monster : Character
    {
        private int _minDamage;

        
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        
        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage,
            int minDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster() { }

        public override string ToString()
        {
            return string.Format("\n********** MONSTER **********\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nDescription:\n{6}\n",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }

        
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
