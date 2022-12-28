using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PathLibrary
{
    public abstract class Character
    {
        //Fields 
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        //Properties 

        public string Name { get { return _name; } set { _name = value; } }
        public int HitChance { get { return _hitChance; } set { _hitChance = value; } }
        public int Block { get { return _block; } set { _block = value; } }
        public int MaxLife { get { return _maxLife; } set { _maxLife = value; } }
        public int Life { get { return _life; } set { _life = value <= MaxLife ? value : MaxLife; } }


        //Constructors - Collect 

        public Character(string name, int hitChance, int block, int maxLife) 
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life= maxLife;//default new Character types to have maxLife 
        
        }

        public Character()
        {

        }

        //Methods - Monkeys

        public override string ToString()
        {
            return $"---------{Name}----------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }//end ToString

        //TODO clacBLock()
        //TODO calcDamage()
     


    }//end class
}//end namespace