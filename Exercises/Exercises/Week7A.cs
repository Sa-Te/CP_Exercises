using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week7A
    {

        public static void Exercise1()
        {
            // Get array size from user
            Console.WriteLine("Enter the size of the square array:");
            int size = int.Parse(Console.ReadLine());

            // Initialize the array with random values
            int[,] array = InitializeArray(size);

            // Print the array
            PrintArray(array);

            // Find the maximum value, minimum value, and diagonal sum
            int maxValue = FindMax(array);
            int minValue = FindMin(array);
            int diagonalSum = CalculateDiagonalSum(array);

            // Print the results
            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine("Sum of elements in the diagonal: " + diagonalSum);
        }

        private static int[,] InitializeArray(int size)
        {
            int[,] array = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = random.Next(0, 11); // Generate random number between 0 (inclusive) and 11 (exclusive)
                }
            }
            return array;
        }

        private static void PrintArray(int[,] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int FindMax(int[,] array)
        {
            int maxValue = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    maxValue = Math.Max(maxValue, array[i, j]);
                }
            }
            return maxValue;
        }

        private static int FindMin(int[,] array)
        {
            int minValue = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    minValue = Math.Min(minValue, array[i, j]);
                }
            }
            return minValue;
        }

        private static int CalculateDiagonalSum(int[,] array)
        {
            int diagonalSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                diagonalSum += array[i, i];
            }
            return diagonalSum;
        }

        public static void Exercise2(string input)
        {
            // Validate input (optional)
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid string.");
                return;
            }

            // Print each character on a separate line
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        public static void Exercise3()
        {
            // Get array size from user
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            // Initialize the array with random values
            int[] array = FillRandomArray(size);

            // Part 1: Print the original array
            Console.WriteLine("Original array:");
            PrintArray(array);

            // Part 2: Create a doubled array with new random values
            int[] doubledArray = CreateDoubledArray(array);

            // Print the doubled array
            Console.WriteLine("Doubled array:");
            PrintArray(doubledArray);
        }

        private static int[] FillRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 11); // Generate random number between 0 and 10 (exclusive)
            }
            return array;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        private static int[] CreateDoubledArray(int[] originalArray)
        {
            // Create a new array with double the size
            int[] doubledArray = new int[originalArray.Length * 2];

            // Copy original elements
            Array.Copy(originalArray, doubledArray, originalArray.Length);

            // Fill the remaining elements with new random values
            Random random = new Random();
            for (int i = originalArray.Length; i < doubledArray.Length; i++)
            {
                doubledArray[i] = random.Next(0, 11);
            }
            return doubledArray;
        }

        public static void Exercise4()
        {
            // Get array size from user
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            // Generate random integer array
            int[] array = GenerateRandomArray(size);

            // Print the original array
            Console.WriteLine("Original array:");
            PrintArray(array);

            // Reverse the array (in-place method)
            ReverseArray(array);

            // Print the reversed array
            Console.WriteLine("Reversed array:");
            PrintArray(array);
        }

        private static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 11); // Generate random number between 0 (inclusive) and 11 (exclusive)
            }
            return array;
        }

        private static void ReverseArray(int[] array)
        {
            // In-place reversal using two pointers
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Swap elements from left and right sides
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }


        public static void Exercise5()
        {
            // List to store characters (dynamically resizable)
            List<char> letters = new List<char>();

            // Input loop until '#' is entered
            Console.WriteLine("Enter letters (press '#' to stop):");
            char input;
            do
            {
                input = Console.ReadKey(true).KeyChar;
                letters.Add(input);
            } while (input != '#');

            // Convert list to character array
            char[] charArray = letters.ToArray();

            // Print original array
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", charArray)); // Join elements with spaces

            // Sort the array (ascending order)
            Array.Sort(charArray);

            // Print sorted array
            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", charArray));
        }

        public static void Exercise6()
        {
            // Create array with all lowercase letters (assuming it's a char array)
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // Get input string from user
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine().ToLower(); // Convert to lowercase

            // Find indices and store in a string builder
            StringBuilder indicesString = new StringBuilder();
            foreach (char c in inputString)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (c == alphabet[i])
                    {
                        indicesString.Append(i + " ");
                        break; // Exit inner loop once a match is found
                    }
                }
            }

            // Print the string of indices (remove trailing space if any)
            Console.WriteLine("Indices: " + indicesString.ToString().TrimEnd());
        }

        public static void Exercise7()
        {
            // Get array size, minimum, and maximum values from user
            Console.Write("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum value: ");
            int minValue = int.Parse(Console.ReadLine());
            Console.Write("Enter maximum value: ");
            int maxValue = int.Parse(Console.ReadLine());

            // Create random integer array
            int[] randomArray = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            // Find minimum value and its first index
            int minIndex = 0;
            int minElement = randomArray[0];
            for (int i = 1; i < arraySize; i++)
            {
                if (randomArray[i] < minElement)
                {
                    minElement = randomArray[i];
                    minIndex = i;
                }
            }

            // Create new array with sorted subset
            int[] sortedSubset = new int[arraySize];
            int j = 0;
            for (int i = minIndex; i < arraySize; i++)
            {
                if (randomArray[i] >= sortedSubset[j])
                {
                    sortedSubset[j++] = randomArray[i];
                }
            }

            // Print original and sorted subset arrays
            Console.WriteLine("Original array: " + string.Join(", ", randomArray));
            Console.WriteLine("Sorted subset array: " + string.Join(", ", sortedSubset.Take(j).ToArray()));
        }

        public static void Exercise8()
        {
            // Get array size from user
            Console.Write("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Create random integer array
            int[] randomArray = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                randomArray[i] = random.Next(); // Generates random integer within int range
            }

            // Sort the array using bubble sort
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = 0; j < arraySize - i - 1; j++)
                {
                    if (randomArray[j] > randomArray[j + 1])
                    {
                        Swap(randomArray, j, j + 1); // Swap elements if not in order
                    }
                }
            }

            // Print the sorted array
            Console.WriteLine("Sorted array: " + string.Join(", ", randomArray));
        }

        // Helper method for swapping elements in an array
        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void Exercise9()
        {
            // Ensure minimum dimensions and get user input
            int m, n;
            do
            {
                Console.Write("Enter the number of rows (m) - must be greater than 6: ");
                m = int.Parse(Console.ReadLine());
            } while (m <= 6);

            do
            {
                Console.Write("Enter the number of columns (n) - must be greater than 6: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 6);

            // Create and fill the 2D array with random integers
            int[,] array = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 101); // Random integers between 1 and 100
                }
            }

            // Print the original array
            Console.WriteLine("\nOriginal array:");
            PrintArray(array, m, n);

            // Find the maximum sum 3x3 subarray
            int maxSum = int.MinValue;
            int startX = 0, startY = 0;
            for (int i = 0; i < m - 2; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    int currentSum = array[i, j] + array[i, j + 1] + array[i, j + 2]
                                     + array[i + 1, j] + array[i + 1, j + 1] + array[i + 1, j + 2]
                                     + array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startX = i;
                        startY = j;
                    }
                }
            }

            // Create and fill the 3x3 subarray with maximum sum
            int[,] subarray = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    subarray[i, j] = array[startX + i, startY + j];
                }
            }

            // Print the maximum sum subarray
            Console.WriteLine($"\nSubarray with maximum sum ({maxSum}):");
            PrintArray(subarray, 3, 3);
        }

        // Helper method to print a 2D array
        private static void PrintArray(int[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise10()
        {
            Console.Write("Enter a relatively large number (n): ");
            int n = int.Parse(Console.ReadLine());

            int[] primes = new int[n + 1]; // Create array to store primes
            int primeCount = 0;

            // Fill primes array with initial candidate primes (2 and odd numbers)
            primes[primeCount++] = 2; // 2 is the only even prime
            for (int i = 3; i <= n; i += 2)
            {
                primes[primeCount++] = i;
            }

            // Sieve of Eratosthenes algorithm to filter primes
            for (int i = 0; i < primeCount; i++)
            {
                int prime = primes[i];
                if (prime * prime > n) // Optimization: no need to check beyond the square root of n
                {
                    break;
                }

                for (int j = i + prime; j < primeCount; j += prime)
                {
                    primes[j] = 0; // Mark multiples of prime as non-prime
                }
            }

            // Print the prime numbers
            Console.WriteLine("Prime numbers up to {0}:", n);
            for (int i = 0; i < primeCount; i++)
            {
                if (primes[i] != 0)
                {
                    Console.Write(primes[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public static void Exercise11()
        {
            // Get array size from user
            Console.Write("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Create array and read values from console
            int[] array = new int[arraySize];
            Console.WriteLine("Enter the elements of the array (space-separated):");
            string inputLine = Console.ReadLine();
            string[] stringValues = inputLine.Split(' ');

            if (stringValues.Length != arraySize)
            {
                Console.WriteLine("Error: The number of entered values doesn't match the array size.");
                return;
            }

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(stringValues[i]);
            }

            // Check for symmetry (early exit if not symmetric)
            bool isSymmetric = true;
            for (int i = 0; i < arraySize / 2; i++)
            {
                if (array[i] != array[arraySize - 1 - i])
                {
                    isSymmetric = false;
                    break;
                }
            }

            // Print the array
            Console.WriteLine("Array:");
            Console.WriteLine(string.Join(" ", array));

            // Print symmetry report
            Console.WriteLine(isSymmetric ? "The array is symmetric." : "The array is not symmetric.");
        }

        public static void Exercise12()
        {
            // Create and initialize an array (replace with your own data)
            int[] numbers = { 64, 25, 12, 22, 11 };

            // Sort the array using selection sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i; // Assume the first element is the minimum

                // Find the index of the minimum element in the unsorted part
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the first element of the unsorted part
                if (minIndex != i)
                {
                    Swap(numbers, i, minIndex);
                }
            }

            // Print the sorted array
            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void Exercise13()
        {
            // Artist names
            string[] artists = { "Black Sabbath", "Jimi Hendrix", "Velvet Underground", "Deep Purple", "Ruts", "Jethro Tull" };

            // Corresponding IDs (make sure the order matches the artists array)
            int[] ids = { 2345654, 6523456, 9856784, 3245124, 3256654, 5421564 };

            // Get ID to search for from user
            Console.Write("Enter artist ID: ");
            int searchId = int.Parse(Console.ReadLine());

            // Find artist name using ID
            int artistIndex = Array.IndexOf(ids, searchId);
            string artistName = artistIndex >= 0 ? artists[artistIndex] : "Artist not found";

            // Print the result
            Console.WriteLine(artistName);
        }

        public static void Exercise14()
        {
            // Get matrix dimension from user
            Console.Write("Enter the dimension (n) for the matrix: ");
            int n = int.Parse(Console.ReadLine());

            // Create and fill the matrix
            int[,] matrix = new int[n, n];
            int value = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = value;
                    value++;
                }
            }

            // Print the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
