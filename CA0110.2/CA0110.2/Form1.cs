using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA0110._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void weightBox_TextChanged(object sender, EventArgs e)
        {

        }
        //-> svorio masyvas
        List<double> weightList = new List<double>();
        //-> ugio masyvas
        List<double> heightList = new List<double>();
        //-> vardu masyvas
        List<string> nameList = new List<string>();
        //->log masyvas
        List<int> logList = new List<int>();

        private void button2_Click(object sender, EventArgs e) //->mygtukas prideda i svoriu masyva
        {
            weightList.Add(double.Parse(weightBox.Text));
        }

        private void button3_Click(object sender, EventArgs e) //->mygtukas prideda ugiu masyva
        {
            heightList.Add(double.Parse(heightBox.Text));
        }

        private void button4_Click(object sender, EventArgs e) //->mygtukas prideda vardu masyva
        {
            nameList.Add(nameBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var weight = weightList[0];
            var height = heightList[0];
            var name = nameBox.Text;
            var kmi = weight / (height * height);
            if (kmi < 18.5)
            {
                MessageBox.Show("Your body mass is to low!");
            }
            else if (kmi > 30)
            {
                MessageBox.Show("Your body mass is to big!");
            }
            else if(kmi > 25 && kmi < 30)
            {
                MessageBox.Show("You have some excess body weight");
            }
            else
            {
                MessageBox.Show("Your body mass in good range of mass !");
            }
            richTextBox1.AppendText(kmi.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var log = logList[0];
            for (int i = 0; i < log; i++)
            {
                richTextBox2.AppendText($"{nameList[i]} weight : {weightList[i]} heigt : {heightList[i]}\n");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            logList.Add(int.Parse(numberOfLogs.Text));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            weightList.Clear();
            heightList.Clear();
        }
    }
}
