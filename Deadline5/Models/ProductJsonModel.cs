using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Deadline5.Models
{
    public class ProductJsonModel
    {
        public ProductJsonModel()
        { 
        
        }
        public ProductJsonModel(Product product, int count)
        {
            ProductJsonInformation = JsonConvert.SerializeObject(product);
            Count = count;
        }


        public string ProductJsonInformation { get; set; }

        public int Count { get; set; }

        public Product GetProduct()
        {
            return JsonConvert.DeserializeObject<Product>(ProductJsonInformation);
        }
    }
}
