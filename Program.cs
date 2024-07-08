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

            string myString2 = "I'm ";
            string bigString = myString2 + myString;
            Console.WriteLine(bigString);

            //--------------------------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Enter a denary number");
            string number = Console.ReadLine();
            Console.WriteLine("Enter the numberbase you want to convert to");
            string numberbase = Console.ReadLine();
            bool validation = (numberValidation(number));
            if (validation != true)
            {
                int number = Convert.ToInt32(number);
                int numberbase = Convert.ToInt32(numberbase);
                Console.WriteLine(numberConversion(number, numberbase));
            }
            else
            {
                Console.WriteLine("Invalid Format");
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            int K = number;
            int count = 0;

            while (K > 0)
            {
                K = K / numberbase;
                count++;
            }
            int[] conversion = new int[count];
            int index = count - 1;

            while (number > 0)
            {
                conversion[index] = number % numberbase;
                number = number / numberbase;
                index--;
            }
            string result = string.Join("", conversion);
            return result;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------

        static bool numberValidation(int number)
        {
            bool valid = true;
            try
            {
                int result = int.Parse(number);
            }
            catch (FormatException)
            {
                valid = false;
                return valid;
            }
        }
    }
}
