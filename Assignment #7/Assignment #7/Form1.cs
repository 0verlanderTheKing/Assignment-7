using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void milesTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gallonsTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mpgLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int miles;
            int gallons;
            int MPG;

            miles = int.Parse(milesTextBox.Text);
            gallons = int.Parse(gallonsTextBox.Text);
            MPG = miles / gallons;
            mpgLabel.Text = MPG.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
