using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Details { get; set; }  
        public double Price { get; set; }
        public int CategoryID { get; set; }

        public string ShowMenu //parodys preke
        {
            get
            {
                return $"{Name}, Price: {Price}Eur, Details: {Details}";
            }
        }

        public string ShowNameAndPrice
        {
            get
            {
                return $"{Name}, Price: {Price}Eur, ";
            }
        }
    }
}
