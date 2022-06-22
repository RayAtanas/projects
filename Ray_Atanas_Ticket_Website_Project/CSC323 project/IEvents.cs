using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project
{
    interface IEvents
    {
        int eventId { get; set; }
        string eventPeriod { get; set; }
    }
}
