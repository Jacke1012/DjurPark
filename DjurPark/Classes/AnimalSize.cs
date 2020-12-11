using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurPark.Classes
{
    public class AnimalSize
    {
        public float weight;
        public float length;
        public float height;

        public AnimalSize(float weight, float length, float height)
        {
            this.weight = weight;
            this.length = length;
            this.height = height;
        }

        public override string ToString()
        {
            return $"{weight}kg, {length}cm * {height}cm";
        }
    }
}
