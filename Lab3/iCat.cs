using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class iCat : iAnimal
    {
        public string name { get; set; }
        public string colour { get; set; }
        public double height { get; set; }
        public double age { get; set; }

        public void eat()
        {
            Console.WriteLine("Cats eat mice");
        }
        public string cry()
        {
            return "Meow!";
        }
    }
}
