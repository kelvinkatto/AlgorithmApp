using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppSearchAlgorithms
{
    public class Menu
    {

        public static async Task SelectSearchAlgorithm()
        {
            Console.WriteLine("****Welcome to Search Algorithm Performance Comparator!****");

            while (true)
            {
                Console.WriteLine("\nMenu Selection");
                Console.WriteLine("1. Linear Search Algorithm");
                Console.WriteLine("2. Binary Search Algorithm");
                Console.WriteLine("3. Lambda Search Algorithm");
               
                Console.WriteLine("0. Exit");
                Console.Write("Select a Search algorithm to compare (1-3): ");

                // Read user input
                string choice = Console.ReadLine();
                // SortingDelegate sortDelegate = SortMethods.InsertionSort;
                SearchDelegate? selectedAlgorithmDelegate = null;

                switch (choice)
                {
                    case "1":
                        selectedAlgorithmDelegate = SearchAlgorithms.LinearSearch;
                        Console.WriteLine("\nYou selected a Linear Search Algorithm.");
                        break;

                    case "2":
                        selectedAlgorithmDelegate = SearchAlgorithms.BinarySearch;
                        Console.WriteLine("\nYou selected Binary Search Algorithm.");
                        break;

                    case "3":
                        selectedAlgorithmDelegate = SearchAlgorithms.LambdaSearch;
                        Console.WriteLine("\nYou selected Lambda Search Algorithm.");
                        break;

                    case "0":
                        Console.WriteLine("\nExiting the application. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        continue;
                }


                int arraySize = 100000; //initilize the size of an array to 100000
                int index = subMenu(arraySize, choice);

                // Prepare the array
               int[] array_numbers = Initial.Prepare(arraySize);
               // int[] array_numbers = { 5, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                //selection of the Test creteria
                Console.WriteLine($"\nMeasuring performance  of the selected search algorithm");


                // Measure and display running time

                if (choice == "2")
                {
                    Array.Sort(array_numbers); // Sort elements before searching
                    await DelegateClass.DisplayRunningTime(array_numbers, selectedAlgorithmDelegate, array_numbers[index]);

                }
                else
                {
                    await DelegateClass.DisplayRunningTime(array_numbers, selectedAlgorithmDelegate, array_numbers[index]);
                }
                

                Console.WriteLine("\nSearch completed. Do you want to test another algorithm? press (y) to continue or any other letter to exit: ");
                string retry = Console.ReadLine();
                if (!string.Equals(retry, "y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nThank you for using the application. Goodbye!");
                    break;
                }


            }



        }

        
        private static int subMenu(int arraySize , string selectedCase)
        {
            int index = 0;
            while (true) {

                Console.WriteLine("\nMenu: Select The Case you want to make test");
                Console.WriteLine("1. Best Case");
                Console.WriteLine("2. Average case");
                Console.WriteLine("3. Worst case");

                Console.Write("\nSelect the number of the Case which you want to Test from (1-3) ");

                // Read user input
                string choice = Console.ReadLine();

                if (selectedCase == "2") {
                   
                    switch (choice)
                    {
                        case "1":
                            index = arraySize / 2; //best case for binary search , take the middle index
                            return index;

                        case "2":
                            index = arraySize / 3; // avarage case , take any index in either halves
                            return index;

                        case "3":
                            index = arraySize - 1; //worse case , take the last index
                            return index;

                        default:
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            continue;
                    }
                }
                else
                {
                   
                    switch (choice)
                    {
                        case "1":
                            return index; //take first index for best case

                        case "2":
                            index = arraySize / 2;  // take middle index for avarage case
                            return index;

                        case "3":
                            index = arraySize - 1; //take last index for worst case
                            return index;

                        default:
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            continue;
                    }

                }
               



            }

        }
    }
}
