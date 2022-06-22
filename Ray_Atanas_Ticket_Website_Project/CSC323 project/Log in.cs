using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC323_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            string password = textBox4.Text;
            foreach(var user in Sign_up.usernum)
            {
                if(email == user.Email)
                {
                    if (password == user.Password)
                    {
                        MessageBox.Show("welcome", "sign in successful", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Password not valid!");
                    }
                }
                else
                {
                    MessageBox.Show("Email not valid!");
                }
            }
        }
    }
}
