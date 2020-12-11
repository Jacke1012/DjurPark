using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurPark.Classes
{
    public abstract class Djur
    {
        protected float averageLifeSpan;
        public string name;
        public Gender gender;

        protected Djur(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
            alive = true;
        }

        public DateTime birthDate{ private set; get; }
        public bool alive { private set; get; }
        public DateTime deathDate { private set; get; }
        public AnimalSize size { get; set; }

        public float age => (float)Math.Round(((birthDate - Form1.currentDate).TotalDays/365),1);


        public void Birth(DateTime birthDate, Gender gender)
        {
            if (birthDate == null)
            {
                this.birthDate = birthDate;
            }
        }
        public void Died(DateTime deathDate)
        {
            if (alive == true)
            {
                this.deathDate = deathDate;
                alive = false;
            }
        }

        public override string ToString()
        {
            return name;
        }

        public virtual string PrintInfo()
        {
            return $"Name:{name}\r\nArt:{this.GetType().Name}\r\nSize:{size}\r\nAlive: {(alive ? "Yes" : "No")}\r\n{(alive ? "" : $"DeathDate: {deathDate}")}";
        }

    }
}
