using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DV402.S1.L02C.Properties;

namespace _1DV402.S1.L02C
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Title and constants, as Diamond belt will never change it´s value
             */ 
            Console.Title = "Rita med asterisker - Nivå C";
            const byte maxBelt=79;

            /*
             * Method RenderDiamond that takes argument of type byte. Method ReadOddByte returns byte.
             */ 
            do
            {
                RenderDiamond(ReadOddByte(String.Format(Resources.ReadOddByte_Prompt,maxBelt)));
            } while (IsContinuing());

        }
        /*
         * IsContinuing Method, gives user the possibility to run program again,
         * or to close the application.
         */
        private static bool IsContinuing()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n");
            Console.WriteLine(Resources.Continue_Prompt);
            Console.Write("\n");
            Console.ResetColor();
            return Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
        /*
         * ReadOddByte, takes user input and tries to parse it to byte (there throws one possible exception).
         * Later, in if-condition I check if user inputInput is acceptable number for the program.
         */ 
        private static byte ReadOddByte(string prompt=null,byte maxValue=255)
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                byte correctInput;
                try{
                    correctInput=byte.Parse(userInput);
                    if (correctInput % 2 == 0 || correctInput > maxValue || correctInput < 1)
                    {
                        throw new Exception();
                    }
                    return correctInput;
                }
                catch
                {
                    Console.Write("\n");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Resources.Error_Message, maxValue);
                    Console.ResetColor();
                    Console.Write("\n");
                }
            }
        }

        /*
         * This method calls RenderRow method, maxCount times.
         * OBS:The number of rows is the same as the number of asterisks in diamond belt!!!!
         */
        private static void RenderDiamond(byte maxCount)
        {
            for(int i=0;i<=maxCount;i++)
            {
                RenderRow(maxCount, i);
            }
        }
        private static void RenderRow(int maxCount,int asteriskCount)
        {
            /*
             * This method writes one row.
             * First for-loop calculates number of empty spaces with help of only maxCount and asteriskCount.
             * (maxCount/2 - asteriskCount) has a negative value after it renders belt, and Math.Abs gives
             * the absolute value of any number.
             */
            for (int i = 0; i < Math.Abs(maxCount/2 - asteriskCount); i++)
            {
                Console.Write(" ");
            }
            /*
             * maxCount - (2 * (Math.Abs(maxCount/ 2 - asteriskCount))),
             * I multiply with 2 number of spaces, and the difference between macCount and doubled number of spaces
             * gives the number of asterisks.
             */
            for (int j = 0; j < maxCount - (2 * (Math.Abs(maxCount/ 2 - asteriskCount))); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
