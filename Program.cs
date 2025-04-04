﻿// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 12, 35, 1, 10, 34, 1, 35 };
//            int secLarge = 0;
//            int large = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > large)
//                {
//                    secLarge = large;
//                    large = array[i];
//                }
//                if (array[i] > secLarge && array[i] < large)
//                {
//                    secLarge = array[i];
//                }
//            }
//            Console.WriteLine(secLarge);
//        }
//    }
//}


// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int reversed = 0;
//            while (n > 0)
//            {
//                int reminder = n % 10;
//                reversed = reversed * 10 + reminder;
//                n /= 10;
//            }
//            Console.WriteLine(reversed);
//        }
//    }
//}

// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;
//            b = a - b;
//            a = a - b;

//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//    }
//}

// ]3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "listen";
//            string str2 = "silemt";
//            if (isAnagram(str1, str2))
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }

//        public static bool isAnagram(string str1, string str2)
//        {
//            int[] array = new int[256];
//            for (int i = 0; i < str1.Length; i++)
//            {
//                array[str1[i]]++;
//                array[str2[i]]--;
//            }
//            foreach (var i in array)
//            {
//                if (i != 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

// 4. Find the reverse of the string.
//using System;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            var reversed = str.Reverse().ToArray();
//            reversed.ToString();
//            Console.WriteLine(reversed);
//        }
//    }
//}


// 6. WAP to find the given string is Palindrome or not.
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "abbna";
            if (isPalindrome(str))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        public static bool isPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}