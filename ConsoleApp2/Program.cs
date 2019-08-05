// C# program to segregate even 
// and odd elements of array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GFG
{
    static void segregateEvenOdd(int[] arr)
    {
        /* Initialize left and right indexes */
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            /* Increment left index while we see 0 at left */
            while (arr[left] % 2 == 0 && left < right)
                left++;

            /* Decrement right index while we see 1 at right */
            while (arr[right] % 2 == 1 && left < right)
                right--;

            if (left < right)
            {
                /* Swap arr[left] and arr[right]*/
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
    }

    /* Driver program to test above functions */
    public static void Main()
    {
        //Input Array
        int[] arr = { 3, -3, 0, 1, 2, 6, 7, -8, -9, 9, 7, 5, 3, 1, 2, 9, 3, 4, 5, 6, 5, 7, -4, 1, -2, 3, 5, 6, 1, 4 };

        //Even and Odd number result
        //4, 6, 0, -2, 2, -4, -8, 6, 4, 2
        //5,3,1,7,9,3,9,5,-9,5,7,7,1,1,3,5,-3,1,3
        segregateEvenOdd(arr);
        {
            Console.Write("Array after segregation: ");

                for (int i = 0; i < arr.Length; i++)
                Console.Write("[" + arr[i] + "]");
            Console.WriteLine("Results: ");

            int temp1 = 0;
            int[] arr2 = new int[] { 5, 3, 1, 7, 9, 3, 9, 5, -9, 5, 7, 7, 1, 1, 3, 5, -3, 1, 3 };
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        temp1 = arr2[j];
                        arr2[j] = arr2[i];
                        arr2[i] = temp1;
                    }
                }
                Console.WriteLine("Odd numbers: " + "[" + arr2[i] + "]");
               
            }
            int temp = 0;
            int[] arr1 = new int[] { 4, 6, 0, -2, 2, -4, -8, 6, 4, 2 };
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[i];
                        arr1[i] = temp;
                    }
                }
                Console.WriteLine("Even numbers: " + "[" + arr1[i] + "]");
            }
            Console.ReadKey();
        }
    }
}



