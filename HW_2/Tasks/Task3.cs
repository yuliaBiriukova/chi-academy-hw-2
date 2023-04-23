using HW_2.Handlers;

namespace HW_2.Tasks
{
    internal class Task3 : ITask
    {
        // find amount of pages in the thickest book
        public static void Execute()
        {
            Console.WriteLine("\nTask 3");
            Console.WriteLine("\nPages in the thickest book");

            var booksPages = ArrayHandler.FillArrayRandom(100, 50, 1000);

            Console.WriteLine("\nArray of books pages:");
            Console.WriteLine(ArrayHandler.ArrayToString(booksPages));

            var maxPages = ArrayHandler.GetMaxElement(booksPages);
            if (maxPages > 0)
            {
                Console.WriteLine($"\nThe thickest book has {maxPages} pages");
                return;
            }

            Console.WriteLine("No books with pages!");
        }
    }
}
