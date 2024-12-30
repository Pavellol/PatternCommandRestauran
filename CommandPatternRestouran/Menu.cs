using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRestouran
{
    internal class Menu
    {
        public List<string> RussianKitchen = new()
        {
            "Пельмени",
            "Макароны по флотски",
            "Борщ"
        };

        public List<string> ItalianKitchen = new()
        {
            "Паста",
            "Ризотто",
            "Сордини"
        };

        public List<string> GruzianKitchen = new()
        {
            "Хачапури",
            "Харчо",
            "Суп с курицей"
        };

        List<List<string>> AllMenu = new();

        public void ViewMenu()
        {
            AllMenu.Add(GruzianKitchen);
            AllMenu.Add(ItalianKitchen);
            AllMenu.Add(RussianKitchen);

            for (int i = 0; i < AllMenu.Count; i++)
            {
                foreach (var item in AllMenu[i])
                {
                    Console.WriteLine(item);
                }                
            }
        }
    }
}
