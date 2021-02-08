using System;

namespace FindSumOfPositiveElementsArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 1, 2, 3, -2, -4, 5, 6, -7, 8, 9, 10, -11, -12, 13 };
            int count = 0;
            int totalSum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0)
                    count++;
            }
            for (int i = 0; i < myArray.Length; i++) 
            {
                totalSum += myArray[i];
            }

            Console.WriteLine("Number of positive elements =  " + count);
            Console.WriteLine(new String('-',37));
            Console.WriteLine("Total sum of positive elements =  " + totalSum);
            Console.ReadKey();           //Number of positive elements =  9
                                         //-------------------------------------
                                        //Total sum of positive elements = 21
        }
    }
    
}
