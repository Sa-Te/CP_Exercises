using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week8
    {
        public static int[] Populate(int length, int maxValue)
        {
            Random r = new Random();
            int[] array;
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = r.Next(maxValue);
            }
            return array;
        }

        public static void Print(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+ " ");
            }    
        }

        public static int[] Populate(int[] array, int maxValue)
        {
            Random r = new Random(maxValue);
            for(int i = 0;i < array.Length; i++)
            {
                array[i] = r.Next(maxValue);
            }
            return array;
        }

        public static void Swap(int a, int b)
        {
            int temp = a; // Use a temporary variable 
            a = b;
            b = temp; // Assign the value of b to a and then the original value of a (stored in temp) to b
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public static void PrintArray(string[] array)
        {
            Console.WriteLine("Names:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"- {array[i]}");
            }
        }

        public static void Swap(string[] array, int index1, int index2)
        {
            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                string temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
            else
            {
                Console.WriteLine("Invalid index provided for swap.");
            }
        }

        public static bool IsGreaterThanNeighbours(int[] arr, int index)
        {
            // Check if the index is within valid range (avoiding index out of bounds errors)
            if (index < 0 || index >= arr.Length)
            {
                return false;
            }

            // Check if there's only one element in the array
            if (arr.Length == 1)
            {
                return false;
            }

            // Check if the element at the given index is greater than both neighbours
            int leftNeighbourIndex = index - 1;
            int rightNeighbourIndex = index + 1;

            // Handle cases for elements at the beginning or end of the array
            if (index == 0)
            {
                return arr[index] > arr[rightNeighbourIndex];
            }
            else if (index == arr.Length - 1)
            {
                return arr[index] > arr[leftNeighbourIndex];
            }
            else
            {
                return arr[index] > arr[leftNeighbourIndex] && arr[index] > arr[rightNeighbourIndex];
            }
        }

        public static bool IsSorted(int[] array)
        {
            if (array.Length <= 1)
            {
                return true; // Array with 0 or 1 element is considered sorted
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetMax(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        public static int GetMin(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        public static int GetValue(string operation, int[] array)
        {
            if (operation.ToLower() == "max")
            {
                return GetMax(array);
            }
            else if (operation.ToLower() == "min")
            {
                return GetMin(array);
            }
            else
            {
                // Handle invalid operation
                Console.WriteLine("Invalid operation provided. Valid options are 'max' or 'min'.");
                return 0; // Or return a default value or throw an exception
            }
        }

        public static int CountOccurrences(int[] array, int target)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    count++;
                }
            }
            return count;
        }

        public static int FindPeakElement(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return -1; // Array with 0 or 1 element has no peak
            }

            // Check elements except the first and last
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    return i;
                }
            }

            // Check first and last elements (if applicable)
            if (arr[0] > arr[1])
            {
                return 0;
            }
            else if (arr[arr.Length - 1] > arr[arr.Length - 2])
            {
                return arr.Length - 1;
            }

            return -1; // No peak element found
        }

        public static class NumberToWords
        {
            private static readonly string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            private static readonly string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            private static readonly string[] hundreds = { "", "Hundred", "Two Hundred", "Three Hundred", "Four Hundred", "Five Hundred", "Six Hundred", "Seven Hundred", "Eight Hundred", "Nine Hundred" };

            public static string Convert(int number)
            {
                if (number < 0 || number > 999)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Number must be in the range [0...999]");
                }

                if (number == 0)
                {
                    return ones[0];
                }

                return ConvertHundreds(number) + ConvertTensAndOnes(number % 100);
            }

            private static string ConvertHundreds(int number)
            {
                int hundredsDigit = number / 100;
                return hundreds[hundredsDigit] + (hundredsDigit > 0 ? " " : "");
            }

            private static string ConvertTensAndOnes(int number)
            {
                if (number < 20)
                {
                    return ones[number] + (number > 0 ? " " : "");
                }

                int tensDigit = number / 10;
                int onesDigit = number % 10;
                return tens[tensDigit] + (onesDigit > 0 ? (" " + ones[onesDigit]) : "");
            }
        }
    }
}
