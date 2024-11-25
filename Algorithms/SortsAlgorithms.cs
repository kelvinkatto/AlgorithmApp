using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// the code below have been obtained from the website called https://learn.microsoft.com/ and being modified to be used in this application
//  complete url to the code 
//https://learn.microsoft.com/en-us/answers/questions/1259438/c-sorting-algorithms-implementation


namespace Algorithms
{
    // Define a delegate that matches the signature of sorting methods
    public delegate void SortingDelegate(int[] array);
    public class SortsAlgorithms
    {

        //method to create an Insertion sort method
        public static void InsertionSort(int[] array)
        {
            if (array == null)// check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of the array that are greater than the key
                // one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
           
        }

    



        //Selection sort Method
        public static void SelectionSort(int[] array)
        {
            if (array == null) // check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the index of the minimum element in the remaining unsorted array
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the element at index i
                if (minIndex != i)
                {
                    //Call the Swap method from The Initial class
                    Initial.Swap(array, i, minIndex);
                }
            }
           
        }


        //Bubble sort function

        public static void BubbleSort(int[] array)
        {
            if (array == null) // check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

           

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //Call the Swap method from The Initial class  
                        Initial.Swap(array, j + 1, j);

                    }
                }

            }
         
        }



        public static void MergeSort(int[] array)
        {
            if (array == null) // check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");



            if (array.Length > 1)
            {
                int mid = array.Length / 2;

                // Split the array into two halves
                int[] left = new int[mid];
                int[] right = new int[array.Length - mid];

                Array.Copy(array, 0, left, 0, mid);
                Array.Copy(array, mid, right, 0, array.Length - mid);

                // Recursively sort the two halves
                MergeSort(left);
                MergeSort(right);

                // Merge the sorted halves back together
                Merge(array, left, right);
            }


        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            // Merge elements from left and right arrays in sorted order
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            // Copy any remaining elements from the left array
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            // Copy any remaining elements from the right array
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }


        }
      


        // Implementing a quick sort
        public static void QuickSort(int[] array)
        {
            if (array == null)// check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

               QuickSort(array, 0, array.Length - 1);

        }

        // Helper method for QuickSort, called recursively
        private static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int pivotIndex = Partition(array, low, high);

                // Recursively sort the sub-arrays
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        // Partition the array and return the pivot index
        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];  // Choose the last element as pivot
            int i = low - 1;          // Pointer for the smaller element
            
            // Rearrange elements based on the pivot
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;  // Increment the smaller element pointer
                    Initial.Swap(array, i, j);  // Swap elements
                }
            }

            // Swap the pivot element with the element at i + 1

            Initial.Swap(array, i + 1, high);

            return i + 1;  // Return the pivot index
        }


        // Method to Sort by Lambda
        public static int[] SortByLambda1(int[] array)
        {
            if (array == null) // check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            // Create a copy of the array and sort the copy using a lambda expression
            return array.OrderBy(x => x).ToArray(); // Sort the array in ascending order
        }

        // Sort by Lambdas
        public static void SortByLambda(int[] array)
        {
            if (array == null) // check if array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            // Create a copy of the array and sort the copy using a lambda expression
            array.OrderBy(x => x).ToArray(); // Sort the array in ascending order
        }
    }
}
