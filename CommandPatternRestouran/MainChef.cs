using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRestouran
{
    internal class MainChef
    {
        Menu menu;
        public MainChef() { }
            
        public void GetZakaz(string zakaz)
        {

        }

        public void SearchInMenu(string search)
        {
            if (menu.RussianKitchen.Contains(search))
            {

            }
            else if (menu.ItalianKitchen.Contains(search))
            {

            }
            else if (menu.GruzianKitchen.Contains(search))
            {

            }
        }
    }
}
