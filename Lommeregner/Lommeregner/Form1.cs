using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {

        int tal1 = 0;
        int tal2 = 0;

        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(  );
            MessageBox.Show("Hej, davs!");
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            
            textBoxDisplay.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // husk at plus er operatoren
            op = "+";
            // gem tallet i tal1
            tal1 = Convert.ToInt32(textBoxDisplay.Text);
            textBoxDisplay.Clear();
        }

        private void buttonLigMed_Click(object sender, EventArgs e)
        {
            tal2 = Convert.ToInt32(textBoxDisplay.Text);
            if (op == "+")
            {
                textBoxDisplay.Text = (tal1 + tal2).ToString();
            }
        }
    }
}
