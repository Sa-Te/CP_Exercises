using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week4
    {
        public static int Exercise6(int a, int b, int c)
        {
            int biggest;
            if (a > b)
            {
                biggest = a;
                if (biggest < c)
                {
                    biggest = c;
                }
            }
            else
            {
                biggest = b;
                if (biggest < c)
                {
                    biggest = c;
                }
            }
            return biggest;
        }

        public static void Exercise7()
        {
            // Get three real numbers from the user
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double temp;
            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;

                if (num1 < num3)
                {
                    temp = num1;
                    num1 = num3;
                    num3 = temp;
                }
            }
            else
            {
                if (num1 < num3)
                {
                    temp = num1;
                    num1 = num3;
                    num3 = temp;
                }
            }

            if (num2 < num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }

            Console.WriteLine("Sorted numbers in Descending order: {0}, {1}, {2}", num1, num2, num3);
        }

        public static void Exercise8()
        {
            Console.WriteLine("Enter a digit (0-9): ");
            int digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.WriteLine("Its Zero");
                    break;
                case 1:
                    Console.WriteLine("Its Onety-One");
                    break;
                case 2:
                    Console.WriteLine("Its Two");
                    break;
                case 3:
                    Console.WriteLine("Its Three");
                    break;
                case 4:
                    Console.WriteLine("Its Four");
                    break;
                case 5:
                    Console.WriteLine("Its five");
                    break;
                case 6:
                    Console.WriteLine("its Six");
                    break;
                case 7:
                    Console.WriteLine("Its Seven");
                    break;
                case 8:
                    Console.WriteLine("Its Eight");
                    break;
                case 9:
                    Console.WriteLine("its Nine");
                    break;
                default:
                    Console.WriteLine("Invalid Input: [USAGE: Enter any number between 0-9");
                    break;
            }
        }

        public static void Exercise9()
        {
            Console.WriteLine("This programs finds the real roots if given the three coefficients for a quadratic equation: ");
            Console.WriteLine("Give the Coefficient 'a': ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the Coefficient 'b': ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the Coefficient 'c': ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            //discriminant check

            if (discriminant > 0)
            {
                Console.WriteLine($"The discriminant is {discriminant}, therefore the equation have two distinct real roots ");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"The discriminant is {discriminant}, therefore the equation have one repeated real root ( a double root)");
            }
            else
            {
                Console.WriteLine($"The discriminant is {discriminant}, therefore the equation have no real roots and only complex roots");

            }


        }

        public static void Exercise10()
        {
            // Get five numbers from the user
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the {0}th number: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find the greatest using Math.Max() method
            int greatest = numbers.Max();

            // Print the greatest number
            Console.WriteLine("The greatest number is: {0}", greatest);
        }

        public static void Exercise11()
        {
            int choice;
            string input, output;
            double doubleInput;

            // Get user's choice
            Console.WriteLine("Enter 1 for int, 2 for double, or 3 for string:");
            choice = Convert.ToInt32(Console.ReadLine());

            // Get user input based on choice
            switch (choice)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    input = Console.ReadLine();
                    int intInput = Convert.ToInt32(input);
                    output = (intInput + 1).ToString();
                    break;
                case 2:
                    Console.Write("Enter a double: ");
                    input = Console.ReadLine();
                    doubleInput = Convert.ToDouble(input);
                    output = (doubleInput + 1).ToString();
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    output = input + "*";
                    break;
                default:
                    output = "Invalid choice.";
                    break;
            }

            // Print the result
            Console.WriteLine("Output: " + output);
        }

        public static void Exercise13()
        {
            string correctUsername = "Mo";
            string correctPassword = "hellomo"; // Store password securely, not in plain text!

            // Maximum allowed attempts
            const int maxAttempts = 3;

            // Counter for attempts
            int attempts = 0;

            // Loop for login attempts
            while (attempts < maxAttempts)
            {
                // Ask for user input
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                // Check if credentials match
                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Incorrect login. Attempts remaining: {maxAttempts - attempts}");
                }
            }
            // Login failed after all attempts
            Console.WriteLine("Login rejected. Maximum attempts reached.");
        }

        public static void Exercise14(int start, int end)
        {
            for (int y = start; y <= end; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y} x = {x}");
            }
        }

        public static void Exercise15a()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise15b()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise15c()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise16()
        {
            for (int i = 1; i <= 100; i++)
            {
                // Check if the number is divisible by 3 using modulo operator
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Exercise17()
        {
            // Get user input for number of terms
            Console.Write("Enter the number of terms: ");
            int numTerms = Convert.ToInt32(Console.ReadLine());

            // Get user input for first term
            Console.Write("Enter the first term: ");
            int firstTerm = Convert.ToInt32(Console.ReadLine());

            // Get user input for increment
            Console.Write("Enter the increment: ");
            int increment = Convert.ToInt32(Console.ReadLine());

            // Print the series using a loop
            for (int i = 0; i < numTerms; i++)
            {
                Console.Write($"{firstTerm + i * increment} ");
            }

            Console.WriteLine();
        }

        public static void Exercise18()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Get user input for the second number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Check which number is larger using conditional statement
            int largest;
            if (num1 > num2)
            {
                largest = num1;
            }
            else
            {
                largest = num2;
            }

            // Print the largest number
            Console.WriteLine("The largest number is: {0}", largest);
        }

        public static void Exercise19()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Get user input for the second number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Check if the first number is divisible by the second
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else if (num1 % num2 == 0)
            {
                Console.WriteLine($"{num1} is divisible by {num2}.");
            }
            else
            {
                Console.WriteLine($"{num1} is not divisible by {num2}.");
            }
        }

        public static void Exercise20()
        {
            Console.Write("Enter a score between 1 and 9: ");
            int score = Convert.ToInt32(Console.ReadLine());

            // Validate the score range
            if (score < 1 || score > 9)
            {
                Console.WriteLine("Invalid score. Please enter a score between 1 and 9.");
                return;
            }

            // Apply bonus points based on score range
            int bonus = 0;
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    bonus = score * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    bonus = score * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    bonus = score * 1000;
                    break;
            }

            // Calculate and print the new score
            int newScore = score + bonus;
            Console.WriteLine($"Your score after applying the bonus is: {newScore}");
        }

        public static void Exercise21(double a, double b, double c)
        {
            // Check for zero directly in the first condition
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product is 0.");
                return;
            }

            // Count negative numbers using a boolean flag and a counter
            bool isNegative = false;
            int negativeCount = 0;

            if (a < 0)
            {
                isNegative = true;
                negativeCount++;
            }
            if (b < 0)
            {
                isNegative = !isNegative; // Toggle if different from previous sign
                negativeCount++;
            }
            if (c < 0)
            {
                isNegative = !isNegative; // Toggle if different from previous sign
                negativeCount++;
            }

            // Determine product sign based on sign combination and negative count
            if (negativeCount == 0 || negativeCount % 2 == 0)
            {
                Console.WriteLine("The product is positive (+).");
            }
            else
            {
                Console.WriteLine("The product is negative (-).");
            }
        }

        public static void Exercise23()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Use the modulo operator to check for divisibility by 2
            bool isEven = number % 2 == 0;

            // Print the result based on the boolean flag
            if (isEven)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }

        public static void Exercise24(int age)
        {
            // Validate age input
            if (age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a non-negative age.");
                return;
            }

            // Calculate base price and discount
            double basePrice = 7.0;
            double discount = 0.0;

            if (age < 5)
            {
                discount = 0.6; // 60% discount for children under 5
            }
            else if (age > 60)
            {
                discount = 0.55; // 55% discount for people over 60
            }

            // Apply discount and calculate final price
            double finalPrice = basePrice * (1 - discount);

            // Format and print the price
            Console.WriteLine($"The ticket price for your age ({age}) is £{finalPrice:0.00}.");
        }

        public static void Exercise25()
        {
            // Initialize variables to hold the smallest value and the first input
            int smallest = int.MaxValue; // Start with maximum possible value
            int num;

            // Read five integer values using a loop
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter integer {i}: ");
                num = Convert.ToInt32(Console.ReadLine());

                // Update smallest if the current number is smaller
                if (num < smallest)
                {
                    smallest = num;
                }
            }

            // Print the smallest value
            Console.WriteLine($"The smallest number entered is: {smallest}");
        }

        public static void Exercise26()
        {
            int[] values = new int[3];

            // Read three integer values into the array
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sort the array in descending order using a loop
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] < values[j])
                    {
                        int temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }

            // Print the sorted values in descending order
            Console.WriteLine("The values in descending order are:");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        public static void Exercise27(string input)
        {
            int value;
            bool isInteger = int.TryParse(input, out value);

            if (isInteger)
            {
                Console.WriteLine($"{input} is an integer.");
            }
            else
            {
                Console.WriteLine($"{input} is not an integer.");
            }

            int value2;

            switch (int.TryParse(input, out value2))
            {
                case true:
                    Console.WriteLine($"{input} is an integer.");
                    break;
                case false:
                    Console.WriteLine($"{input} is not an integer.");
                    break;
            }
        }

        public static void Exercise28()
        {
            Console.WriteLine("This program calculates the area of three shapes:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Trapezoid");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("Please choose a shape (1, 2, or 3): ");

            // Get user input for shape choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // Process user choice and calculate area based on input
            switch (choice)
            {
                case 1: // Triangle
                    Console.WriteLine("Enter the base and height of the triangle: ");
                    double baseTriangle = Convert.ToDouble(Console.ReadLine());
                    double heightTriangle = Convert.ToDouble(Console.ReadLine());
                    double areaTriangle = 0.5 * baseTriangle * heightTriangle;
                    Console.WriteLine($"The area of the triangle is: {areaTriangle:0.##}");
                    break;
                case 2: // Trapezoid
                    Console.WriteLine("Enter the bases (a and b) and height of the trapezoid: ");
                    double baseATrapezoid = Convert.ToDouble(Console.ReadLine());
                    double baseBTrapezoid = Convert.ToDouble(Console.ReadLine());
                    double heightTrapezoid = Convert.ToDouble(Console.ReadLine());
                    double areaTrapezoid = 0.5 * (baseATrapezoid + baseBTrapezoid) * heightTrapezoid;
                    Console.WriteLine($"The area of the trapezoid is: {areaTrapezoid:0.##}");
                    break;
                case 3: // Rectangle
                    Console.WriteLine("Enter the base and height of the rectangle: ");
                    double baseRectangle = Convert.ToDouble(Console.ReadLine());
                    double heightRectangle = Convert.ToDouble(Console.ReadLine());
                    double areaRectangle = baseRectangle * heightRectangle;
                    Console.WriteLine($"The area of the rectangle is: {areaRectangle:0.##}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        public static void Exercise29()
        {
            // Initialize variables
            int count = 0;
            double sum = 0.0;
            double largest = double.MinValue; // Use MinValue for initial comparison
            double smallest = double.MaxValue; // Use MaxValue for initial comparison

            // Read 10 positive numbers
            while (count < 10)
            {
                Console.Write("Enter a positive number: ");
                string input = Console.ReadLine();

                // Validate input and convert to double
                if (double.TryParse(input, out double number) && number > 0)
                {
                    count++;
                    sum += number;

                    // Update largest and smallest values
                    largest = Math.Max(largest, number);
                    smallest = Math.Min(smallest, number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            // Calculate and print results
            if (count == 10) // Ensure all 10 numbers were read successfully
            {
                double average = sum / count;
                Console.WriteLine($"Sum of numbers: {sum}");
                Console.WriteLine($"Arithmetic mean: {average:0.##}");
                Console.WriteLine($"Largest number: {largest}");
                Console.WriteLine($"Smallest number: {smallest}");
            }
            else
            {
                Console.WriteLine("Error: Not all numbers were positive.");
            }
        }

        public static void Exercise30()
        {
            // Get user input and validate as a positive integer
            Console.Write("Enter a non-negative integer: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            // Calculate factorial using a loop
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;

                // Check for potential overflow and handle accordingly
                if (factorial < 0)
                {
                    Console.WriteLine("Error: Overflow occurred during factorial calculation.");
                    return;
                }
            }

            // Print the result
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        public static void Exercise31(int size)
        {
            // Validate input (positive integer)
            if (size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Build the square using a loop for each row and inner loop for columns
            for (int i = 0; i < size; i++)
            {
                // Print leading spaces before each row (except first)
                if (i > 0)
                {
                    Console.Write(new string(' ', size - i));
                }

                // Print asterisks for the current row
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }

                // Move to the next line after each row
                Console.WriteLine();
            }
        }

        public static void Exercise32()
        {
            // Get user input and validate for positive integer
            Console.Write("Enter a non-negative integer: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            long factorial = 1;
            int i = 1;
            while (i <= number)
            {
                long temp = factorial * i; // Store the potential result before multiplication
                if (temp / i != factorial) // Check if overflow occurred
                {
                    Console.WriteLine("Error: Overflow occurred during factorial calculation.");
                    break;
                }
                factorial = temp; // Update factorial only if no overflow
                i++;
            }

            // Print the result
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        public static void Exercise33()
        {
            // Get user input and validate for positive integer
            Console.Write("Enter a non-negative integer: ");
            int number;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                }
            } while (number < 0); // Ensure number is positive before proceeding

            // Calculate factorial using a do-while loop
            long factorial = 1;
            int i = 1;
            do
            {
                factorial *= i;
                if (factorial < 0) // Check for overflow
                {
                    Console.WriteLine("Error: Overflow occurred during factorial calculation.");
                    break;
                }
                i++;
            } while (i <= number);

            // Print the result
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        public static void Exercise34()
        {
            // Initialize variables
            double subtotal = 0.0;
            double tax = 0.2; // 20% tax rate

            // Use a loop to handle multiple products
            bool continueShopping = true;
            while (continueShopping)
            {
                // Get product quantity and price
                Console.Write("Enter quantity for product: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price for product: ");
                double price = Convert.ToDouble(Console.ReadLine());

                // Calculate product total
                double productTotal = quantity * price;

                // Update subtotal and tax
                subtotal += productTotal;

                // Ask if user wants to add more products
                Console.Write("Do you want to add more products? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                continueShopping = answer == "y";
            }

            // Calculate grand total
            double grandTotal = subtotal * (1 + tax);

            // Print results
            Console.WriteLine($"Subtotal cost: ${subtotal:0.00}");
            Console.WriteLine($"Tax (20%): ${tax * subtotal:0.00}");
            Console.WriteLine($"Grand total: ${grandTotal:0.00}");
        }

        public static void Exercise35()
        {
            // Initialize variables
            double subtotal = 0.0;
            double tax = 0.2; // 20% tax rate

            // Use a loop to handle multiple products
            bool continueShopping = true;
            while (continueShopping)
            {
                // Get product quantity and price
                while (true)
                {
                    try
                    {
                        Console.Write("Enter quantity for product: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        // Validate positive integer quantity
                        if (quantity <= 0)
                        {
                            throw new ArgumentException("Quantity must be a positive integer.");
                        }

                        Console.Write("Enter price for product: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        // Calculate product total
                        double productTotal = quantity * price;

                        // Update subtotal and tax
                        subtotal += productTotal;

                        // If no exception occurred, break the inner loop
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for quantity and price.");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Ask if user wants to add more products
                Console.Write("Do you want to add more products? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                continueShopping = answer == "y";
            }

            // Calculate grand total
            double grandTotal = subtotal * (1 + tax);

            // Print results
            Console.WriteLine($"Subtotal cost: ${subtotal:0.00}");
            Console.WriteLine($"Tax (20%): ${tax * subtotal:0.00}");
            Console.WriteLine($"Grand total: ${grandTotal:0.00}");
        }

        public static void Exercise36(int number)
        {
            // Validate input (positive integer)
            if (number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Variables for calculation
            int sum = 0;
            int evenCount = 0;
            int oddCount = 0;

            // Extract each digit and process
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;

                if (digit % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                number /= 10;
            }

            // Print results
            Console.WriteLine($"Sum of digits: {sum}");
            Console.WriteLine($"Number of even digits: {evenCount}");
            Console.WriteLine($"Number of odd digits: {oddCount}");
        }

        public static void Exercise37()
        {
            Console.Write("\t");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            // Multiplication table
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{i}\t");
                for (int j = 1; j <= 12; j++)
                {
                    int product = i * j;
                    Console.Write($"{product}\t");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise38()
        {
            // Print header row
            Console.Write("\t");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            // Print multiplication table
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{i}\t");
                for (int j = 1; j <= 12; j++)
                {
                    int product = i * j;
                    Console.Write($"{product}\t");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise39()
        {
            // Loop through all possible thousands digits (1 to 9)
            for (int a = 1; a <= 9; a++)
            {
                // Loop through all possible hundreds digits (0 to 9)
                for (int b = 0; b <= 9; b++)
                {
                    // Loop through all possible tens digits (0 to 9)
                    for (int c = 0; c <= 9; c++)
                    {
                        // Loop through all possible units digits (0 to 9)
                        for (int d = 0; d <= 9; d++)
                        {
                            // Check if the sum of digits at the beginning and end match
                            if (a + b == c + d)
                            {
                                // Print the happy number
                                Console.WriteLine($"{a}{b}{c}{d}");
                            }
                        }
                    }
                }
            }
        }

        public static void Exercise40()
        {
            // Loop through all possible numbers for first digit (1 to 49)
            for (int a = 1; a <= 49; a++)
            {
                // Nested loop for second digit (a+1 to 49) to avoid duplicates
                for (int b = a + 1; b <= 49; b++)
                {
                    // Nested loop for third digit (b+1 to 49)
                    for (int c = b + 1; c <= 49; c++)
                    {
                        // Nested loop for fourth digit (c+1 to 49)
                        for (int d = c + 1; d <= 49; d++)
                        {
                            // Nested loop for fifth digit (d+1 to 49)
                            for (int e = d + 1; e <= 49; e++)
                            {
                                // Nested loop for sixth digit (e+1 to 49)
                                for (int f = e + 1; f <= 49; f++)
                                {
                                    // Print the combination
                                    Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Exercise41(string binaryString)
        {
            // Validate input (non-empty string)
            if (string.IsNullOrWhiteSpace(binaryString))
            {
                throw new ArgumentException("Input string cannot be empty or whitespace.");
            }

            // Ensure all characters are valid binary digits (0 or 1)
            foreach (char c in binaryString)
            {
                if (c != '0' && c != '1')
                {
                    throw new ArgumentException("Input string contains invalid characters. Only '0' and '1' are allowed.");
                }
            }

            int decimalValue = 0;
            int power = 0;

            // Iterate through each character from right to left
            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                int digit = binaryString[i] - '0'; // Convert char to int (0 or 1)
                decimalValue += digit * (int)Math.Pow(2, power);
                power++;
            }

            return decimalValue;
        }

        public static void Exercise42()
        {
            string input;

            // Loop until user enters 'q'
            while (true)
            {
                Console.Write("Enter a positive decimal number (or 'q' to quit): ");
                input = Console.ReadLine().ToLower();

                // Check for 'q' to quit
                if (input == "q")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                // Validate input (positive integer)
                int number;
                if (!int.TryParse(input, out number) || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    continue;
                }

                // Convert decimal to binary using string building
                string binaryString = "";
                while (number > 0)
                {
                    // Get the remainder (last digit) and prepend it to the string
                    binaryString = (number % 2).ToString() + binaryString;
                    number /= 2;
                }

                // Print the binary equivalent
                Console.WriteLine($"Binary equivalent: {binaryString}");
            }
        }

        public static int Exercise43(string hexString)
        {
            // Validate input (non-empty string)
            if (string.IsNullOrWhiteSpace(hexString))
            {
                throw new ArgumentException("Input string cannot be empty or whitespace.");
            }

            // Ensure all characters are valid hexadecimal digits (0-9, A-F, a-f)
            foreach (char c in hexString)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                {
                    throw new ArgumentException("Input string contains invalid characters. Only '0-9', 'A-F', and 'a-f' are allowed.");
                }
            }

            int decimalValue = 0;
            int power = hexString.Length - 1;

            // Iterate through each character from right to left
            for (int i = 0; i < hexString.Length; i++)
            {
                char c = hexString[i];
                int digit;

                // Convert character to decimal value (0-15)
                if (c >= '0' && c <= '9')
                {
                    digit = c - '0';
                }
                else if (c >= 'A' && c <= 'F')
                {
                    digit = c - 'A' + 10;
                }
                else // c >= 'a' && c <= 'f'
                {
                    digit = c - 'a' + 10;
                }

                decimalValue += digit * (int)Math.Pow(16, power);
                power--;
            }

            return decimalValue;
        }
    }
}
