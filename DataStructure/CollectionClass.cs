using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CollectionClass
    {

        //Method to add elements in a list
        public static List<int> AddElementsToList(int n)
        {
            if (n <= 0)//Check if n is positive number
                throw new ArgumentOutOfRangeException(nameof(n), "List size must be greater than 0.");

            List<int> lists = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                lists.Add(new Random().Next(1, n)); // Add Random numbers to a list
            }

            return lists;
        }


        // Method to search an element in a list
        public static int SearchInList(int n)
        {
            if (n <= 0)//Check if n is positive number
                throw new ArgumentOutOfRangeException(nameof(n), "List size must be greater than 0.");
            
            List<int> _list = AddElementsToList(n);//create the list  
            n = n / 2;
            int value = _list[n];

            int index = _list.IndexOf(value); //search for the n/2 index value

            if (index != -1)
            {
                Console.WriteLine($"Value {value} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Value {value} not found in the dynamic array.");
            }

            return index;
        }

        //method to delete an element in a list
        public void Delete(int n , int value)
        {

            if (n <= 0)//Check if n is positive number
                throw new ArgumentOutOfRangeException(nameof(n), "List size must be greater than 0.");

            List<int> _list = AddElementsToList(n);// create the list

            if (_list.Contains(value))
            {
                _list.Remove(value);// delete the value from the list
                Console.WriteLine($"Deleted {value} from the dynamic array.");
            }
            else
            {
                Console.WriteLine($"Value {value} not found in the dynamic array.");
            }
        }
    }
}
