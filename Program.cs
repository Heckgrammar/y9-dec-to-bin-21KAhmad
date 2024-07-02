using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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
            Console.WriteLine("Enter a denary number between 0 and 225");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numberbase you want to convert to");
            int numberbase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberConversion(number, numberbase));
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
                K = K/numberbase;
                count++;
            }

            int[] conversion = new int[count];
            int index = count - 1;

            while (number > 0)
            {
                conversion[index] = number % numberbase;
                number = number/numberbase;
                index--;
            }

            string result = string.Join("", conversion);
            return result;
        }
    }
}
