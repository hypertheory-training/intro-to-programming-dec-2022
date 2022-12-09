

using System.Diagnostics.Tracing;

namespace JunkDrawer
{

    public static class NumberUtilities
    {

        public static int NumberOfVowels(this string word)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            var total = 0;
            foreach(var letter in word)
            {
                if(vowels.Contains(letter))
                {
                    total++;
                }
            }
            return total;
        }
        public static DateTime DaysFromToday(this int d)
        {
            return DateTime.Now.AddDays(d);
        }

        public static bool IsEven(this int n) => n % 2 == 0;

        public static bool IsOdd(this int n) => n % 2 != 0;
    }
}
