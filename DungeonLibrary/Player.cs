using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //TODO Update all descriptions and stuff
    
    public class Player : Character
    {
       
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace,
            Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)
        {
            
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;

            
        }

        
        public override string ToString()
        {
            
            string description = "";

            
            switch (CharacterRace)
            {
                case Race.Nurse:
                    description = "Registered Nurse";
                    break;
                case Race.RespratoryTherapist:
                    description = "Respratory Therapist";
                    break;
                case Race.Janitor:
                    description = "Janitor";
                    break;
                case Race.CNA:
                    description = "Certified Nursing Assistant";
                    break;
                case Race.RadiologyTechnologist:
                    description = "Radiology Technologist";
                    break;
                
            }

            
            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                HitChance,
                CalcHitChance(),
                Block,
                description);
        }

       
        public override int CalcDamage()
        {
           
            Random rand = new Random();

           
            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            return damage;
        }

       
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
