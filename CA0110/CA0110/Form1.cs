using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA0110
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();

        }

        private void dateName_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString();
            var name = "Arturas";
            MessageBox.Show($"Hi {name}\n{date}");
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            var name = "Arturas";
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(name);
            }
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
 

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(numberTextBox.Text) % 2 == 0)
            {
                MessageBox.Show("Number is even");
            }
            else
            {
                MessageBox.Show("Number is odd");
            }

        }
        List<int> firstSem = new List<int>();
        List<int> secondSem = new List<int>();
        List<int> thirdSem = new List<int>();
        

        private void avgGrade_Click(object sender, EventArgs e)
        {
           
            foreach (var item in firstSem)
            {
                MessageBox.Show($"Grades are : {item} ");
              
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstSem.Add(int.Parse(firstSemester.Text));
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            secondSem.Add(int.Parse(secondSemester.Text));

        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            thirdSem.Add(int.Parse(thirdSemester.Text));
        }

        private void showGrade1_Click(object sender, EventArgs e)
        {
            foreach (var item in secondSem)
            {
                foreach.

            }
        }

        private void showGrade2_Click(object sender, EventArgs e)
        {
            foreach (var item in thirdSem)
            {
                MessageBox.Show($"Grades are : {item} ");

            }
        }

        private void showAverageButton_Click(object sender, EventArgs e)
        {
            double avg = firstSem.Average();
            MessageBox.Show($"{avg}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double avg = secondSem.Average();
            MessageBox.Show($"{avg}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double avg = thirdSem.Average();
            MessageBox.Show($"{avg}");
        }

        private void firstSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void secondSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void thirdSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
