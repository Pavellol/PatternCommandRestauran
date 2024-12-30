using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRestouran
{
    public class BusBoy
    {
        private string name;
        Menu menu = new();
        MainChef mainChef;

        public BusBoy(string name) 
        {
            this.name = name;
        }
        
        public void Hello()
        {
            Console.WriteLine("Добрый день! Меня зовут " + name);
            Console.WriteLine("Добро пожаловать, чем я могу вам помочь?");
        }

        public void ViewMenu()
        {
            Console.WriteLine("Меню состоит из:");
            menu.ViewMenu();
        }
        public void CreateZakaz(string zakaz)
        {
            mainChef.GetZakaz(zakaz);
        }
    }
}
