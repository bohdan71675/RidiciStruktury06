using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidiciStruktury06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n;
            n = rnd.Next(100, 31000);
            textBox1.Text = n.ToString();
            if (radioButton1.Checked == true)
            {
                int cifSoucet = 0;
                int cislo = int.Parse(textBox1.Text);

                while (cislo > 0)
                {
                    int cifra = cislo % 10; 
                    cifSoucet += cifra;
                    cislo /= 10;
                }
                MessageBox.Show("Ciferny soucet je " + cifSoucet);
            }
            else if (radioButton2.Checked == true)
            {
                int cifSoucet = 0;

                foreach (char znak in textBox1.Text)
                {
                    int x = znak - '0';
                    cifSoucet += x;
                }
                MessageBox.Show("Ciferny soucet je " + cifSoucet);
            }
            else if (radioButton3.Checked == true)
            {
                int cifSoucet = 0;
                int cislo = int.Parse(textBox1.Text);
                if (cislo != 0)
                {
                    do
                    {
                        int cifra = cislo % 10;
                        cifSoucet += cifra;
                        cislo /= 10;

                    } while (cislo > 0);
                }
                MessageBox.Show("Ciferny soucet je " + cifSoucet);
            }
        }
    }
}
