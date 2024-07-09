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

            //----------------------------------------------------------------------------------------------------------------------------------------------------


            Console.WriteLine("Enter 1 to convert from binary to denary");
            Console.WriteLine("Enter 2 to convert from denary to binary");
            Console.WriteLine("Enter 3 to convert from hex to denary");
            Console.WriteLine("Enter 4 to convert from hex to binary");
            Console.WriteLine("Enter 5 to convert from binary to hex");
            int chosenConversion = Console.Read();
            if (chosenConversion == 1)
            {

            }
            if (chosenConversion == 2)
            {
                Console.WriteLine("Enter a denary number between 0 and 256");
                string number = (Console.ReadLine());
                int numberbase = 2;
                while (validation(number) = false)
                {
                    Console.WriteLine("Please enter a denery number grater than 0");
                    number = (Console.ReadLine());
                }
                number = Convert.ToInt32(number);
                Console.WriteLine(denaryToBinary(number, numberbase));
            }
            if (chosenConversion == 3)
            {

            }
            if (chosenConversion == 4)
            {

            }
            if (chosenConversion == 5)
            {



            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        //static void means the function will not return a value so it does not need a data type
        //...this function DOES return a value so the method must have a data type

        static bool validation(string number)
        {
            return false;
        }

        static string denaryToBinary(int number, int numberbase)
        {
            int K = number;
            int count = 0;
            //-----------------------------------------------------------------------------------------------------------------------------------------------
            //This code is necessary only if you have numbers larger than 8 bytes
            while (K > 0)
            {
                K = K / numberbase;
                count++;
            }
            int[] conversion = new int[count];
            int index = count - 1;
            //-------------------------------------------------------------------------------------------------------------------------------------------------
            while (number > 0)
            {
                conversion[index] = number % numberbase;
                number = number / numberbase;
                index--;
            }
            string result = string.Join("", conversion);
            return result;
        }

        static string binaryToDenary(string number)
        {
            return "";
        }
        
    }
}