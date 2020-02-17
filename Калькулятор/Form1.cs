using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        Class1 C = new Class1();
        public Form1()
        {
            InitializeComponent();
           
        }


        

        private void plus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Save(Convert.ToDouble(textBox1.Text));

                plus.Enabled = false;

               textBox1.Clear();
            }
        }

        private void lol_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void theare_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void eith8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            if (!plus.Enabled)
            {
                textBox1.Text = C.Plus(Convert.ToDouble(textBox1.Text)).ToString();
                plus.Enabled = true;
            }
            if (!minus.Enabled)
            {
                textBox1.Text = C.Minus(Convert.ToDouble(textBox1.Text)).ToString();
                minus.Enabled = true;
            }
            if (!umnoj.Enabled)
            {
                textBox1.Text = C.Umnozhat(Convert.ToDouble(textBox1.Text)).ToString();
                umnoj.Enabled = true;
            }

            if (!del.Enabled)
            {
                textBox1.Text = C.Divide(Convert.ToDouble(textBox1.Text)).ToString();
                del.Enabled = true;
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Save(Convert.ToDouble(textBox1.Text));

               minus.Enabled = false;

                textBox1.Clear();
            }
        }

        private void umnoj_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Save(Convert.ToDouble(textBox1.Text));

                umnoj.Enabled = false;

                textBox1.Clear();
            }
        }
        private bool CanPress()
        {
            if (!umnoj.Enabled)
                return false;

            if (!del.Enabled)
                return false;

            if (!plus.Enabled)
                return false;

            if (!minus.Enabled)
                return false;

            return true;
            
            
            
        {

        }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Save(Convert.ToDouble(textBox1.Text));

                del.Enabled = false;

                textBox1.Clear();
            }
        }
        private void FreeButtons()
        {
            umnoj.Enabled = true;
            del.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
        }
    }
}
