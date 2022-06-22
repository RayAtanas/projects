using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project.delivery
{
    class Delivery
    {
        bool Type { get; set; }
        DateTime Time_needed { get; set; }

       

        public shipping.Shipping Shipping
        {
            get => default;
            set
            {
            }
        }

       
        public Delivery(bool _type,DateTime _timeneeded){
            Type = _type;
            Time_needed = _timeneeded;
        
        }
    }
    enum Delivery_type
    {
        By_car,
        By_boat,
        By_Mail,
        By_plane

    }
}
