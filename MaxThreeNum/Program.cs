using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThreeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -4, 3, -6, 7, 0 };
            //int[] arr = { 2, -20, -2147483644, 4, 2147483647, 2147483646, 2300, -2147483648 };

            int temp;

            for(int i = 0; i< arr.Length; i++)
            {
                for(int j=i + 1; j<arr.Length; j++)
                {
                    if(arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            int counter = 0;
            for(int i= 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    counter++;
                else
                    break;
            }
            int[] res = new int[3];

            if (counter >= 2)
            {
                if(arr[0] * arr[1] * arr[arr.Length - 1] > arr[arr.Length - 1] * arr[arr.Length - 2] * arr[arr.Length - 3])
                {
                    res[0] = arr[0];
                    res[1] = arr[1];
                    res[2] = arr[arr.Length-1];
                }
                else
                {
                    res[0] = arr[arr.Length - 1];
                    res[1] = arr[arr.Length - 2];
                    res[2] = arr[arr.Length - 3];
                }
            }
            else
            {
                res[0] = arr[arr.Length - 1];
                res[1] = arr[arr.Length - 2];
                res[2] = arr[arr.Length - 3];
            }

        }
    }
}