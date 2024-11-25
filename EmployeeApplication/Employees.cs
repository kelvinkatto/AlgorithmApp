using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class Employees
    {

        public static List<string> Filter(string filePath, string searchString)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            if (string.IsNullOrWhiteSpace(searchString))
                throw new ArgumentException("Search string cannot be null or empty.", nameof(searchString));

            // Ensure the search string is case-insensitive
            searchString = searchString.ToLower();

            // List to store the filtered names
            List<string> filteredNames = new List<string>();

            // Read all lines from the file
            var employees = File.ReadAllLines(filePath);

            filteredNames = employees.Where(emp => emp.Split('|')[0].Trim().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            .Select(emp => emp.Split('|')[0].Trim()).ToList();

            Console.WriteLine($"Names filtered by '{searchString}' keyword are : ");
            Console.WriteLine("");
            foreach (var line in filteredNames)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            return filteredNames;
        }


        public static List<string> Map(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            // List to store the filtered names
            List<string> NameLists = new List<string>();

            // Read all lines from the file
            var employees = File.ReadAllLines(filePath);

            //get name of employees
            NameLists = employees.Select(emp => emp.Split('|')[0].Trim()).ToList();

            Console.WriteLine($"The List of names from the file Employee.txt are: ");
            Console.WriteLine("");
            foreach (var name in NameLists)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
            return NameLists;
        }


        public static int Reduce(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));


            // Read all lines from the file
            var employees = File.ReadAllLines(filePath);

            //get the summation of year of experience
            int sum = employees.Select(emp => int.Parse(emp.Split('|')[2].Trim())).Sum();

            Console.WriteLine($"The sum of years of experience of the employees are " + sum);
            return sum;
           
        }


    }
}
