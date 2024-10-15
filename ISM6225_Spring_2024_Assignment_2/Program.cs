using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4};
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                int n = nums.Length;
                IList<int> missingNumbers = new List<int>();

                // Find the missing numbers in the array
                for (int i = 1; i <= n; i++)
                {
                    if (!nums.Contains(i))
                    {
                        missingNumbers.Add(i);   
                    }
                }

                return missingNumbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();

                // Separe the numbers into even and odd lists
                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        evens.Add(num);
                    }
                    else
                    {
                        odds.Add(num);
                    }
                }

                // Combine the lists to make the sorted array
                int[] sortedArray = evens.Concat(odds).ToArray();
                return sortedArray;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                int n = nums.Length;
                int[] indices = null;

                // Run the loop to find the sum combination
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            indices = new int[] { i, j };
                            break; // Break out of the loop as indices are found
                        }
                    }
                    if (indices != null)
                        break; // Break out of the loop again as indices are found          
                }

                return indices;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                int n = nums.Length;

                // The product of 3 biggest (positive) numbers should return the greatest value
                int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3]; 
                // If the array contains negative numbers, the product of 2 smallest negative will return a positive value
                // Multiply that by the largest positive numbers might return the greatest product possible
                int product2 = nums[0] * nums[1] * nums[n - 1];

                int maxProduct = Math.Max(product1, product2); // Compare the two options
                return maxProduct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                string binary = Convert.ToString(decimalNumber, 2);
                return binary;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                Array.Sort(nums);
                int minElement = nums[0];
                return minElement;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Reverse the digits of number x
                char[] digits = x.ToString().ToCharArray();
                Array.Reverse(digits);
                string reversedString = new string(digits);
                int newX = int.Parse(reversedString);

                // Check to see if x is a palindrome number
                bool palindrome = false;
                if (newX == x)
                {
                    palindrome = true;
                }

                return palindrome;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Apply the constraint
                if (n < 0 || n > 30)
                {
                    throw new Exception("n must be between 0 and 30");
                }
                
                // Calculate the Fibonacci
                if (n <= 1)
                    {
                        return n;
                    }
                return Fibonacci(n - 1) + Fibonacci(n - 2);
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
