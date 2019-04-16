using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dividend = Convert.ToInt32(textBox1.Text);
                var divisor = Convert.ToInt32(textBox2.Text);

                if(divisor != 0)
                {
                    // Calculate sign of divisor i.e., 
                    // sign will be negative only if 
                    // either one of them is negative 
                    // otherwise it will be positive 
                    int sign = ((dividend < 0) ^
                            (divisor < 0)) ? -1 : 1;

                    // Update both divisor and 
                    // dividend positive 
                    dividend = Math.Abs(dividend);
                    divisor = Math.Abs(divisor);

                    // Initialize the quotient 
                    int quotient = 0;

                    while (dividend >= divisor)
                    {
                        dividend -= divisor;
                        ++quotient;
                    }

                    var quotients = sign * quotient;


                    // Handle negative values 
                    if (divisor < 0)
                        divisor = -divisor;
                    if (dividend < 0)
                        dividend = -dividend;

                    // Find the largest product of 'divisor' 
                    // that is smaller than or equal to 'num' 
                    int i = 1;
                    int product = 0;
                    while (product <= dividend)
                    {
                        product = divisor * i;
                        i++;
                    }

                    // return remainder 
                    var remainder = dividend - (product - divisor);





                    MessageBox.Show($"Quotient: {quotients}, Remainder: {remainder}", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show($"An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }
    }
}
