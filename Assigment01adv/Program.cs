using System.Collections;

namespace Assigment01adv
{
    internal class Program
    {


        #region Q2: Reverse ArrayList
        public static void ReverseArrayList(ArrayList arr)
        {
            int left = 0, right = arr.Count - 1;
            while (left < right)
            {
                object temp = arr[left]??0;
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        #endregion

        #region Q3: Get Even Numbers
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evens = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0) evens.Add(num);
            }
            return evens;
        }
        #endregion



        #region Q5: First Non-Repeated Character
        public static int FirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            // Count frequency
            foreach (char c in str)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            // Find first non-repeated
            for (int i = 0; i < str.Length; i++)
            {
                if (freq[str[i]] == 1)
                    return i;
            }
            return -1;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1: Generic Range<T>
            Range<int> intRange = new Range<int>(5, 15);
            Console.WriteLine(intRange.IsInRange(10));  // True
            Console.WriteLine(intRange.IsInRange(20));  // False
            Console.WriteLine($"Length = {intRange.Length()}");
            #endregion

            #region Q2: Reverse ArrayList without built-in Reverse
            ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before Reverse:");
            foreach (var item in arr) Console.Write(item + " ");

            ReverseArrayList(arr);

            Console.WriteLine("\nAfter Reverse:");
            foreach (var item in arr) Console.Write(item + " ");
            #endregion

            #region Q3: Extract Even Numbers from List<int>
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = GetEvenNumbers(numbers);
            Console.WriteLine("\nEven Numbers: " + string.Join(", ", evenNumbers));
            #endregion

            #region Q4: FixedSizeList<T>
            FixedSizeList<string> names = new FixedSizeList<string>(3);
            names.Add("Ali");
            names.Add("Omar");
            names.Add("Mona");

            Console.WriteLine("Element at index 1: " + names.Get(1));
            try
            {
                names.Add("Extra");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion

            #region Q5: First Non-Repeated Character
            string str = "swiss";
            int index = FirstNonRepeatedChar(str);
            if (index != -1)
                Console.WriteLine($"First non-repeated character '{str[index]}' at index {index}");
            else
                Console.WriteLine("No unique character found.");
            #endregion

        }
    }
}

