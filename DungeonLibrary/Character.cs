﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Character
    {
        //FIELDS

        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
       //Ask if there is suppose to be two of these
       //private int _life;

        //PROPERTIES
        public int Life
        {
            get { return _life; }
            set { _life = value; }

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }

        }

        public int Block
        {

            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        //CONSTRUCTORS
        public Character(int life, string name, int hitChance, int block, int maxLife)
        {
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
        }

        //METHODS

        public int CalcBlock()
        {
            return Block;
        }

        public int CalcHitChance()
        {
            return HitChance;
        }

        public int CalcDamage()
        {
            return 0;
        }

        public override string ToString()
        {
            return string.Format($"Life: {Life}\nName: {Name}\nHit Chance: {HitChance}\n Block: {Block}\nMax Life:{MaxLife}");
        }
    }
}