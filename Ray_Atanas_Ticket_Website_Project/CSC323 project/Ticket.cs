using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC323_project.Products;

namespace CSC323_project.Tickets
{
    public class Ticket 
    {
       
        string Type { set; get; }
        char Row { set; get; }
        int Column { set; get; }
        public string Name { get; set; }
        DateTime Time { set; get; }
        string Location { set; get; }
        string Band { set; get; }
        public double Unitprice { get; set; }

        public Product Product
        {
            get => default;
            set
            {
            }
        }

        public Product Product1
        {
            get => default;
            set
            {
            }
        }

        public Ticket(string _type, char _row, int _column, string _name, DateTime _time, string _location )
        {
            
            Type = _type;
            Row = _row;
            Column = _column;
            Name = _name;
            Time = _time;
            Location = _location;
           
        }
        public Ticket(string _type, string _name, double _price)
        {
            Type = _type;
            
            Name = _name;
           Unitprice  = _price;
        }
    }
}
