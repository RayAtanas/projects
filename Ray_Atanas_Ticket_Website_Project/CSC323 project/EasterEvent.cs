using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC323_project
{
    class EasterEvent: IEasterEvent
    {
        public int eventId { get; set; }
        public string eventPeriod { get; set; }
        public void easterSales()
        {
            MessageBox.Show($"It's {eventPeriod}, so Easter is here, you will get 50% discounts on all tickets!");
            foreach (var ticket in Form1.allTickets)
            {
                ticket.Unitprice = ticket.Unitprice - (ticket.Unitprice * 0.5);
            }
        }
        public EasterEvent(int _eventid, string _eventperiod)
        {
            eventId = _eventid;
            eventPeriod = _eventperiod;
        }
    }
}
