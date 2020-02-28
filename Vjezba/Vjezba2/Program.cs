using System;

namespace Vjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int testValue = Convert.ToInt32(long.MaxValue);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}