﻿namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private string _weaponType;

        //PROPERTIES

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public string WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }
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

        //CONSTRUCTORS

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance,, string weaponType, bool isTwoHanded)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            WeaponType = weaponType;
            IsTwoHanded = isTwoHanded;
        }

        //METHODS
        public override string ToString()
            //TODO update 
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\n{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                WeaponType,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }
    }
}