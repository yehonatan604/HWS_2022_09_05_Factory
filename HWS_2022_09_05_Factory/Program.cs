using System;

namespace HWS_2022_09_05_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Costumer:
            Person costumer = new("Maor",35, 88, 1.78);

            //creating the correct creator from the factory by the
            //values of the costumer:
            DietFactory? dietFactory = DietFactory.ReturnCreator(costumer);

            //the dietfactory will return us a correct diet then:
            Diet? diet = dietFactory?.ReturnDiet();

            //print the menu of the correct diet:
            Console.WriteLine($"Costumer:\n{costumer}\n");
            Console.WriteLine($"{diet}\n");
            diet?.ReturnMenu()?.ForEach(MenuItem => Console.WriteLine(MenuItem));
        }
    }
}
