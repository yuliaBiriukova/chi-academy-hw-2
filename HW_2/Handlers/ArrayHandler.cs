namespace HW_2.Handlers
{
    internal class ArrayHandler
    {
        // return max element in array
        public static int GetMaxElement(int[] array)
        {
            if (array != null && array.Any())
                return array.Max();
            return 0;
        }

        // return array filled with random values in the range [min, max)
        public static int[] FillArrayRandom(int length, int min, int max)
        {
            var array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = new Random().Next(min, max);
            return array;
        }

        // return formated string of array elements
        public static string ArrayToString(int[] array)
        {
            return string.Format("[{0}]", string.Join(", ", array));
        }
    }
}
