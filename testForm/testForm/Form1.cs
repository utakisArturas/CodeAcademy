using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
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

        private void nameTenTimes_Click(object sender, EventArgs e)
        {
            var name = "Arturas";
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(name);
            }
        }
    }
}
