using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match
{
    public class Goalkeeper : Football_Player
    {
        public Goalkeeper(string name, int number, int age, double height) : base(name, number, age, height)
        {
        }
    }
}
