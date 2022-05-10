using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_09_05_Factory
{
    public abstract class Diet
    {
        //Properties
        private protected string? Name { get; set; } 
        private protected List<string>? Menu { get; set; } // Diet Menu

        //Methods
        public virtual List<string>? ReturnMenu() // virtual method to return the Diet Menu
        {
            return Menu;
        }
        //ovveriding ToString to print Name
        public override string? ToString()
        {
            return Name;
        }
    }
}
