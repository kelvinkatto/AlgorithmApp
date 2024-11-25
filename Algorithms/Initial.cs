using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms
{
    //This class contains three methods swap , randomize and prepared method
    public class Initial
    {
        
        //Method to swap two elements in an array
        public static void Swap(int[] array, int pos1, int pos2)
        {

            if (array == null)  //check if the array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            if (pos1 < 0 || pos1 >= array.Length || pos2 < 0 || pos2 >= array.Length)
                throw new ArgumentOutOfRangeException("Positions must be within the array bounds.");

            int temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;


        }



        //Method to create a random array
        public static void Randomize(int[] array)
        {

            if (array == null) //check if the array is null
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");

            Random random = new Random();//call a random class and create an object of random class
            int maxValue = 10 * array.Length;

            //loop to create a random array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, maxValue);
            }


        }

        // method to prepare an array 
        public static int[] Prepare(int n)
        {
            if (n <= 0)//check if the n is negative number
                throw new ArgumentOutOfRangeException(nameof(n), "Array size must be greater than 0.");
            
            int[] numbers = new int[n];

            Randomize(numbers); // call a randomize method to create an array

            return numbers;

        }


    }
}
