using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLibrary
{
    public class DeceptionMonster : Monster
    {
        public DeceptionMonster(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, streing description) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description) 
        {

        
        }//end Constructor

        public DeceptionMonster() 
        {
            Name = "Deceptive Beast";
            Description = "There are currently two states of these creatures. One is fully cemented in reality and completely aware of it's condition, the other has succomb to the unconscious desire for more. Being unaware of the force that torments them they often confuse friends for enemies.";
            MaxLife = 14;
            MaxDamage= 11;
            HitChance= 22;
            Block = 22;
            MinDamage= 8;
                
        }//end constructor 
        //TODO add more to monster
        //abilities? unique perks of battel
        public override string ToString()
        {
            return base.ToString();
        }//end override 

    }
}
