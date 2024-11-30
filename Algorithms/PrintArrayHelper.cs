namespace Algorithms
{
    public class PrintArrayHelper
    {
        public static void PrintArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
