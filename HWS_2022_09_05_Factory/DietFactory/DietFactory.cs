using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_09_05_Factory
{
    public abstract class DietFactory
    {
        public abstract Diet? ReturnDiet();
    }
}
