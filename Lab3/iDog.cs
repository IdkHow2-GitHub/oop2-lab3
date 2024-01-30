using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class iDog : iAnimal
    {
        public string name { get; set; }
        public string colour { get; set; }
        public double height { get; set; }
        public double age { get; set; }

        public void eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        public string cry()
        {
            return "Woof!";
        }
    }
}
