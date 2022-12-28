using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace PathLibrary
{
    public class Monster : Character

    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public string Description { get; set; }

        public int MinDamage 
        {
            get { return _minDamage;} 
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1;}
        
        }

        public Monster() { }


        public Monster(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife)
        { 
            MaxDamage= maxDamage;
            MinDamage= minDamage;
            Description= description;
        
        }

        public override string ToString() 
        {
            return $"---------Monster------------\n" +
                $"{base.ToString()}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Description\n{Description}";
        
        }

     
    }
}
