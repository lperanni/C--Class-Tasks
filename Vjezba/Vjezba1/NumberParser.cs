using System;
using System.Globalization;

namespace Vjezba1
{
    public class NumberParser
    {
        private int Num { get; set; } = 0;
        public NumberParser(int num)
        {
            this.Num = num;
        }
        public NumberParser(){}
        public void PrintAllFormats()
        {
           
                Console.WriteLine("Currency format is: " + Num.ToString(("C3"), CultureInfo.CurrentCulture));
                Console.WriteLine("Integer format is: " + Num);
                Console.WriteLine("Scientific format is: " + Num.ToString("E", CultureInfo.CurrentCulture));
                Console.WriteLine("Fixed-point notation is: " + Num.ToString("F3",CultureInfo.InvariantCulture));
                Console.WriteLine("General format is: " + Num.ToString("G",CultureInfo.InvariantCulture));
                Console.WriteLine("Number format is: " + Num.ToString("N",CultureInfo.InvariantCulture));
                Console.WriteLine("Hexadecimal format is: " + Num.ToString("X",CultureInfo.InvariantCulture));
                
        }
    }
}