using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurPark.Classes
{
    public abstract class Mammal : Djur
    {
        public Mammal(string name, DateTime birthDate) : base(name, birthDate)
        {
        }
    }
}
