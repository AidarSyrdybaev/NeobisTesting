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

        public static List<Product> SearchName(this List<Product> products, string Name)
        {
            if (!string.IsNullOrWhiteSpace(Name))
                return products.Where(i => i.Name == Name).ToList();
            return products;
        }

        public static List<Product> SearchCategory(this List<Product> products, Category category)
        {
            if (category != Category.None)
                return products.Where(i => i.Category == category).ToList();
            return products;
        }

        public static List<Product> SearchPrice(this List<Product> products, int FromPrice, int ToPrice)
        {
            if (FromPrice != 0 || ToPrice != 0)
            {
                int fromPrice = FromPrice == 0 ? FromPrice : int.MinValue;
                int toPrice = ToPrice == 0 ? ToPrice : int.MaxValue;
                return products.Where(i => fromPrice < i.Price && i.Price < toPrice).ToList();
            }
            return products;
        }
    }
}
