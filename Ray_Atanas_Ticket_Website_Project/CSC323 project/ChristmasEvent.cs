using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC323_project.christmas
{
   public class ChristmasEvent: IChristmasEvent
    {
        public int eventId { get; set; }
        public string eventPeriod { get; set; }
        public void christmasSales()
        {
            MessageBox.Show($"It's {eventPeriod}, so Christmas is here, you will get 25% discounts on all tickets!");
            foreach (var ticket in Form1.allTickets)
            {
                ticket.Unitprice = ticket.Unitprice - (ticket.Unitprice * 0.25);
            }
        }
        public ChristmasEvent(int _eventid,string _eventperiod)
        {
            eventId = _eventid;
            eventPeriod = _eventperiod;
        }
    }
}
