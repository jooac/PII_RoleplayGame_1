using System;

namespace Library
{
    public class Elve
    {
        private string name;
        public string Name
        {
            get{return name;} set{name = value;}
        }
        private int health;
        public int Health
        {
            get{return health;} set{health = value;}
        }
        public Elve (string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }
    }
}