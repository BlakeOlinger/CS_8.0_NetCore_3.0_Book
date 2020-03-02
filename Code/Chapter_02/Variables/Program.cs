using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var Height_In_Meters = 1.88;

            Console.WriteLine
            (
                $"The variable {nameof(Height_In_Meters)} has the" +
                $" value {Height_In_Meters}."
            );


            var Path = @"C:\Users\A_User\Desktop\Text_File.txt";

            Console.WriteLine
            (
                $"\nThe file path is: {Path}"
            );


            Program_End();
        }

        static void Program_End() {
            Console.WriteLine
            (
                "\nPress any key to continue . . ."
            );

            Console.ReadLine();
        }
    }
}
