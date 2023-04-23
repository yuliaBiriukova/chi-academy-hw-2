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

        // return index of max element in array
        // if more than one max, return first and last index of max elements as tuple
        public static dynamic GetMaxElementIndex(int[] array)
        {
            if (array != null && array.Any())
            {
                var max = array.Max();
                if (HasOneMax(array))
                    return array.ToList().IndexOf(max);
                else
                    return (array.ToList().IndexOf(max), array.ToList().LastIndexOf(max));
            }
            return -1;
        }

        // return true if array has one max element, otherwise return false 
        public static bool HasOneMax(int[] array)
        {
            if (array != null && array.Any())
            {
                int count = array.Where(el => el == array.Max()).Count();
                return count == 1;
            }
            return false;
        }
    }
}
