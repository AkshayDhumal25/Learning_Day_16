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
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "abbna";
//            if (isPalindrome(str))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }

//        public static bool isPalindrome(string str)
//        {
//            int left = 0;
//            int right = str.Length - 1;
//            while (left < right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}


// 7. WAP to print Fibonacci series with recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(fibo(i));
//            }
//        }
//        public static int fibo(int n)
//        {
//            if (n <= 1) return n;
//            return fibo(n - 1) + fibo(n - 2);
//        }
//    }
//}

// Method Hiding
//using System;
//namespace methodHiding
//{
//    class Parent
//    {
//        public void Print()
//        {
//            Console.WriteLine("Parent Class Method");
//        }
//    }
//    class Child : Parent
//    {
//        public new void Print()
//        {
//            Console.WriteLine("Child Class Method");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Parent p = new Parent();
//            p.Print();
//            Child c = new Child();
//            c.Print();
//            Parent cp = new Child();
//            cp.Print();
//        }
//    }
//}


//Encapsulation
//using System;
//namespace encapsulation
//{
//    class rectangleArea
//    {
//        private double length;
//        private double width;

//        public double Length
//        {
//            get { return length; }
//            set { length = value; }
//        }
//        public double Width
//        {
//            get { return width; }
//            set { width = value; }
//        }
//        public double getArea()
//        {
//            return length * width;
//        }

//        public void Print()
//        {
//            Console.WriteLine($"Length: {length} and Width: {width}");
//            Console.WriteLine("Area : " + getArea());
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            rectangleArea r = new rectangleArea();
//            r.Length = 9.0;
//            r.Width = 9.0;
//            r.Print();
//        }
//    }
//}


//Generics
//using System;
//namespace generics
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st Element : ");
//            var a = Console.ReadLine();
//            Console.WriteLine("Enter the 2nd Element : ");
//            var b = Console.ReadLine();

//            swap(ref a, ref b);
//        }

//        public static void swap<T>(ref T a, ref T b)
//        {
//            var temp = a;
//            a = b;
//            b = temp;

//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//    }
//}

// Diamond Problem
//using System;
//namespace diamondProblem
//{
//    interface IA
//    {
//        public void print()
//        {
//            Console.WriteLine("Interface A");
//        }
//    }
//    interface IB : IA { };
//    interface IC : IA { };
//    class D : IB, IC
//    {
//        public void print()
//        {
//            Console.WriteLine("Class D");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            D d = new D();
//            d.print();
//        }
//    }
//}


// 19. count lowercase and uppercase
// input = &quot;Hello world!&quot;
// output = uppercase = 1, lowercase = 9
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Hello World";
//            int upperCount = 0;
//            int lowerCount = 0;

//            for (int i = 0; i < str.Length; i++)
//            {
//                if (char.IsUpper(str[i]))
//                {
//                    upperCount++;
//                }
//                else
//                {
//                    lowerCount++;
//                }
//            }

//            Console.WriteLine($"Upper Count: {upperCount} and Lower Count {lowerCount}");
//        }
//    }
//}

// Abstraction
//using System;
//namespace abstraction
//{

//    abstract class Parent
//    {
//        public abstract void Print();
//    }
//    class Child : Parent
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Child Class");
//        }
//    }

//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Child cd = new Child();
//            cd.Print();
//        }
//    }
//}


// 12. WAP for getting a square root of a given number.
//using System;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            var res = Math.Sqrt(n);
//            Console.WriteLine("SquareRoot : " + res);
//        }
//    }
//}


// 11. Find prime numbers from 1 ....n
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
