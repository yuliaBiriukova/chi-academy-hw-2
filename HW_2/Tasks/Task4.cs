using HW_2.Handlers;

namespace HW_2.Tasks
{
    internal class Task4 : ITask
    {
        // find index of max element
        // if more than one max element, find first and last index of max elements
        public static void Execute()
        {
            Console.WriteLine("\nTask 4");
            Console.WriteLine("\nIndex of the fastest car(s)");

            var carsSpeeds = ArrayHandler.FillArrayRandom(40, 110, 151);

            Console.WriteLine("\nArray of car speeds:");
            Console.WriteLine(ArrayHandler.ArrayToString(carsSpeeds));

            var maxSpeedIndex = ArrayHandler.GetMaxElementIndex(carsSpeeds);

            if (maxSpeedIndex is int && maxSpeedIndex > 0)
            {
                Console.WriteLine("\nMax speed: " + carsSpeeds[maxSpeedIndex]);
                Console.WriteLine("The fastest car index: " + maxSpeedIndex);
            }
            else if (maxSpeedIndex is (int, int))
            {
                Console.WriteLine("\nMax speed: " + carsSpeeds[maxSpeedIndex.Item1]);
                Console.WriteLine("The first fastest car index: " + maxSpeedIndex.Item1);
                Console.WriteLine("The last fastest car index: " + maxSpeedIndex.Item2);
            }
            else
            {
                Console.WriteLine("No speeds in array!");
            }

        }
    }
}
