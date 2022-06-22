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
    public partial class Complaint : Form
    {
        public Complaint()
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string complaint = (richTextBox1.Text).ToString();
            if (complaint == "")
            {
                MessageBox.Show("please you need to enter your complaint");
            }
            else
            {
                MessageBox.Show("Complaint has been sent thank you.");
            }
        }
    }
}
