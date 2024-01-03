using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class MergeSort
    {
        public static void Solve(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int middle = (left + right)/2;

                // sorted the first part
                Solve(arr, left, middle);
                
                // sorted the second part
                Solve(arr, middle + 1, right);

                // combine the two parts
                Merge(arr, left, middle, right);

            }

        }

        private static void Merge(int[] arr, int left, int middle, int rigth)
        {
            int n1 = middle - left + 1;
            int n2 = rigth - middle;

            // create temporary array
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            //copy the temporary array's data
            for(int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[middle + 1 + j];

            // initial subarray indices
            int iIndex = 0, jIndex = 0;

            // Initial index of the combined array

            int k = left;

            // Merge temporary arrays back into arr[left..right]
            while(iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    arr[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    arr[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            //  Copy the remaining elements of leftArray (if any)
            while (iIndex < n1)
            {
                arr[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            // Copy the remaining elements of rightArray (if any)
            while (jIndex < n2)
            {
                arr[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }
    }
}
