using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurPark.Classes
{
    public class Tiger : Feline
    {
        public Tiger(string name, DateTime birthDate): base(name, birthDate)
        {
            averageLifeSpan = 15.5f;
        }
    }
}
