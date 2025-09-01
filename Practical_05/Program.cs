using System;

namespace Practical_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Created an array of integers with 5 values
            int[] arr = { 10, 20, 30, 40, 50 };
            //Iterate the loop till 5
            for (int i = 0; i <= 5; i++)
            {
                {
                    //Putted the console.printline in the try block
                    //It is mentioned to do console.printline but it will give compile time error, so i had changed it to Console.WriteLine(arr[i]);
                    try
                    {
                        //Print each index of the array
                        Console.WriteLine(arr[i]);
                    }
                    //Catching IndexOutOfRangeException
                    catch (IndexOutOfRangeException ex)
                    {
                        //Under catch printed the exception message
                        Console.WriteLine($"Exception Message: {ex.Message}");
                    }
                    //In finally printed “This is finally block”
                    finally
                    {
                        Console.WriteLine("This is finally block");
                    }
                }
            }
        }
    }
}
