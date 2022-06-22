using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSC323_project.christmas;
using CSC323_project.Tickets;
namespace CSC323_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Ticket> allTickets = new List<Ticket>
        {
            new Ticket("Concert","Guns and Roses",7),
            new Ticket("Concert","Eagles",6),
            new Ticket("Concert","Scorpions",9),
            new Ticket("Concert","Breaking Benjamin",11),
            new Ticket("Concert","George Michael",10),
            new Ticket("Movie","The Godfather",7),
            new Ticket("Movie","Fast and Furious",6),
            new Ticket("Movie","Iron Man",9),
            new Ticket("Movie","The Dictator",11),
            new Ticket("Movie","The Founder",10),
        };

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            Login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up signup = new Sign_up();
            signup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        DateTime eventdate = DateTime.Now;
            int month = eventdate.Month;
            if(month == 12)
            {
                ChristmasEvent a = new ChristmasEvent(1, "Christmas");
                a.christmasSales();
            }
            if(month == 4)
            {
                EasterEvent a = new EasterEvent(2, "Easter");
                a.easterSales();
            }
            Main main = new Main();
            main.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complaint complaint = new Complaint();
            complaint.ShowDialog();
        }
    }
}
