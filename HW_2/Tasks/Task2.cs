using HW_2.Handlers;

namespace HW_2.Tasks
{
    internal class Task2 : ITask
    {
        // trim spaces and find index of max digit in string
        public static void Execute()
        {
            Console.WriteLine("\nTask 2");
            Console.WriteLine();
            Console.WriteLine("Index of max digit in string with spaces in the beginning");

            Console.Write("\nEnter string to check: ");
            var input = Console.ReadLine();

            var maxDigitIndex = StringHandler.GetMaxDigitIndexInString(input);

            if (maxDigitIndex < 0)
            {
                Console.WriteLine("\nThere is no digits in the string!");
                return;
            }

            Console.WriteLine("\nMax digit: " + input.Trim()[maxDigitIndex]);
            Console.WriteLine("Index of max digit in string: " + maxDigitIndex);
        }
    }
}
