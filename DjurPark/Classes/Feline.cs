using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurPark.Classes
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, DateTime birthDate) : base(name, birthDate)
        {
        }
    }
}
