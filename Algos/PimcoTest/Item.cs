using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class Item<T> where T: Food
    {
        public double Value;
        double Price;
        public IEnumerable<Food> Inventory { get; set; }

        public Item(double p)
        {
            Inventory = new List<Food>();
            Price = p;
        }

        public IEnumerable<T> GetItems<T>(double minPrice)
        {
            lock (this)
            {
                //return Inventory.Where(item => item.Price >= minPrice);
                return null;
                
            }
        }

    }

    public class Food
    {
        public double Price {get;set;}
    }
}
