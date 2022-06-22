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
using CSC323_project.Users.Custumor;
namespace CSC323_project
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
            
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
         
        }
        public static List<Costumer> usernum = new List<Costumer>()
        {
            new Costumer("1234","Ray","rayA","Ray","Atanas","Lebanon")
            
        };

        private void button1_Click(object sender, EventArgs e)
        {
            
            string First_name = textBox1.Text;
            string last_name = textBox2.Text;
            string Email = textBox3.Text;
            string Password = textBox4.Text;
            string CPassword = textBox5.Text;
            string Address = textBox6.Text;
            Random num = new Random();
            string Id = "20201" + num.ToString();
            if (Password != CPassword)
            {
                _ = MessageBox.Show("Password and confirmation don't match");
            }

            else
            {
                MessageBox.Show("Welcome to our family!");
            }
            Costumer nuser = new    Costumer(Id,textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text,textBox6.Text);
            usernum.Add(nuser);
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public User User
        {
            get => default;
            set
            {
            }
        }

        public User User1
        {
            get => default;
            set
            {
            }
        }

        public User User2
        {
            get => default;
            set
            {
            }
        }
    }
}
