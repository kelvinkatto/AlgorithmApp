using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DelegateClass
    {   

        //Asynchronous Method to display sorting elapse time         
        public static async Task DisplayRunningTime(int[] array , SortingDelegate sortingDelegate)
        {
            if (sortingDelegate == null) //check if the delegate is null
                throw new ArgumentNullException(nameof(array) , "Sorting delegate cannot be null");
            if (array == null)//check if the array is null
                throw new ArgumentNullException(nameof(array) , "Array is Null");

            // Create and start the stopwatch
            Stopwatch sw = Stopwatch.StartNew();

            // Invoke the delegate to execute the sorting algorithm  asynchronously
            await Task.Run(()=>sortingDelegate(array));


            sw.Stop();
            TimeSpan etime = sw.Elapsed;

            // Display the elapsed time in Millisecond
            Console.WriteLine($"Elapsed Time for the selected Sort Algorithm: {etime.TotalMilliseconds} ms");
        }


        //Asynchronous Method to display Searching elapse time  
        public static async Task DisplayRunningTime(int[] array, SearchDelegate searchDelegate , int target)
        {
            if (searchDelegate == null)
                throw new ArgumentNullException(nameof(array), "Sorting delegate cannot be null");
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Array is Null");

            // Create and start the stopwatch
            Stopwatch sw = Stopwatch.StartNew();

            // Invoke the delegate to execute the sorting algorithm  asynchronously
            await Task.Run(()=>searchDelegate(array, target)); 
          

            sw.Stop();
            TimeSpan etime = sw.Elapsed;

            // Display the elapsed time
            Console.WriteLine($"Elapsed Time for the Search Algorithm is : {etime.TotalMilliseconds} ms");
        }
    }
}
