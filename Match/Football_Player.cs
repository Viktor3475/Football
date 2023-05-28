using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match
{
    public abstract class Football_Player : Person
    {
        public int Number { get; private set; }

        public double Height { get; private set; }

        public Football_Player(string name,int number, int age,double height) : base(name, age)
        {
            Height = height;
            Number = number;
        }
    }
}
