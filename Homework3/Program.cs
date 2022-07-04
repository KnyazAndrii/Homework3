using System;

namespace Homework3
{
    class Program
    {
        static int RaiseToThePower(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        static int[] DevideBy(int a)
        {
            int num = GetNumInArr(a);
            int[] result = new int[num];
            int i = 0;

            for (int n = 1; n <= 1000; n++)
            {
                if (n % a == 0)
                {
                    result[i] = n;
                    i++;
                }
            }
            return result;
        }

        static int GetNumInArr(int a)
        {
            int num = 0;

            for (int n = 1; n <= 1000; n++)
            {
                if (n % a == 0)
                {
                    num++;
                }
            }
            return num;
        }

        static int GetLessThanSquare(int a)
        {
            int number = 0;

            for (int i = 1; i * i < a; i++)
            {
                number++;
            }
            return number;
        }

        static int GetLargestDivisor(int a)
        {
            int largestResult = 0;

            for(int i = 1; i < a; i++)
            {
                if(a % i == 0)
                {
                    largestResult = i;
                }
            }
            return largestResult;
        }

        static int CalculateSum(int a, int b)
        {
            int sum = 0;

            if(a > b)
            {
                for(int i = b; i <= a; i++)
                {
                    if(i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else if(b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        static int GetFibonacciNum(int n)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int result = 1;

            for(int i = 3; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                    firstNumber += secondNumber;
                }
                else
                {
                    secondNumber += firstNumber;
                }

                if((i == n) && (i % 2 != 0))
                {
                    result = firstNumber;
                }
                else if((i == n) && (i % 2 == 0))
                {
                    result = secondNumber;
                }
            }
            return result;
        }

        static int UseEuclidAlgorithm(int firstNum, int secondNum)
        {
            int remainder = 1;

            do
            {
                remainder = firstNum % secondNum;
                if (remainder == 0)
                {
                    return secondNum;
                }
                firstNum = secondNum;
                secondNum = remainder;
            } while (secondNum % remainder == 0);
            return remainder;
        }

        static int FindCubeBinary(int number)
        {
            int n = 0;

            for (int i = 0; i < number; i++)
            {
                if(i * i * i <= number)
                {
                    n = i; 
                }
            }
            return n;
        }

        static int FindDigits(int number)
        {
            int digit = 0;
            int n = 0;

            while (number >= 1)
            {
                digit = number % 10;
                number = number / 10;

                if(digit % 2 != 0)
                {
                    n++;
                }
            }
            return n;
        }

        static string MirrorNumber(int number)
        {
            string result = string.Empty;
            int digit = 0;

            while(number >= 1)
            {
                digit = number % 10;
                number = number / 10;
                result += digit.ToString();
            }
            return result;
        }

        static int CalulateNumInArr(int n)
        {
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                int j = i;

                while (j >= 1)
                {
                    int digit = 0;
                    digit = j % 10;
                    j = j / 10;

                    if (digit % 2 == 0)
                    {
                        sumEven += digit;
                    }

                    if (digit % 2 != 0)
                    {
                        sumOdd += digit;
                    }
                }

                if (sumEven > sumOdd)
                {
                    num++;
                }
            }
            return num;
        }

        static int[] SumGreaterDigits(int n)
        {
            int[] arr = new int[CalulateNumInArr(n)];
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                int j = i;

                while (j >= 1)
                {
                    int digit = 0;
                    digit = j % 10;
                    j = j / 10;

                    if (digit % 2 == 0)
                    {
                        sumEven += digit;
                    }

                    if (digit % 2 != 0)
                    {
                        sumOdd += digit;
                    }
                }

                if (sumEven > sumOdd)
                {
                    arr[num] = i;
                    num++;
                }
            }
            return arr;
        }

        static string CompareDigits(int firstNum, int secondNum)
        {
            int firstDigit = 0;
            int secondDigit = 0;

            while (firstNum >= 1)
            {
                firstDigit = firstNum % 10;
                firstNum = firstNum / 10;

                while (secondNum >= 1)
                {
                    secondDigit = secondNum % 10;
                    secondNum = secondNum / 10;

                    if(firstDigit == secondDigit)
                    {
                        return "YES";
                    }
                }
            }
            return "NO";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 2: " + RaiseToThePower(2, 4));
            Console.WriteLine("Task 1:");
            foreach (int n in DevideBy(100))
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Task 3: " + GetLessThanSquare(5));
            Console.WriteLine("Task 4: " + GetLargestDivisor(150));
            Console.WriteLine("Task 5: " + CalculateSum(1, 14));
            Console.WriteLine("Task 6: " + GetFibonacciNum(7));
            Console.WriteLine("Task 7: " + UseEuclidAlgorithm(106, 16));
            Console.WriteLine("Task 8: " + FindCubeBinary(27));
            Console.WriteLine("Task 9: " + FindDigits(1875));
            Console.WriteLine("Task 10: " + MirrorNumber(7855));
            Console.WriteLine("Task 11: ");
            foreach (int n in SumGreaterDigits(66))
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Task 12: " + CompareDigits(500, 99));
        }
    }
}
