using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern.Meal
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public int GetCost()
        {
            int sum = 0;
            foreach (var item in items)
            {
                sum += item.Price();
            }
            return sum;
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Item:{item.Name()}");
                Console.WriteLine($"Packing:{item.Packing().Pack()}");
                Console.WriteLine($"Price:{item.Price()}");
                Console.WriteLine($"===========================");
            }
        }
    }
}
