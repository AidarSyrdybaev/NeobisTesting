using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadline5.Models
{
    public enum Category
    { 
        Food,
        Technic,
        Accessories
    }   
    public class Product
    {   
        public string Name { get; set; }

        public int Price { get; set; }

        public Category Category { get; set; }

        public Product(string _name, int _price, Category _category)
        {
            Name = _name;
            Price = _price;
            Category = _category;
        }
        

    }
}
