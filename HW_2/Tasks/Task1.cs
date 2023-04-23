using HW_2.Handlers;

namespace HW_2.Tasks
{
    internal class Task1 : ITask
    {
        // sum digits and find max digit in string
        public static void Execute()
        {
            Console.WriteLine("\nTask 1");
            Console.WriteLine();
            Console.WriteLine("Sum of digits and max digit in string");
            Console.Write("\nEnter string to check: ");
            var input = Console.ReadLine();

            var digitsSum = StringHandler.SumDigitsInString(input);
            var maxDigit = StringHandler.GetMaxDigitInString(input);

            Console.WriteLine("\na) Sum of digits in string: " + digitsSum);
            Console.WriteLine("b) Max digit in string: " + maxDigit);
        }
    }
}
