// See https://aka.ms/new-console-template for more information
using Algorithms;
using MyConsoleApp;

internal class Program
{
    private static async Task Main(string[] args)
    {
        //Call the Menu class to run the program
        
       await Menu.SelectSortAlgorithm();
    }
}