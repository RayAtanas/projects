using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project.Users.Custumor
{
  public  class Costumer:User
    {
        string credit_cart_info;
        string credit_card_pin;
        List<Costumer> Shopping_cart;
       public Costumer(string userid, string email, string password, string firstname, string lastname, string address,string credit_info,string credit_pin) : base(userid, email, password, firstname, lastname, address)
        {
            credit_cart_info = credit_info;
            credit_card_pin = credit_pin;
            
        }
      public  Costumer(string userid, string email, string password, string firstname, string lastname, string address) : base(userid, email, password, firstname, lastname, address)
        {

        }
    }
}
