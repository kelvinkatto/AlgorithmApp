using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> list = CollectionClass.AddElementsToList(9);
            foreach (int num in list)
            {
                Console.Write(num +" ");
            }
            Console.WriteLine(" ");
            CollectionClass.SearchInList(70);
        ;

        }
    }
}
