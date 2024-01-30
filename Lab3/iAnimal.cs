using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface iAnimal
    {
        string name { get; set; }
        string colour { get; set; }
        double height { get; set; }
        double age { get; set; }

        abstract void eat();
        public string cry()
        {
            return "";
        }
    }
}
