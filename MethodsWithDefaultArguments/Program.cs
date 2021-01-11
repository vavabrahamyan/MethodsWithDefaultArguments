using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithDefaultArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayRoundedDecimal(12.345678M, 3));

            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        public static string DisplayRoundedDecimal(decimal value,
                                          int numberOfSignificantDigits)
        {
            decimal roundedValue =
                           decimal.Round(value,
                                         numberOfSignificantDigits);

            string s = Convert.ToString(roundedValue);
            return s;
        }

        public static string DisplayRoundedDecimal(decimal value)
        {
            string s = DisplayRoundedDecimal(value, 2);
            return s;
        }
    }
}
