using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC323_project.Products;
namespace CSC323_project.ShoppingCart
{
 public class Shoppingcart
    {
        internal object products;

        List<Product> lproduct { get; set; }

        

        public Product Product1
        {
            get => default;
            set
            {
            }
        }

        public Shoppingcart(List<Product>_products) {
            lproduct = _products;
        }
    }
}
