using Animals;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType;
            List<Animal> animals = new List<Animal>();

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] addInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = addInfo[0];
                int age = int.Parse(addInfo[1]);
                string gender = addInfo[2];

                try
                {
                    switch (animalType)
                    {
                        case "Cat":
                            animals.Add(new Cat(name, age, gender));
                            break;
                        case "Dog":
                            animals.Add(new Dog(name, age, gender));
                            break;
                        case "Frog":
                            animals.Add(new Frog(name, age, gender));
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message); // Print the error message
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                animal.ProduceSound();
            }
        }
    }
}


