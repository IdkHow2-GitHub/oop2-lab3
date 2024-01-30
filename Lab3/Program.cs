
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--Lab 3--");
            ArrayList all_animals = new ArrayList();
            //part 1
            Console.Write("\n\n> Part 1\n");
            Dog dog = new Dog();
            all_animals.Add(dog);

            //name
            Console.WriteLine("What is the name of the dog?");
            string dog_name = Console.ReadLine();
            dog.name = dog_name;
            Console.WriteLine($"The dog's name is {dog_name}!");

            //colour
            Console.WriteLine($"What colour is {dog_name}?");
            string dog_colour = Console.ReadLine();
            dog.colour = dog_colour;
            Console.WriteLine($"{dog_name} is {dog_colour}!");

            //age
            Console.WriteLine($"How old is {dog_name} in human year?");
            string dog_age = Console.ReadLine();
            dog.age = double.Parse(dog_age);
            Console.WriteLine($"{dog_name} is {dog_age} years old!");

            Cat cat = new Cat();
            all_animals.Add(cat);

            //name
            Console.WriteLine("What is the name of the cat?");
            string cat_name = Console.ReadLine();
            cat.name = cat_name;
            Console.WriteLine($"The cat's name is {cat_name}!");

            //colour
            Console.WriteLine($"What colour is {cat_name}?");
            string cat_colour = Console.ReadLine();
            cat.colour = cat_colour;
            Console.WriteLine($"{cat_name} is {cat_colour}!");

            //age
            Console.WriteLine($"How old is {cat_name} in human year?");
            string cat_age = Console.ReadLine();
            cat.age = double.Parse(cat_age);
            Console.WriteLine($"{cat_name} is {cat_age} years old!");

            Console.WriteLine("\nDOG");
            Console.WriteLine(dog.name.ToString());
            Console.WriteLine(dog.colour.ToString());
            Console.WriteLine(dog.age.ToString());
            dog.eat();
            Console.WriteLine("\nCAT");
            Console.WriteLine(cat.name.ToString());
            Console.WriteLine(cat.colour.ToString());
            Console.WriteLine(cat.age.ToString());
            cat.eat();

            //part 2
            Console.Write("\n\n> Part 2\n");
            iDog i_dog = new iDog();
            all_animals.Add(i_dog);

            //name
            Console.WriteLine("What is the name of the dog?");
            string i_dog_name = Console.ReadLine();
            i_dog.name = i_dog_name;
            Console.WriteLine($"The dog's name is {i_dog_name}!");

            //colour
            Console.WriteLine($"What colour is {i_dog_name}?");
            string i_dog_colour = Console.ReadLine();
            i_dog.colour = i_dog_colour;
            Console.WriteLine($"{i_dog_name} is {i_dog_colour}!");

            //height
            Console.WriteLine($"How tall is {i_dog_name} in centimeters?");
            string i_dog_height = Console.ReadLine();
            i_dog.height = double.Parse(i_dog_height);
            Console.WriteLine($"{i_dog_name} is {i_dog_height} years old!");

            //age
            Console.WriteLine($"How old is {i_dog_name} in human year?");
            string i_dog_age = Console.ReadLine();
            i_dog.age = double.Parse(i_dog_age);
            Console.WriteLine($"{i_dog_name} is {i_dog_age} years old!");

            iCat i_cat = new iCat();
            all_animals.Add(i_cat);

            //name
            Console.WriteLine("What is the name of the cat?");
            string i_cat_name = Console.ReadLine();
            i_cat.name = i_cat_name;
            Console.WriteLine($"The cat's name is {i_cat_name}!");

            //colour
            Console.WriteLine($"What colour is {i_cat_name}?");
            string i_cat_colour = Console.ReadLine();
            i_cat.colour = i_cat_colour;
            Console.WriteLine($"{i_cat_name} is {i_cat_colour}!");

            //height
            Console.WriteLine($"How tall is {i_cat_name} in centimeters?");
            string i_cat_height = Console.ReadLine();
            i_cat.height = double.Parse(i_cat_height);
            Console.WriteLine($"{i_cat_name} is {i_cat_height} years old!");

            //age
            Console.WriteLine($"How old is {i_cat_name} in human year?");
            string i_cat_age = Console.ReadLine();
            i_cat.age = double.Parse(i_cat_age);
            Console.WriteLine($"{i_cat_name} is {i_cat_age} years old!");

            Console.WriteLine("\nDOG");
            Console.WriteLine(i_dog.name.ToString());
            Console.WriteLine(i_dog.colour.ToString());
            Console.WriteLine(i_dog.height.ToString());
            Console.WriteLine(i_dog.age.ToString());
            i_dog.eat();
            Console.WriteLine(i_dog.cry());

            Console.WriteLine("\nCAT");
            Console.WriteLine(i_cat.name.ToString());
            Console.WriteLine(i_cat.colour.ToString());
            Console.WriteLine(i_cat.height.ToString());
            Console.WriteLine(i_cat.age.ToString());
            i_cat.eat();
            Console.WriteLine(i_cat.cry() + "\n\nAll animal names");

            for (int i = 0; i < all_animals.Count; i++)
            {
                if (all_animals[i] is Dog)
                {
                    Console.WriteLine(dog.name.ToString());
                }
                else if (all_animals[i] is Cat)
                {
                    Console.WriteLine(cat.name.ToString());
                }
                else if (all_animals[i] is iDog)
                {
                    Console.WriteLine(i_dog.name.ToString());
                }
                else
                {
                    Console.WriteLine(i_cat.name.ToString());
                }
            }
            
        }
    }
}
