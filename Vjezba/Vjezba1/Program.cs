using System;

namespace Vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.Write("Unesite prvi broj: ");
            string num1 = Console.ReadLine();
            Console.Write("Unesite drugi broj: ");
            string num2 = Console.ReadLine();
            int result = 0;
            try
            {
                result = Int32.Parse(num1) / Int32.Parse(num2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            NumberParser parser = new NumberParser(result);
            parser.PrintAllFormats();
        }
    }
}