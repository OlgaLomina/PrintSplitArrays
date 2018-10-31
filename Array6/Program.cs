using System;
/*Given an array of numbers, split the array into two 
 * where one array contains the sum of n-1 numbers and 
 * the other array with all the n-1 elements.
 * */
namespace Array6
{
    class Program
    {
        /* { 1, 4, 8, 21, 3, 2, 3 } -> { 1, 4, 8, 3, 2, 3 } { 21 }*/

        //static int searchPoint(int[] arr, int size)
        //{
        //    int i;
        //    int sum = 0, sum_right = 0;

        //    for (i=0; i<size; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    for (i=size-1; i>= 0; i--)
        //    {
        //        sum_right += arr[i];
        //        sum -= arr[i];
        //        if (sum == sum_right)
        //            return i;
        //    }
        //    return -1;
        //}

        //static void printSplitArrays(int[] arr, int size)
        //{
        //    int point = searchPoint(arr, size);
        //    if (point == -1 || point == size)
        //    {
        //        Console.WriteLine("Not found");
        //        return;
        //    }
        //    for (int i=0; i<size; i++)
        //    {
        //        if (i == point)
        //            Console.WriteLine(" ");
        //        Console.Write(arr[i] + "  ");
        //    }
        //}

        //static void printSplitArrays(int[] arr, int size)
        //{
        //    if (size <= 1)
        //    {
        //        Console.WriteLine("Not possible to split, there is not enough elemements");
        //        return;
        //    }
        //    int i;
        //    int point = 0;
        //    int sum = 0, sum_right = 0;
        //    for (i = 0; i < size; i++)
        //         sum += arr[i];
        //    for (i = size - 1; i >= 0; i--)
        //    {
        //        sum_right += arr[i];
        //        sum -= arr[i];
        //        if (sum == sum_right)
        //        {
        //            point = i;
        //            break;
        //        }
        //    }
        //    if (point == 0)
        //    {
        //        Console.WriteLine("Not possible to split");
        //        return;
        //    }
        //    for (i = 0; i < size; i++)
        //    {
        //        if (i == point)
        //            Console.WriteLine(" ");
        //        Console.Write(arr[i] + "  ");
        //    }
        //}

        static void printSplitArrays(int[] arr, int size)
        {
            if (size <= 1)
            {
                Console.WriteLine("Not possible to split, there is not enough elemements");
                return;
            }
            int i;
            int point = 0, sum = 0, imax = 0;
            for (i = 0; i < size; i++)
            {
                sum += arr[i];
                //we are looking for max element
                if (arr[i] > imax)
                {
                    imax = arr[i];
                    point = i;
                }
            }
            //if the element was found where sum of n-1 elements is equal this element, so (sum-imax) == imax

            if ((sum-imax) != imax)
                //the element was not found
                point = 0; 

            if (point == 0)
            {
                Console.WriteLine("Not possible to split. A element did not find.");
                return;
            }
            for (i = 0; i < size; i++)
            {
                if (i != point)
                    Console.Write(arr[i] + "  ");
            }
            //print max element
            Console.WriteLine(" ");
            Console.Write(arr[point] + "  ");
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 8, 21, 3, 2, 3 };
            //int[] arr = { 1, 4, 8, 3, 2, 3, 5 };
            int n = arr.Length;
            printSplitArrays(arr, n);
            
        }
    }
}
