using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRestouran
{
    public class Client
    {
        private string name;
        BusBoy busBoy;
        public Client(string name)
        {
            this.name = name;
        }

        public void Hello()
        {
            Console.WriteLine("Добрый день!\n Меня зоват " + name);
        }


        public void SayAboutNewZakaz()
        {
            Console.WriteLine("Я хочу сделать заказ!");
        }

        public void CreateZakaz(string zakaz)
        {
            busBoy.CreateZakaz(zakaz);
        }

    }
}
