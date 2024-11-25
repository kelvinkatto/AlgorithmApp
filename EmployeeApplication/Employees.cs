using System;
using System.Collections.Generic;
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
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // Split the line using the '|' delimiter
                var parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    // Extract the employee's name and trim whitespaces
                    string employeeName = parts[0].Trim();

                    // Check if the name contains the search string (case-insensitive)
                    if (employeeName.ToLower().Contains(searchString))
                    {
                        filteredNames.Add(employeeName);
                    }
                }
            }

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
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // Split the line using the '|' delimiter
                var parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    // Extract the employee's name and trim whitespaces
                    string employeeName = parts[0].Trim();

                    // Add Names to the List
                     NameLists.Add(employeeName);
                    
                }
            }

            Console.WriteLine($"The List of names from the file Employee.txt are: ");
            Console.WriteLine("");
            foreach (var name in NameLists)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
            return NameLists;
        }


        public static List<string> Reduce(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            // List to store the filtered names
            List<string> yearLists = new List<string>();

            // Read all lines from the file
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // Split the line using the '|' delimiter
                var parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    // Extract the employee's name and trim whitespaces
                    string employeeYears = parts[2].Trim();

                    // Add Names to the List
                    yearLists.Add(employeeYears);

                }
            }

            Console.WriteLine($"The sum of years of experience of the employees are ");
            Console.WriteLine("");
            int sum = 0; 
            foreach (var year in yearLists)
            {
                sum = sum+ int.Parse(year);
               // Console.WriteLine(year);
            }
            Console.WriteLine(sum);
            Console.WriteLine("");
            return yearLists;
        }


    }
}
