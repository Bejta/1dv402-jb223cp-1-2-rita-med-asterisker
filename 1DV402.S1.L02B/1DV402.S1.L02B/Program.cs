using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L02B
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Title = "Rita med asterisker -nivå B";
                RenderTriangel(ReadOddByte());

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nTryck tangent för att fortsätta - Esc avslutar.");
                Console.WriteLine("\n");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        static byte ReadOddByte()
        {
            while (true)
            {
                Console.Write("Ange det udda antalet asterisker <max 79> i triangelns bas: ");
                try
                {
                    byte triangelBase = byte.Parse(Console.ReadLine());
                    if (triangelBase > 79 || triangelBase < 1 || (triangelBase % 2) == 0)
                    {
                        throw new OverflowException();
                    }
                    return triangelBase;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("\nFEL! Det inmatade värdet kan inte tolkas som ett tal.\n\n");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("\nFEL! Det inmatade värdet är inte ett udda heltal mellan 1 och 79.\n\n");
                    Console.ResetColor();
                }
            }
        }
        static void RenderTriangel(byte col)
        {
            //Avgör hur många rader har triangeln
            for (int rows = 0; rows <= (col / 2); rows++)
            {
                for (int i = 0; i < ((col / 2) - rows); i++)
                {
                    Console.Write(" ");
                }
                for (int numberOfStars = 1; numberOfStars < (2 * rows + 2); numberOfStars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
