using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_09_05_Factory
{
    public class Nutritionist : Person
    {
        private Costumer? Costumer;
        public Nutritionist(string? name, Costumer? costumer)
        {
            Name = name;
            Proffession = nameof(Nutritionist);
            Costumer = costumer;
        }
        public DietFactory? ReturnDietFactory()
        {
            if (Costumer != null)
            {
                if ((Costumer.Age > 40 || Costumer.Age < 70) &&
                     (Costumer.Weight > 50 || Costumer.Weight < 80) &&
                     (Costumer.Height > 1.60))
                {
                    return new PaleoDietCreator();
                }
                if ((Costumer.Age > 40 || Costumer.Age < 60) &&
                     (Costumer.Weight > 50 || Costumer.Weight < 100) &&
                     (Costumer.Height > 1.60))
                {
                    return new EtkinsDietCreator();
                }
                if ((Age > 16 || Age < 24) &&
                     (Costumer.Weight > 56 || Costumer.Weight < 70) &&
                     (Costumer.Height > 1.60))
                {
                    return new VegDietCreator();
                }
            }
            return null;
        }
    }
}
