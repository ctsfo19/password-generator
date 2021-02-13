using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "your password will appear here";
            numericUpDown1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length;
            string password ="";
            int low=48;
            int hi=126;
            try
            {
                length = Convert.ToInt32(numericUpDown1.Value);
                Random rnd = new Random();                
                for(int i=0; i<length; i++)
                {
                    int temp = rnd.Next(low, hi);
                    password += Convert.ToChar(temp);
                }
                textBox1.Text = password;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://users.tryton.vlo.gda.pl/s10");
        }
    }
}
