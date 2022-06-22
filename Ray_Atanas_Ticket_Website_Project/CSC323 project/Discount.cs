using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC323_project.ShoppingCart;
namespace CSC323_project.Discounts
{
    class Discount
    {
        public virtual string Name { get; set; }
        public virtual string discountcode { get; set; }
        
           
       
        public virtual Shoppingcart applydiscountoncart(Shoppingcart b)
        {
            return b;//to be overriden
        }



        public Discount(string _code) {
            discountcode = _code;
        }
        public Discount(string _Name, string _code)
        {
            Name = _Name;
            discountcode = _code;
        }
    }
}
