using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadline5.Models
{
    public class Shop
    {   
        public int Money { get; set; }
        public Dictionary<Product, int> ProductAndProductCount { get; set; }

        public Shop()
        {
            ProductAndProductCount = FileWorker.GetProductAndProductsCount();
            Money = FileWorker.GetSavedMoney();
            
        }

        public void ProductSell(Product product, int ProductSellCount)
        {
            if (ProductAndProductCount[product] > ProductSellCount)
            {
                Money += product.Price * ProductSellCount;
                ProductAndProductCount[product] -= ProductSellCount;
            }
            throw new Exception("Нехватает продуктов");
        }

        public void ProductBuy(Product product, int ProductBuyCount)
        {
            if (Money > product.Price * ProductBuyCount)
            {
                Money -= product.Price * ProductBuyCount;
                ProductAndProductCount[product] += ProductBuyCount;
            }
            else
            {
                throw new Exception("Нехватает денег");
            }
        }

        public void DeleteProduct(Product product)
        {
            ProductAndProductCount.Remove(product);
        }

        public void AddProduct(Product product)
        {
            ProductAndProductCount.Add(product, 0);
        }
    }
}
