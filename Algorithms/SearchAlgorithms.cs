namespace Algorithms
{
    // the code below have been obtained from the website called https://medium.com/ and being modified to be used in this application
    //  complete url to the code 
    // https://m-ansley.medium.com/a-brief-introduction-to-binary-and-linear-searches-c-96e9ecc170ee


    //define the delegate for searching algorithms
    public delegate int SearchDelegate(int[] array , int target);
    public class SearchAlgorithms
    {

         

        //Linear Search Algorithm method
        public static int LinearSearch(int[] array, int target)
        {
            if (array == null) //check if the array is null
                throw new ArgumentNullException(nameof(array));
            // Iterate through the array
            for (int i = 0; i < array.Length; i++)
            {
                // If the current element matches the target, return the index
                if (array[i] == target)
                {
                   // Console.WriteLine($"returned index is {i}  and the value is {array[i]}");
                    return i;
                }
            }
            Console.WriteLine($"The target value not found");
            // If the loop completes, the target is not in the array
            return -1;
        }

        //Binary Search Algorithm method
        public static int BinarySearch(int[] array, int target)
        {
            if (array == null) //check if the array is null
                throw new ArgumentNullException(nameof(array));

           // Array.Sort(array); // Sort elements before searching
            int left = 0;
            int right = array.Length - 1;
         
            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Avoid overflow

                if (array[mid] == target)
                {
                    //Console.WriteLine($"returned index is {mid}  and the value is {array[mid]}");
                    return mid; // Target found at mid
                }

                if (array[mid] < target)
                    left = mid + 1; // Target is in the right half
                else
                    right = mid - 1; // Target is in the left half
            }
            ;

            Console.WriteLine($"Target value not found");
            return -1; // Target not found
        }


        // search algorithm using lambda
        public static int LambdaSearch(int[] array, int target)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            // Use LINQ to find the index of the target value
            int index = Array.FindIndex(array, element => element == target);
         
           
            return index; // Returns -1 if not found
        }
    }
}
