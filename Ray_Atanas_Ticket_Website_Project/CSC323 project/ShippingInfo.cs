using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSC323_project.shipping
{
    public class Shipping 
    {
        public string Address { get; set; }
        public string Postal_code { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        List<Shipping> shippinginfo { get; set; }
        public Shipping(string _country, string _city, string _postal_code, string _address)
        {
            Country = _country;
            City = _city;
            Postal_code = _postal_code;
            Address = _address;

        }

    }
}
