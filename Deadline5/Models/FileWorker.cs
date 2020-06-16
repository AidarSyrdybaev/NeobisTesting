using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadline5.Models
{
    public static class FileWorker
    {
        static string path ="../../Data.Json";
        static string path2 = "../../Money.json";

        public static void SaveInformation(Dictionary<Product, int> ProductsAndProductsCount)
        {
            List<ProductJsonModel> productJsonModels = ProductsAndProductsCount.Select(i => new ProductJsonModel(i.Key, i.Value)).ToList();
            string information = JsonConvert.SerializeObject(productJsonModels);
            File.WriteAllText(path, information);
        }

        public static Dictionary<Product, int> GetProductAndProductsCount()
        {   
            string information = File.ReadAllText(path);
            if (!string.IsNullOrEmpty(information))
            {
                var ProductJsonModels = JsonConvert.DeserializeObject<List<ProductJsonModel>>(information);
                var ProductAndProductsCount = new Dictionary<Product, int>();
                foreach (var model in ProductJsonModels)
                    ProductAndProductsCount.Add(model.GetProduct(), model.Count);
                return ProductAndProductsCount;
            }
            return new Dictionary<Product, int>();
            

        }

        public static void SaveMoney(int Money)
        {
            var moneyModel = new MoneyModel { Money = Money};
            string information = JsonConvert.SerializeObject(moneyModel);
            File.WriteAllText(path2, information);
        }

        public static int GetSavedMoney()
        {
            string information = File.ReadAllText(path2);
            if (!string.IsNullOrEmpty(information))
            {
                return JsonConvert.DeserializeObject<MoneyModel>(information).Money;
            }
            return 0;
        }
    }
}
