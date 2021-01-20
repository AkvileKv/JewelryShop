using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Bag
    {
        public List<Item> items = new List<Item>();

        public double totalPrice;
        public double vatPrice;

        public void AddItem(Item item)
        {
            items.Add(item);
            totalPrice += item.Price;
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
            totalPrice -= item.Price;
        }

        public void calculateVatPrice(Item item)
        {
            vatPrice = totalPrice * 0.21 + totalPrice;
        }

    }
}
