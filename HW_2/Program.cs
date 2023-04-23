using HW_2.Tasks;

namespace HW_2
{
    internal class Program
    {
        public static void Main()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Select the task:");
            Console.WriteLine("\n1. Task 1. Sum and max digit in string");
            Console.WriteLine("2. Task 2. Index of max digit in string with spaces in the beginning");
            Console.WriteLine("\n0. Exit");
            Console.Write("\nTask > ");
            switch (Console.ReadLine())
            {
                case "1":
                    Task1.Execute();
                    WaitUser();
                    return true;
                case "2":
                    Task2.Execute();
                    WaitUser();
                    return true;
                case "0":
                    return false;
                default:
                    Console.WriteLine("\nInvalid input! Enter number from 0 to 4!");
                    WaitUser();
                    return true;
            }
        }

        private static void WaitUser()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
