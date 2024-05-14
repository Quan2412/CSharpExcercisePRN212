using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleExcercise_HE181258
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Excercise.Solution();
        }
    }

    public class Excercise
    {
        /*   Ex2
         *   public static void Solution()
           {
               Console.WriteLine("Enter an integer: ");
               int num = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter an integer: ");
               int num2 = int.Parse(Console.ReadLine());
               int sum = num + num2;
               Console.WriteLine($"The sum of 2 numbers = {sum}");
               Console.ReadKey();
           }
        */

        /* Ex4
           public static void Solution()
           {
               int function1 = -1 + 4 * 6;
               int function2 = (35 + 5) % 7;
               int function3 = 14 + -4 * 6 / 11;
               int function4 = 2 + 15 / 6 * 1 - 7 % 2;
               Console.WriteLine(function1);
               Console.WriteLine(function2);
               Console.WriteLine(function3);
               Console.WriteLine(function4);
               Console.ReadKey();
           }
        */

        /* Ex5
        public static void Solution()
        {
            Console.WriteLine("Input the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number");
            int num2 = int.Parse(Console.ReadLine());
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine($"First Number: {num1}");
            Console.WriteLine($"Second Number: {num2}");
            Console.ReadKey();  
        }
        */

        /* Ex6
        public static void Solution()
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine($"{num1} x {num2} x {num3} = {result}");
            Console.ReadKey();
        }
        */

        /* Ex8

        public static void Solution()
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} * {i} = {result}");
            }
            Console.ReadKey();
        }
        */

        /* Ex13
        public static void Solution()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                if(i == 0 || i == 5)
                {
                    Console.WriteLine($"{num}{num}{num}");
                }
                else
                {
                    Console.WriteLine($"{num} {num}");
                }              
            }
            Console.ReadKey();
        }
        */

        /* Ex17
        public static void Solution()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();    
            if(str.Length > 1)
            {
                var s = str.Substring(0,1);
                Console.Write(s + str + s);
            }
            else
            {
                Console.WriteLine("Not long enough");
            }
            Console.ReadKey();
        }
        */

        /* Ex19
        public static void Solution()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the seccond number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result;
            if( num1 == num2)
            {
                result = 3*(num1 + num2);
                Console.WriteLine($"Output: {result}");
            }
            else
            {
                result = num1 + num2;
                Console.WriteLine($"Output: {result}");
            }
            Console.ReadKey();
        }
        */

        /* Ex21
        public static void Solution()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if(num1 == 20 || num2 == 20 || num1 + num2 == 20)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();  
        }
        */

        /* Ex22
        public static void Solution()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if(Math.Abs(100 - num) <= 20 || Math.Abs(200 - num) <= 20)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
        */

        /* Ex23
        public static void Solution()
        {
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            String str2 = str.ToLower();
            Console.WriteLine($"Before convert: {str}");
            Console.WriteLine($"After convert: {str2}");
            Console.ReadKey();
        }
        */

        /* Ex24
        public static void Solution() 
        {
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            /// Seperate String using plit, with optional delimiter
            String[] words = str.Split(new[] { ' ' });
                /// or String words = str.Split(' ');
            int lenght = 0;
            String word = "";
            foreach (string s in words)
            {
                if(s.Length > lenght)
                {
                    word = s;
                    lenght = s.Length;
                }
            }
            Console.Write($"Longest word: {word}");
            Console.ReadKey();
        }
        */

        /* Ex27
        public static void Solution()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0) 
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of the digits: {sum}");
            Console.ReadKey();
        */

        /* Ex29
        public static void Solution()
        {
            Console.Write("Enter file path: ");
            String file = Console.ReadLine();
            FileInfo f = new FileInfo(file);
            Console.WriteLine($"File name = {f.Name}");
            Console.WriteLine($"File size = {f.Length} bytes");
            Console.ReadKey();
        }
        */

        /* Ex32
        public static void Solution()
        {
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();

            if (str.Length > 4)
            {
                String lastChar = str.Substring(str.Length - 4);
                Console.Write($"{lastChar} {lastChar} {lastChar} {lastChar}");
            }
            Console.ReadKey();
        }
        */

        /* Ex34
        public static void Solution()
        {
            Console.WriteLine($"This program is to check if the inputted string have the word {"Hello"} ");
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            String[] words = str.Split(new char[] { ' ' });
            Boolean valid = false;
            foreach( String word in words )
            {
                if (word.Equals("Hello"))
                {
                    valid = true;
                }
            }
            if(valid )
            {
                Console.WriteLine(true);
            }else { 
                Console.WriteLine(false); 
            } 
            Console.ReadKey();
        }
        */

        /* Ex36
        public static void Solution()
        {
            Console.Write("Enter the first number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if((-10 <= num && num <= 10) || (-10 <= num2 && num2 <= 10))
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
        */

        /* Ex41
        public static void Solution()
        {
            Console.WriteLine("This program is to check if there is a w between 1 and 3 times");
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            var word = str.Count(s => s == 'w');
            if (1 <= word && word <= 3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }   
            Console.ReadKey();
        }
        */

        /* Ex43
        public static void Solution()
        {
            Console.WriteLine("If there are less than 4 characters, convert the string to uppercase");
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            if(str.Length < 4)
            {
                Console.WriteLine($"Before convert: {str}");
                Console.WriteLine($"After conver: {str.ToUpper()}");
            }else
            {
                Console.WriteLine("Requirement not met, no convert done");
            }
            Console.ReadKey();
        }
        */

        /* Ex44
        public static void Solution()
        {
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            String newString = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if(i % 2 == 0)
                {
                    newString += str[i];
                }
            }
            Console.WriteLine($"Before convert: {str}");
            Console.WriteLine($"After conver: {newString}");
            Console.ReadKey();
        }
        */

        /* Ex47
        public static void Solution()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
        */

        /* Ex50
        public static void Solution()

        {
            int[] arr = { 1, 2, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr));
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int a = arr[left];
                arr[left] = arr[right];
                arr[right] = a;
                left++;
                right--;
            }
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", arr));
            Console.ReadKey();
        }
        */

        /* Ex51
        public static void Solution()
        {
            int[] arr = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr));
            int max = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Highest value between first and last values of the said array: " + max);
        }
        */

        /* Ex52
        public static void Solution()
        {
            int[] arr1 = { 1, 2, 5 };
            int[] arr2 = { 0, 3, 8 };
            int[] arr3 = { -1, 0, 2 };
            int[] arr4 = { arr1[1], arr2[1], arr3[1] };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));
            Console.WriteLine("Array3: [{0}]", string.Join(", ", arr3));
            Console.WriteLine("New Array: [{0}]", string.Join(", ", arr4));
            Console.ReadKey();
        }
        */

        /* Ex54
        public static void Solution(int year)
        {
            if (year < 0)
            {
                Console.WriteLine("Not valid year");
                return;
            }
            int century = year / 100 + 1;
            Console.WriteLine("Century of year {0} is {1}", year, century);
            Console.ReadKey();
        }
        */

        /* Ex55
        public static void Solution(int[] arr)
        {
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));
            if (arr.Length < 2)
            {
                Console.WriteLine("Array length must be greater than 2");
                return;
            }
            int product = arr[0] * arr[1];
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] * arr[i + 1] > product)
                {
                    product = arr[i] * arr[i + 1];
                    index = i;
                }
            }
            Console.ReadKey();
        }
        */

        /* Ex56
        public static void Solution()
        {
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                return;
            }
            char[] arr = s.ToCharArray();
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    Console.WriteLine("False");
                    return;
                }
                left++;
                right--;
            }
            Console.WriteLine("True");
            Console.ReadKey();
        }
        */

        /* Ex58
        public static void Solution(int[] arr, int min, int max)
        {
            int[] count = new int[max - min + 1];
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            int res = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 0)
                {
                    res++;
                }
            }
            Console.ReadKey();
        }
        */

        /* Ex61
        public static void Solution(int[] arr)
        {
            Console.WriteLine("Array: [{0}]", string.Join(", ", arr));
            // create a list to store num ber != -5 in arr
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (i != -5)
                    list.Add(i);
            }
            // sort the list
            list.Sort();
            int count = 0;
            // populate the elements in list to arr
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -5)
                {
                    arr[i] = list[count++];
                }
            }

            Console.WriteLine("After sorted: [{0}]", string.Join(", ", arr));
            Console.ReadKey();
        }
        */

        /* Ex62
        public static void Solution(string s)
        {
            // abc(de(fg)cd)dfa
            Console.WriteLine("String: " + s);
            while (s.Contains('('))
            {
                int openParenth = s.LastIndexOf('(');
                int closeParenth = s.IndexOf(')');
                s = s.Substring(0, openParenth)
                    + new string(s.Substring(openParenth + 1, closeParenth - openParenth - 1).Reverse().ToArray())
                    + s.Substring(closeParenth + 1);
            }
            Console.WriteLine("After reverse: " + s);
            Console.ReadKey();
        }
        */

        /* Ex64
        public static void Solution()
        {
            FileInfo fileInfo = new FileInfo(path);
            string fileName = fileInfo.FullName;
            Console.WriteLine("File name: " + fileName.Split('\\').Last());
        }

        private static void ex67(string s)
        {
            string res = s.Replace('P', '9')
                .Replace('T', '0')
                .Replace('S', '1')
                .Replace('H', '6')
                .Replace('A', '8');
            Console.WriteLine("String: " + s);
            Console.WriteLine("After replace: " + res);
            Console.ReadKey();
        }
        */

        /* Ex70
        public static void Solution(string s)
        {
            {
                if (s.Length < 3)
                {
                    Console.WriteLine("String length must greater than 2");
                    return;
                }

                string res = s.Remove(0, 1).Remove(s.Length - 2);
                Console.WriteLine("String: " + s);
                Console.WriteLine("After replace: " + res);
            }
            Console.ReadKey();
        }
        */

        /* Ex71
        public static void Solution(string s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine("False");
                    return;
                }
            }
            Console.WriteLine("True");
            Console.ReadKey();
        }
        */

        /* Ex72
        public static void Solution(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            if (sum % arr.Length == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
        */

        /* Ex73
        public static void Solution()
        {
            Console.WriteLine("Original string: " + s);
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string res = new string(chars);
            Console.WriteLine("Converted string: " + res);
            Console.ReadKey();
        }
        */

        /* Ex75
        public static void Solution(int num)
        {
            return num * 2 - 1;
        }
        */

        /* Ex76
        private static void Solution(char a)
        {
            Console.WriteLine("ASCII value of {0} is: {1}", a, (int)a);
            Console.ReadKey();
        }
        */

        /* Ex81
        public static void Solution(int num)
        {
            Console.WriteLine("Original number: " + num);
            int converted = swap(num);
            Console.WriteLine("Swapped number: " + converted);
            Console.WriteLine("Original value is larger than the swapped value: " + (num > converted));

            int swap(int n)
            {
                int res = 0;
                while (n > 0)
                {
                    res = res * 10 + n % 10;
                    n /= 10;
                }
                return res;
            }
            Console.ReadKey();  
        }
        */

        /* Ex82
        public static void Solution(string s)
        {
            Console.WriteLine("Original string: " + s);
            Regex regex = new Regex("[^a-zA-Z]");
            string res = regex.Replace(s, "");
            Console.WriteLine("After remove non-letter characters: " + res);
            Console.ReadKey();
        }
        */

        /* Ex83
        public static void Solution(string s)
        {
            Console.WriteLine("Original string: " + s);
            Regex regex = new Regex("[ueoaiUEOAI]");
            string res = regex.Replace(s, "");
            Console.WriteLine("After remove all vowels: " + res);
            Console.ReadKey();
        }
        */

        /* Ex84
        public static void Solution(string s)
        {
            Console.WriteLine("Original string: " + s);
            char[] arr = s.ToCharArray();
            Console.WriteLine("Indices of all lower case letter: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
        */

        /* Ex85
        public static void Solution(double[] arr)
        {
            Console.WriteLine("Original array: [{0}]", string.Join(",", arr));
            double sum = 0;
            double[] cumulative = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                cumulative[i] = sum;
            }
            Console.WriteLine("Cumulative sum: [{0}]", string.Join(",", cumulative));
            Console.ReadKey();
        }
        */

        /* Ex86
        public static void Solution(string s)
        {
            Console.WriteLine("Original string: " + s);
            int letterNums = s.Count(char.IsLetter);
            int digitNums = s.Count(char.IsDigit);
            Console.WriteLine("Number of letters: {0}, Number of digits: {1}", letterNums, digitNums);
            Console.ReadKey();
        }
        */

        /* Ex87
        public static void Solution(int sides)
        {
            Console.WriteLine("Sum of the interior angles of a polygon with {0} sides is {1}", sides, (sides - 2) * 180);
            Console.ReadKey();
        }
        */

        /* Ex90
        public static void Solution(int num)
        {
            // convert to binary
            string binary = Convert.ToString(num, 2);
            // count the number of one and zero
            int ones = 0;
            int zeros = 0;
            foreach (char i in binary)
            {
                if (i == '0') zeros++;
                if (i == '1') ones++;
            }

            Console.WriteLine("Number of ones: " + ones);
            Console.WriteLine("Number of zeros: " + zeros);
            Console.ReadKey();
        }
        */

        /* Ex91
        public static void Solution(object[] arr)
        {
            // use Linq OfType method
            Console.WriteLine("Original array: [{0}]", string.Join(", ", arr));
            int[] newArr = arr.OfType<int>().ToArray();
            Console.WriteLine("Original array: [{0}]", string.Join(", ", newArr));
            Console,ReadKey();
        }
        */

        /* Ex92
        public static void Solution()
        {
            Console.WriteLine("Original number: " + num);
            if (isPrime(num))
            {
                Console.WriteLine("Next prime number/Current prime number: " + num);
                return;
            }

            for (int i = num + 1; ;i++ )
            {
                if (isPrime(i))
                {
                    Console.WriteLine("Next prime number/Current prime number: " + i);
                    return;
                }
            }


            bool isPrime(int n)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
            Console.ReadKey();
        }
        */

        /*Ex93
        public static void Solution(int num)
        {
            int left = 0;
            int right = num;
            int middle = num / 2;
            int i = 10;
            while (i > 0)
            {
                if (middle * middle > num)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
                i--;
            }

            Console.WriteLine("({0}) -> {1}", num, middle);
            Console.ReadKey();
        }
        */

        /* Ex94
        public static void Solution(string[] arr)
        {
            Array.Sort(arr);
            int count = 0;
            foreach (char c in arr[0])
            {
                bool isEqual = true;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (c != arr[i][count])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual == false)
                {
                    break;
                }
                count++;
            }

            string res = arr[0].Substring(0, count);
            Console.WriteLine("({0}) -> \"{1}\"", string.Join(", ", arr), res);
            Console.ReadKey();
        }
        */

        /* Ex95
        public static void Solution(string s)
        {
            char[] arr = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool isValid = true;
            for (int i = 0; i < arr.Length; i++)
            {
                char c = arr[i];
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '<')
                {
                    stack.Push('>');
                }
                else
                {
                    // when stack is empty or the closing char is different
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        isValid = false;
                    }
                }
            }
            // when stack still contains elements
            if (stack.Count > 0)
            {
                isValid = false;
            }
            Console.WriteLine("(\"{0}\") -> {1}", s, isValid);
            Console.ReadKey();
        }
        */

        /* Ex97
        public static void Solution(string s)
        {
            bool res = double.TryParse(s, out _);
            Console.WriteLine("(\"{0}\") -> {1}", s, res);
        }
        */

        /* Ex100
        public static void Solution(object a, object b)
        {

            if (a.GetType() != b.GetType())
            {
                Console.WriteLine("False");
                return;
            }

            if (a != b)
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("True");
        }
        */
    }
}
