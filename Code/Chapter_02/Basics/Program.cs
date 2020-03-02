using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.DataSet Data_Set;
            System.Net.Http.HttpClient Http_Client;

            /*
            Console.WriteLine
            (
                "Temperature on {0:D} is {1}C.",
                DateTime.Today,
                23.4
            );
            */

            foreach
            (
                var Referenced_Assembly in Assembly
                .GetEntryAssembly()
                .GetReferencedAssemblies()
            ) {
                var Loaded_Assembly = Assembly.Load
                    (
                        new AssemblyName
                        (
                            Referenced_Assembly
                            .FullName
                        )
                    );

                var Method_Count = 0;

                foreach
                (
                    var Type in Loaded_Assembly.
                        DefinedTypes
                ) {
                    Method_Count += Type.GetMethods().Count();
                }

                Console.WriteLine
                (
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: Loaded_Assembly.DefinedTypes.Count(),
                    arg1: Method_Count,
                    arg2: Referenced_Assembly.Name
                );
            }

            Program_End();
        }

        static void Program_End()
        {
            Console.WriteLine
            (
                "\nPress any key to continue . . ."
            );

            Console.ReadLine();
        }
    }
}
