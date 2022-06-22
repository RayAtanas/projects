using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project.payment
{
   public class Payment
    {
        string Payment_method { get; set; }
        string Credit_card_info { get; set; }

        public Payment(string _paymentmethod, string _creditcard)
        {
            Payment_method = _paymentmethod;
            Credit_card_info = _creditcard;
        }
    }
}
