using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            Console.WriteLine(numberConversion(12, 2));
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {

            //Console.WriteLine("Enter your denery number");
            //number = Console.Read();
            int K = number;

            int count = 0;
            while (K > 0)
            {
                K /= numberbase;
                count++;
            }
            int[] conversion = new int[count];

            int newNumber = 4;
            while (newNumber/numberbase != 0)
            {
                newNumber = number / numberbase;
                conversion[count] = number & 2;
                count = count - 1;
                number = newNumber;
            }
            string result = Convert.ToString(conversion);
            return result;
        }
    }
}
