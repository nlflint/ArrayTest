using System;

namespace ArrayTest
{
    class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        private static void Main()
        {
            //Declare array
            int[] arrayOfTen = new int[10];

            //Loop through array and insert values
            for (int value = 1; value <= 10; value++)
            {
                int arrayIndex = value - 1;
                arrayOfTen[arrayIndex] = value;
            }

            //Call HelperFunction
            int sum = SumArray(arrayOfTen);

            //Write value returned from helper function
            Console.WriteLine("Array sum: " + sum);
        }

        /// <summary>
        /// Helper Function
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Sum of the values in the array</returns>
        static int SumArray(int[] array)
        {
            //Declare variables
            int arrayLength = array.Length;
            int workingSum = 0;
            
            //Loop through array and sum values
            for (int arrayIndex = 0; arrayIndex < arrayLength; arrayIndex++)
            {
                workingSum += array[arrayIndex];
            }

            return workingSum;
        }
    }
}
