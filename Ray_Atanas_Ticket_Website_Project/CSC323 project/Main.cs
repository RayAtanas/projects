using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSC323_project.Users;
using CSC323_project.Tickets;
using CSC323_project.Discounts;
using CSC323_project.ShoppingCart;
using CSC323_project.Discounts;
using CSC323_project.comments;
using CSC323_project.shipping;
using CSC323_project.delivery;
using CSC323_project.payment;
using static CSC323_project.Products.Product;

namespace CSC323_project
{
    public partial class Main : Form
    {

        string stdDetails = "{0,-20}{1,-30}{2,-50}";
        int selectedItemIndex = -1;
        string StdDetails2 = "{0,-20}{1,-50}";
        public  Main()
        {
            InitializeComponent();

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Main_Load(object sender, EventArgs e)
        {

            info.Items.Add(string.Format(stdDetails, "Product Name", "Price per unit", "Quantity"));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var dategnr = new DateTime(2021, 11, 13, 6, 10, 0);
            Ticket GNR = new Ticket("Concert", 'A', 10, "Guns and Roses", dategnr, "Beirut");
            Ticket Eagles = new Ticket("Concert", 'A', 15, "Eagles", dategnr, "Beirut");
            Ticket Scorpions = new Ticket("Concert", 'B', 20, "Scorpions", dategnr, "Beirut");
            Ticket BB = new Ticket("Concert", 'C', 10, "Bra", dategnr, "beirut");
            if (checkBox1.Checked)
                fillList1();
            else
            {
                listticket.Items.Clear();
                fillList2();
            }
        }

        private void fillList1()
        {
            if (checkBox1.Checked)
            {
                listticket.Items.Add("Guns and Roses");
                listticket.Items.Add("Eagles");
                listticket.Items.Add("Scorpions");
                listticket.Items.Add("Breaking Benjamin");
                listticket.Items.Add("George Michael");
            }
        }
        private void fillList2()
        {
            if (checkBox2.Checked)
            {
                listticket.Items.Add("The Godfather");
                listticket.Items.Add("Fast and Furious");
                listticket.Items.Add("Iron Man");
                listticket.Items.Add("The Dictator");
                listticket.Items.Add("The Founder");
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
                fillList2();
            else
            {
                listticket.Items.Clear();
                fillList1();
            }
        }





        private void Information_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Qte = textBox1.Text;
        }

     
        static double Final_price = 0;

        public void button1_Click(object sender, EventArgs e)
        {
            int Quantity = int.Parse(textBox1.Text);
            string ticketName = listticket.Items[listticket.SelectedIndex].ToString();

            foreach (var ticket in Form1.allTickets)
            {
                if (ticket.Name == ticketName)
                {
                    info.Items.Add(string.Format(stdDetails, ticketName, ticket.Unitprice, Quantity));

                    Final_price += ticket.Unitprice * Quantity;
                    Fprice.Text = Final_price.ToString();
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Discount discount1 = new Discount("123456");
            Discount discount2 = new Discount("654321");
            string Discountcode1 = "123456";
            string Discountcode2 = "654321";
            string userdiscountcode = textBox2.Text;
            if (userdiscountcode == Discountcode1) {
                int finaldiscount = int.Parse(Fprice.Text);
                int discountnumb = ((finaldiscount * 20) / 100);
                finaldiscount = finaldiscount - discountnumb;
                var textboxdiscount = textBox3.Text;
                MessageBox.Show(finaldiscount.ToString(), "Your Final price after the discount is: ");
            }
            if (userdiscountcode == Discountcode2)
            {
                int finaldiscount = int.Parse(Fprice.Text);
                int discountnumb = ((finaldiscount * 15) / 100);
                finaldiscount = finaldiscount - discountnumb;
                var textboxdiscount = textBox3.Text;
                MessageBox.Show((finaldiscount).ToString(), "Your Final price after the discount is: ");
            }
            if(userdiscountcode != Discountcode1 && userdiscountcode != Discountcode2)
            {
                MessageBox.Show("This discount code is invalid please try another one.");
            }
        }

        private void Fprice_TextChanged(object sender, EventArgs e)
        {

        }
        private static List<product> lproducts = new List<product> {
       
        
        };
        
        public void button2_Click(object sender, EventArgs e)
        {
            int Quantity = int.Parse(textBox1.Text);
            string ticketName = listticket.Items[listticket.SelectedIndex].ToString();
            foreach (var ticket in Form1.allTickets)
            {
                if (ticket.Name == ticketName)
                {
                    new product(ticketName, Quantity,ticket.Unitprice);
                    string message = string.Format("{0} was added to cart", ticket.Name);
                    
                    MessageBox.Show(message);
                }
                

               
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public static List<Comments> allcomments = new List<Comments>
        {
           new Comments("best product ever",DateTime.Now) ,
        new Comments("i would gladly recommend bying from this website", DateTime.Now),
        
        };
        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string scomment = richTextBox1.Text;
            Comments com = new Comments(scomment.ToString(), DateTime.Now);
            allcomments.Add(com);
            foreach(var comment in allcomments)
            {
                Commentbox.Items.Add(string.Format(StdDetails2, scomment, DateTime.Now));
            }
        }
        private static List<Shipping> shippinginf = new List<Shipping> {

   
};
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox1.Items.Add(Delivery_type.By_boat.ToString());
                comboBox1.Items.Add(Delivery_type.By_car.ToString());
                comboBox1.Items.Add(Delivery_type.By_Mail.ToString());
                comboBox1.Items.Add(Delivery_type.By_plane.ToString());
            }
            else
            {
                comboBox1.Items.Clear();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                MessageBox.Show("A QR code will be sent to your email.");
            }
        }
        public static List<Shipping> shippinginfo = new List<Shipping>
        {
            

        };
        public static List<Payment> paymentinfo = new List<Payment>
        {


        };
        private void button3_Click(object sender, EventArgs e)
        {
            string country = textBox4.Text;
            string city = textBox5.Text;
            string postalcode = textBox6.Text;
            string address = textBox7.Text;
            string paymentmethod = textBox8.Text;
            string creditcard = textBox9.Text;
            new Shipping(country,city,postalcode,address);
            new Payment(paymentmethod, creditcard);
            MessageBox.Show("Order has been placed check your email for more information");
        }

        private void ShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }
    }

}

               
    

