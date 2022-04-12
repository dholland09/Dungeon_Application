using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class DementedPatient : Monster 
    {
        public DateTime HourChangeBack { get; set; }

        public DementedPatient(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            HourChangeBack = DateTime.Now;

            
            if (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 20)
            {
                HitChance += 20;
                Block += 40;
                MinDamage += 5;
                MaxDamage += 20;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                base.ToString(),
                HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18 ?
                "Sundowners has set in" : "Daylight brings simple pleasures");
        }
    }
}
