using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Wizard
    {
        public string Name{get;}
        public SpellsBook SpellsBook {get;}
        public Staff Staff{get;}
        public int AttackValue{get;}
        public int DefenseValue{get;}
        public int Health{get;private set;}

        public Wizard(string name)
        {
            Name = name;
            Health = 100;

            SpellsBook = new SpellsBook();
            Staff = new Staff();
        }

        public void ReceiveAttack(int power)
        {
            Health -= power;
        }

        public void Cure()
        {
            Health = 100;
        }
        
    }
}