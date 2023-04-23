namespace HW_2.Handlers
{
    internal class StringHandler
    {
        // return sum of digits in string 
        public static int SumDigitsInString(string? str)
        {
            if (string.IsNullOrEmpty(str) || !str.Any(char.IsDigit))
                return 0;

            return Convert.ToInt32(str.Where(char.IsDigit).Sum(char.GetNumericValue));
        }

        // return maximum digit in string
        public static int GetMaxDigitInString(string? str)
        {
            if (string.IsNullOrEmpty(str) || !str.Any(char.IsDigit))
                return 0;

            return Convert.ToInt32(str.Where(char.IsDigit).Select(char.GetNumericValue).Max());
        }

        // return index of max digit on string without spaces 
        public static int GetMaxDigitIndexInString(string? str)
        {
            if (string.IsNullOrEmpty(str) || !str.Any(char.IsDigit))
                return -1;

            string trimmedStr = str.Trim();
            return trimmedStr.IndexOf(trimmedStr.Where(char.IsDigit).Select(c => c).Max());
        }
    }
}
