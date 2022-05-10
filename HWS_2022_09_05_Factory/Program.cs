using System;

namespace HWS_2022_09_05_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Costumer
            Person joe = new Costumer("Joe",36, 70, 1.7);

            //creating Nutritionist 
            Nutritionist? nutro = new("Dr. Shiquawa", joe);

            //creating the correct creator from the factory by the
            //values of the costumer:

            DietFactory? dietFactory = nutro.ReturnDietFactory();

            //the dietfactory will return us a correct diet then:
            Diet? diet = dietFactory?.ReturnDiet();

            //print the menu of the correct diet:
            Console.WriteLine(joe + ":\n");
            Console.WriteLine(diet + ":\n");
            diet?.ReturnMenu()?.ForEach(MenuItem => Console.WriteLine(MenuItem));
        }
    }
}
