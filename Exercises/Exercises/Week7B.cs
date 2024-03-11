using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Week7B
    {
        public static void Exercise1()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(234564, "Joe Blog");
        }

        public static void Exercise2()
        {
            // Create a dictionary to store student counts
            Dictionary<string, int> studentCounts = new Dictionary<string, int>();

            // Add data for each programming language course
            studentCounts.Add("Csharp", 90);
            studentCounts.Add("Java", 120);
            studentCounts.Add("Python", 208); // Corrected typo (lowercase 'p')
            studentCounts.Add("Php", 72);

            // Print the student counts for each language
            Console.WriteLine("Student counts per programming language:");
            foreach (KeyValuePair<string, int> course in studentCounts)
            {
                Console.WriteLine($"- {course.Key}: {course.Value}");
            }
        }

        public static void Exercise3()
        {
            // Create a dictionary to store student counts
            Dictionary<string, int> studentCounts = new Dictionary<string, int>();

            // Add data for each programming language course
            studentCounts.Add("Csharp", 90);
            studentCounts.Add("Java", 120);
            studentCounts.Add("Python", 208);
            studentCounts.Add("Php", 72);

            // Retrieve and display all data
            Console.WriteLine("All data in the dictionary:");
            foreach (KeyValuePair<string, int> course in studentCounts)
            {
                Console.WriteLine($"- {course.Key}: {course.Value}");
            }
        }

        public static void Exercise4()
        {
            // Create a dictionary to store student counts
            Dictionary<string, int> studentCounts = new Dictionary<string, int>();

            // Add data for each programming language course
            studentCounts.Add("Csharp", 90);
            studentCounts.Add("Java", 120);
            studentCounts.Add("Python", 208);
            studentCounts.Add("Php", 72);

            // Get student count for C# module
            string courseName = "Csharp"; // Case-sensitive matching
            if (studentCounts.ContainsKey(courseName))
            {
                int studentCount = studentCounts[courseName];
                Console.WriteLine($"Number of students in {courseName}: {studentCount}");
            }
            else
            {
                Console.WriteLine($"Course '{courseName}' not found in the dictionary.");
            }
        }

        public static void Exercise5()
        {
            // Create a dictionary to store student counts
            Dictionary<string, int> studentCounts = new Dictionary<string, int>();

            // Add data for each programming language course
            studentCounts.Add("Csharp", 90);
            studentCounts.Add("Java", 120); // Initial value
            studentCounts.Add("Python", 208);
            studentCounts.Add("Php", 72);

            // Update student count for Java module
            string courseName = "Java";
            studentCounts[courseName] = 130; // Update value using key

            // Print updated data (optional)
            Console.WriteLine("Updated student counts:");
            foreach (KeyValuePair<string, int> course in studentCounts)
            {
                Console.WriteLine($"- {course.Key}: {course.Value}");
            }
        }

        public static void Exercise6()
        {
            // Create a dictionary with key-value pairs
            Dictionary<int, string> elements = new Dictionary<int, string>()
        {
            { 1, "H" },
            { 2, "He" },
            { 3, "Li" },
            { 4, "Be" },
            { 5, "B" },
        };

            // Print element information
            Console.WriteLine("Elements and their Atomic Numbers:");
            foreach (KeyValuePair<int, string> element in elements)
            {
                Console.WriteLine($"- Atomic Number: {element.Key}, Symbol: {element.Value}");
            }
        }

        public static void Exercise7()
        {
            // Create a dictionary with key-value pairs
            Dictionary<int, string> elements = new Dictionary<int, string>()
        {
            { 1, "H" },
            { 2, "He" },
            { 3, "Li" },
            { 4, "Be" },
            { 5, "B" },
        };

            // Print element information
            Console.WriteLine("Elements and their Atomic Numbers:");
            foreach (KeyValuePair<int, string> element in elements)
            {
                Console.WriteLine($"- Atomic Number: {element.Key}, Symbol: {element.Value}");
            }
        }

        public static void Exercise8()
        {
            // Create a dictionary with key-value pairs
            Dictionary<int, string> elements = new Dictionary<int, string>()
        {
            { 1, "H" },
            { 2, "He" },
            { 3, "Li" },
            { 4, "Be" },
            { 5, "B" },
        };

            // Remove entry with atomic number 4
            int keyToRemove = 4;
            if (elements.ContainsKey(keyToRemove))
            {
                elements.Remove(keyToRemove);
                Console.WriteLine($"Removed element with atomic number: {keyToRemove}");
            }
            else
            {
                Console.WriteLine($"Element with atomic number {keyToRemove} not found in the dictionary.");
            }

            // Print updated dictionary data
            Console.WriteLine("\nElements and their Atomic Numbers (after removal):");
            foreach (KeyValuePair<int, string> element in elements)
            {
                Console.WriteLine($"- Atomic Number: {element.Key}, Symbol: {element.Value}");
            }
        }

        public static void Exercise9()
        {
            // Create a dictionary with key-value pairs (sorted by key)
            SortedDictionary<int, string> elements = new SortedDictionary<int, string>()
        {
            { 1, "H" },
            { 2, "He" },
            { 3, "Li" },
            { 4, "Be" },
            { 5, "B" },
        };

            // Print element information
            Console.WriteLine("Elements and their Atomic Numbers (Sorted):");
            foreach (KeyValuePair<int, string> element in elements)
            {
                Console.WriteLine($"- Atomic Number: {element.Key}, Symbol: {element.Value}");
            }
        }

  
    }
}
