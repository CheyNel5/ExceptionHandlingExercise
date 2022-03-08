using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            // Create a list called numbers that will hold integers
            var numbers = new List<int>();
            // Create an string variable with an empty string initializer - name it str
            var str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);

                } catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
                finally
                {
                    Console.WriteLine(numbers);
                }
            }

             foreach (var num in numbers)
            {
               Console.WriteLine(num);
            }
        }
    }
}
