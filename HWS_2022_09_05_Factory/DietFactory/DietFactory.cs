using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_09_05_Factory
{
    public abstract class DietFactory
    {
        //return diet creator:
        public static DietFactory? ReturnCreator(Person? Costumer)
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
                if ((Costumer.Age > 16 || Costumer.Age < 24) &&
                     (Costumer.Weight > 56 || Costumer.Weight < 70) &&
                     (Costumer.Height > 1.60))
                {
                    return new VegDietCreator();
                }
            }
            return null;
        }

        //reurn Diet
        public abstract Diet? ReturnDiet();
    }
}
