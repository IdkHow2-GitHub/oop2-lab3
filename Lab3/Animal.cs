using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Animal
    {
        public abstract string name { get; set; }
        public abstract string colour { get; set; }
        public abstract double age { get; set; }
        protected Animal() { }

        public abstract void eat();

    }
}
