using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week6
    {

        public static void Exercise1()
        {
            Console.Write("Input an Integer: ");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " ");
            }
        }

        public static void Exercise2()
        {
            string userInput;

            do
            {
                Console.Write("Input an Integer (press 'q' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    break;
                }

                for (int i = 0; i < userInput.Length; i++)
                {
                    Console.WriteLine(userInput[i]);
                }

            } while (true);
        }

        public static void Exercise3()
        {
            string userInput;

            do
            {
                Console.Write("Enter the number of elements for the array (press 'q' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    break;
                }

                int arraySize;
                if (!int.TryParse(userInput, out arraySize))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'q' to quit.");
                    continue;
                }

                int[] array = new int[arraySize];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i + 1;
                }

                Console.WriteLine("Array elements:");
                foreach (int num in array)
                {
                    Console.WriteLine(num);
                }

            } while (true);
        }

        public static void Exercise4()
        {
            Console.Write("Enter the size of the array: ");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the size of the array.");
                return;
            }

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101); // Generates random integer between 1 and 100 (inclusive)
            }

            Console.WriteLine("Randomly generated array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

        public static void Exercise4a()
        {
            Console.Write("Enter the size of the array: ");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the size of the array.");
                return;
            }

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101); // Generates random integer between 1 and 100 (inclusive)
            }

            Console.WriteLine("Randomly generated array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            // Calculate sum of elements
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            Console.WriteLine("Sum of elements: " + sum);

            // Count elements less than 10
            int countLessThan10 = 0;
            foreach (int num in array)
            {
                if (num < 10)
                {
                    countLessThan10++;
                }
            }
            Console.WriteLine("Number of elements less than 10: " + countLessThan10);

            // Create array b
            int[] arrayB = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrayB[i] = array[i] + (i < size - 1 ? array[i + 1] : 0); // To avoid overflow when i+1 is out of range
            }

            Console.WriteLine("Array B:");
            foreach (int num in arrayB)
            {
                Console.WriteLine(num);
            }
        }

        public static void Exercise5a()
        {
            int[] array = new int[20];
            Random random = new Random();

            // Fill the array with random integers
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(1, 101); // Generates random integer between 1 and 100 (inclusive)
            }

            // Print out the array
            Console.WriteLine("Array of random integers:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            // Ask user for an integer to search
            Console.Write("Enter an integer to search in the array: ");
            int searchNumber;
            if (!int.TryParse(Console.ReadLine(), out searchNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            // Search the array for the entered integer
            bool found = false;
            foreach (int num in array)
            {
                if (num == searchNumber)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"The array contains the integer {searchNumber}.");
            }
            else
            {
                Console.WriteLine($"The array does not contain the integer {searchNumber}.");
            }
        }

        public static void Exercise5b()
        {
            int[] array = new int[20];
            Random random = new Random();

            // Fill the array with random integers
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(1, 101); // Generates random integer between 1 and 100 (inclusive)
            }

            // Print out the array
            Console.WriteLine("Array of random integers:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            // Ask user for an integer to search
            Console.Write("Enter an integer to search in the array: ");
            int searchNumber;
            if (!int.TryParse(Console.ReadLine(), out searchNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            // Search the array for the entered integer
            bool found = false;
            int maxNumber = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                    maxIndex = i;
                }

                if (array[i] == searchNumber)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"The array contains the integer {searchNumber}.");
            }
            else
            {
                Console.WriteLine($"The array does not contain the integer {searchNumber}.");
            }

            Console.WriteLine($"The maximum number in the array is {maxNumber} at index {maxIndex}.");
        }

        public static void Exercise6()
        {
            int[] numbers = new int[10];
            int sum = 0;
            int largest = int.MinValue;
            int smallest = int.MaxValue;

            // Read 10 positive numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter positive number {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]) || numbers[i] <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    i--; // Decrement i to re-prompt for the current position
                }
                else
                {
                    // Update sum
                    sum += numbers[i];

                    // Update largest
                    if (numbers[i] > largest)
                    {
                        largest = numbers[i];
                    }

                    // Update smallest
                    if (numbers[i] < smallest)
                    {
                        smallest = numbers[i];
                    }
                }
            }

            // Calculate arithmetic mean
            double mean = (double)sum / 10;

            // Print the values
            Console.WriteLine($"Addition of the numbers: {sum}");
            Console.WriteLine($"Arithmetic mean of the numbers: {mean}");
            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Smallest number: {smallest}");
        }

        public static void Exercise7()
        {
            int[] numbers = new int[5]; // Initial capacity set to 5
            int count = 0; // Number of elements currently in the array
            string userInput;

            do
            {
                Console.Write("Enter a positive number (or 'q' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    break;
                }

                int number;
                if (!int.TryParse(userInput, out number) || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer or 'q' to quit.");
                    continue;
                }

                // Check if array capacity needs to be increased
                if (count == numbers.Length)
                {
                    // Create a new array with increased capacity
                    int[] newArray = new int[numbers.Length * 2];
                    Array.Copy(numbers, newArray, numbers.Length);
                    numbers = newArray;
                }

                // Add the number to the array
                numbers[count] = number;
                count++;

            } while (true);

            if (count == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            // Calculate sum, mean, largest, and smallest
            int sum = 0;
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            foreach (int num in numbers)
            {
                sum += num;
                if (num > largest)
                {
                    largest = num;
                }
                if (num < smallest)
                {
                    smallest = num;
                }
            }

            double mean = (double)sum / count;

            // Print the values
            Console.WriteLine($"Addition of the numbers: {sum}");
            Console.WriteLine($"Arithmetic mean of the numbers: {mean}");
            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Smallest number: {smallest}");
        }

        public static void Exercise8()
        {
            // Arrays to store quantities and prices
            int[] quantities = new int[10]; // Initial capacity set to 10
            double[] prices = new double[10]; // Initial capacity set to 10
            int count = 0; // Number of products entered

            // Read quantities and prices for products
            string userInput;
            do
            {
                Console.Write("Enter quantity for product (or 'q' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    break;
                }

                int quantity;
                if (!int.TryParse(userInput, out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer or 'q' to quit.");
                    continue;
                }

                Console.Write("Enter price for product: ");
                double price;
                if (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the price.");
                    continue;
                }

                // Check if array capacity needs to be increased
                if (count == quantities.Length)
                {
                    // Create new arrays with increased capacity
                    int newCapacity = quantities.Length * 2;
                    int[] newQuantities = new int[newCapacity];
                    double[] newPrices = new double[newCapacity];

                    Array.Copy(quantities, newQuantities, quantities.Length);
                    Array.Copy(prices, newPrices, prices.Length);

                    quantities = newQuantities;
                    prices = newPrices;
                }

                // Add quantity and price to arrays
                quantities[count] = quantity;
                prices[count] = price;
                count++;

            } while (true);

            if (count == 0)
            {
                Console.WriteLine("No products entered.");
                return;
            }

            // Calculate subtotal cost
            double subtotal = 0;
            for (int i = 0; i < count; i++)
            {
                subtotal += quantities[i] * prices[i];
            }

            // Calculate tax (20%)
            double tax = subtotal * 0.20;

            // Calculate grand total
            double grandTotal = subtotal + tax;

            // Print the values
            Console.WriteLine($"Subtotal cost: {subtotal:C}");
            Console.WriteLine($"Tax (20%): {tax:C}");
            Console.WriteLine($"Grand total: {grandTotal:C}");
        }

        public static void Exercise9(int[] numbers)
        {
            List<List<int>> subsets = new List<List<int>>();

            // Iterate over all possible subsets
            for (int i = 0; i < (1 << numbers.Length); i++)
            {
                List<int> subset = new List<int>();
                int sum = 0;

                // Check which elements are included in the current subset
                for (int j = 0; j < numbers.Length; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        subset.Add(numbers[j]);
                        sum += numbers[j];
                    }
                }

                // If sum is 0, add the subset to the list of subsets
                if (sum == 0)
                {
                    subsets.Add(subset);
                }
            }

            // Print the subsets with sum 0
            if (subsets.Count == 0)
            {
                Console.WriteLine("No subsets found with sum 0.");
            }
            else
            {
                foreach (var subset in subsets)
                {
                    Console.WriteLine(string.Join(", ", subset));
                }
            }
        }

        public static void Exercise10(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                // Swap elements at start and end indices
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                // Move to the next pair of elements
                start++;
                end--;
            }
        }
    }
}


