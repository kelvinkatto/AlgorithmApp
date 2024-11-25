using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyConsoleApp
{
    public class Menu
    {
        public Menu() { }

        //Method to display menu of Sorting methods
        public static async Task SelectSortAlgorithm()
        {
            Console.WriteLine("*****Welcome to Sorting Algorithm Performance Comparator!*****");

            while (true)
            {
                Console.WriteLine("\nMenu for Sorting Methods");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Selection Sort");
                Console.WriteLine("3. Bubble Sort");
                Console.WriteLine("4. Merge Sort");
                Console.WriteLine("5. Quick Sort");
                Console.WriteLine("6. Lambda Sort");
                Console.WriteLine("0. Exit");
                Console.Write("Select a sorting algorithm to compare (1-6): ");

                // Read user input
                string choice = Console.ReadLine();

                //Initialize a delegate
                SortingDelegate? selectedAlgorithmDelegate = null;

                switch (choice)
                {
                    case "1":
                        selectedAlgorithmDelegate = SortsAlgorithms.InsertionSort;
                        Console.WriteLine("\nYou selected an Insertion Sort Algorithm.");
                        break;

                    case "2":
                        selectedAlgorithmDelegate = SortsAlgorithms.SelectionSort;
                        Console.WriteLine("\nYou selected a Selection Sort Algorithm.");
                        break;

                    case "3":
                        selectedAlgorithmDelegate = SortsAlgorithms.BubbleSort;
                        Console.WriteLine("\nYou selected a Bubble Sort Algorithm.");
                        break;

                    case "4":
                        selectedAlgorithmDelegate = SortsAlgorithms.MergeSort;
                        Console.WriteLine("\nYou selected a Merge Sort Algorithm.");
                        break;

                    case "5":
                        selectedAlgorithmDelegate = SortsAlgorithms.QuickSort;
                        Console.WriteLine("\nYou selected a Quick Sort Algorithm.");
                        break;

                    case "6":
                        selectedAlgorithmDelegate = SortsAlgorithms.SortByLambda;
                        Console.WriteLine("\nYou selected a Lambda Sort Algorithm.");
                        break;

                    case "0":
                        Console.WriteLine("\nExiting the application. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        continue;
                }

                // Get array size from the user
                Console.Write("\nEnter the size of the array to sort: ");
                if (!int.TryParse(Console.ReadLine(), out int arraySize) || arraySize <= 0)
                {
                    Console.WriteLine("\nInvalid input. Array size must be a positive integer.");
                    continue;
                }

                // Prepare the array
                int[] array_numbers = Initial.Prepare(arraySize);

                Console.WriteLine("\nMeasuring performance of the selected sorting algorithm...");

                // Measure and display running time
                await DelegateClass.DisplayRunningTime(array_numbers, selectedAlgorithmDelegate);

                Console.WriteLine("\nSorting completed. Do you want to test another algorithm? press (y) to continue or any other letter to exit: ");
                string retry = Console.ReadLine();
                if (!string.Equals(retry, "y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nThank you for using the application. Goodbye!");
                    break;
                }


            }



        }

    }
}
