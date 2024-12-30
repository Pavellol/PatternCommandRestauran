using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRestouran.Command
{
    internal class RussianChef
    {
        private string name;

        RussianChef(string name) 
        {
            this.name = name;                 
        }
        public void CoockingZakaz(string zakaz) 
        { 
            Console.WriteLine(name + " готовит " + zakaz); 
        }
    }
}
