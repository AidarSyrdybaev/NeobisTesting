using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadline5.Models
{
    public static class ProductFilterModel
    {
        public static List<Product> SortName(this List<Product> products, bool Check)
        {
            if (Check)
                return products.OrderBy(i => i.Name).ToList();
            return products;
        }

        public static List<Product> SortCategory(this List<Product> products, bool Check)
        {
            if (Check)
                return products.OrderBy(i => i.Category).ToList();
            return products;
        }

        public static List<Product> SortPrice(this List<Product> products, bool Check)
        {
            if (Check)
                return products.OrderBy(i => i.Price).ToList();
            return products;
        }
    }
}
