using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primitivetypes
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {
            // Declare an array of int type
            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            // Declare an array of double type
            double[] doubleArray = new double[5] { 1.1, 2.2, 3.3, 4.4, 5.5 };

            // Declare an array of string type
            string[] stringArray = new string[5] { "One", "Two", "Three", "Four", "Five" };

            // Execute expressions on the arrays
            Console.WriteLine("Sum of intArray: " + intArray.Sum());
            Console.WriteLine("Average of doubleArray: " + doubleArray.Average());
            Console.WriteLine("Longest string in stringArray: " + stringArray.OrderByDescending(s => s.Length).First());
            Console.ReadLine();
        }
    }
} 
       
    
      
