using System;

namespace Advent_of_Code_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = GetArray();

            myArray[1] = 12;
            myArray[2] = 2;

            // [0,1,2,3] position 0 = 1 = add, 2 = multiply, 99 = end; 1 and 2 = postion of numbers to calculate. 3 = location to store.

            for(int i = 0; i < myArray.Length; i += 4)
            {
                if (myArray[i] == 99)
                    break;
                var valOne = myArray[i + 1];
                var valTwo = myArray[i + 2];
                var resultLocation = myArray[i + 3];
                if(myArray[i] == 1)
                {
                    myArray[resultLocation] = myArray[valOne] + myArray[valTwo];
                } 
                else if(myArray[i] == 2)
                {
                    myArray[resultLocation] = myArray[valOne] * myArray[valTwo];
                }
            }
            Console.WriteLine("Result is " + myArray[0]);

        }

        public static int[] GetArray()
        {
            return new int[] { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 13, 1, 19, 1, 19, 6, 23, 1, 23, 6, 27, 1, 13, 27, 31, 2, 13,
                31, 35, 1, 5, 35, 39, 2, 39, 13, 43, 1, 10, 43, 47, 2, 13, 47, 51, 1, 6, 51, 55, 2, 55, 13, 59, 1, 59, 10, 63, 1, 63, 10, 67,
                2, 10, 67, 71, 1, 6, 71, 75, 1, 10, 75, 79, 1, 79, 9, 83, 2, 83, 6, 87, 2, 87, 9, 91, 1, 5, 91, 95, 1, 6, 95, 99, 1, 99, 9, 103,
                2, 10, 103, 107, 1, 107, 6, 111, 2, 9, 111, 115, 1, 5, 115, 119, 1, 10, 119, 123, 1, 2, 123, 127, 1, 127, 6, 0, 99, 2, 14, 0, 0 };
        }
    }
}
