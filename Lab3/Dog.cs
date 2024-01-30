using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dog : Animal
    {
        public override string name { get; set; }
        public override string colour { get; set; }
        public override double age { get; set; }

        public override void eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
