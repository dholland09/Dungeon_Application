namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

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

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format($"Min Damage: {MinDamage}\nMaxDamage: {MaxDamage}\nName {Name}\n Bonuse Hit Change {BonusHitChance}\nIsTwoHanded {IsTwoHanded}");
        }
    }
}