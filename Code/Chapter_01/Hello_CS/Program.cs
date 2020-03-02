using System;

namespace Hello_CS
{
    class Program
    {
        private int Test_Integer = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");

            Program_End();
        }

        static void Program_End()
        {
            Console.WriteLine("\nPress any key to continue . . .");

            Console.ReadLine();
        }
    }
}
