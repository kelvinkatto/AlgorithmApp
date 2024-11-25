using System.IO;

namespace EmployeeApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "E:\\projects\\C#\\MyConsoleApp\\EmployeeApplication\\Employees.txt";
            string searchString = "an";

            Console.WriteLine($"Welcome to the employee application which contains three methods filter , map and reduce ");
            Console.WriteLine(" ");
            Employees.Filter(filePath, searchString);
            Employees.Map(filePath);
            Employees.Reduce(filePath);

        }
    }
}
