using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC323_project.Users;
using CSC323_project.ShoppingCart;
using CSC323_project.Tickets;
namespace CSC323_project.Products
{
   public class Product 
    {
        internal int unitprice;

        internal Shoppingcart Shoppingcart
        {
            get => default;
            set
            {
            }
        }

        public Ticket Ticket
        {
            get => default;
            set
            {
            }
        }

        public static implicit operator Product(product v)
        {
            throw new NotImplementedException();
        }

        public  class product
        {
            public string Productid { get; set; }
            public string Productname { get; set; }
            public string Description { get; set; }
            public double Unitprice { get; set; }
            public int Productquantity { get; set; } = 1;
           
            public List<product> lproducts;


            public product( string _productname, double _unitprice)
            {
                Productname = _productname;
                Unitprice = _unitprice;      
            }
            public product(string _productname, int _productquantity,double _unitprice)
            {
                Productquantity = _productquantity;
                Productname = _productname;
                Unitprice = _unitprice;
            }
            public product( string _productname, int _unitprice, string _description)
            {
               
                Productname = _productname;
                Unitprice = _unitprice;
                Description = _description;
                
            }
            public void editproductinfo( string _name, int _price, string _description)
            {
              
                Productname = _name;
                Unitprice = _price;
                Description = _description;
              

            }
            


            public virtual string printinf()
            {
                StringBuilder a = new StringBuilder();

                a.Append($" productname={Productname } unitprice={Unitprice} quantity={Productquantity}");
                a.AppendLine();
                a.Append($"description={Description}")
                    .AppendLine();
                return a.ToString();

            }

            public static implicit operator product(Product v)
            {
                throw new NotImplementedException();
            }
        }

    }
    }



