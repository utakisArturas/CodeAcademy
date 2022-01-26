using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (userNameText.Text == "Arturas" && passwordText.Text == "Utakis")
            {
                MessageBox.Show("Valid credentials");
            }


            else
            {
                MessageBox.Show("Wrong credentials");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = "Arturas";
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(name);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void avgGrade_Click(object sender, EventArgs e)
        {
            
            //int number = Int32.Parse(grade.Text);
            //int number1 = Int32.Parse(grade1.Text);
            //int number2 = Int32.Parse(grades2.Text);
            //double avgNumb = (number + number1 + number2) / 3;
            //string average = String.Format()
            //MessageBox.Show(avgNumb);

        }
    }
}
