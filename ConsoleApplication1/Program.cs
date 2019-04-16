using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // Function to divide a by b and 
        // return floor value it 
        static int divide(int dividend, int divisor)
        {

            // Calculate sign of divisor i.e., 
            // sign will be negative only iff 
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

            return sign * quotient;
        }

        public static void Main()
        {

            int a = 10;
            int b = 3;
            Console.WriteLine(divide(a, b));

            a = 43;
            b = -8;
            Console.WriteLine(divide(a, b));
        }
    }
}
