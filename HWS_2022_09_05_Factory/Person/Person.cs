using System.Text.Json;

namespace HWS_2022_09_05_Factory
{
    public class Person
    {
        //Properties
        public virtual string? Name { get; set; }
        public virtual int Age { get; set; }
        public virtual double Weight { get; set; }
        public virtual double Height { get; set; }

        //Full Constructor
        public Person(string? name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        //Overriding ToString to return person details
        public override string ToString()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
