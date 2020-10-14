using System;
using System.Runtime.CompilerServices;


namespace ConsoleApp2
{
    class Test
    {
        internal enum Wage
        {
            Small,
            Medium,
            Large
        }

        internal class Program
        {
            private static void Main(string[] args)
            {
                Console.WriteLine(CheckWage(Wage.Small));
                Console.WriteLine(CheckWage(Wage.Large));
                Console.WriteLine(CheckWage(Wage.Medium));
                Console.ReadKey();
            }

            public static string CheckWage(Wage wage)
            {
                switch (wage)
                {
                    case Wage.Small:
                        return "Small";
                    case Wage.Medium:
                        return "Medium";
                    case Wage.Large:
                        return "Large";
                    default:
                        return "no wage";

                }
            }
        }
    }
}

