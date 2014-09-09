using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {

            //"Outer" loop börjar ny rad och nestlad for-satsen skriver en viss antal asterisker
            for (int rawNumber = 0; rawNumber < 26; rawNumber++)
            {

                // Udda rad börjar med ett mellanslag. Om jag vill att udda börjar utan mellanslaget, då använder jag !=0
                if (rawNumber % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                
                
                for (int asteriskNumber = 0; asteriskNumber < 39; asteriskNumber++)
                {

                    // Här avgjörs vilken färg ska ha en rad
                    switch (rawNumber % 3)
                    {
                        case 1:
                            Console.ForegroundColor=ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write("* ");
                        
                }
                Console.WriteLine();
            }
            
        }
    }
}
