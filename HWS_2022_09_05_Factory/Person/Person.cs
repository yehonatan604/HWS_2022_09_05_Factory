using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_09_05_Factory
{
    public abstract class Person
    {
        //Properties
        public virtual string? Name { get; set; }
        public virtual string? Proffession { get; set; }
        public virtual int Age { get; set; }
        public virtual double Weight { get; set; }
        public virtual double Height { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Proffession}";
        }
    }
}
