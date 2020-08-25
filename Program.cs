using System;

namespace MethodsExercise2
{
    class Program
    {
        public static int Sum(int firstNumber, params int[] numbers)
        {
            int temp = 0;
            foreach(int inputNum in numbers)
            {
                temp += inputNum;
            }
            return temp + firstNumber;
        }

        public static int Subtract(int firstNumber, params int[] numbers)
            {
            int temp = 0;
            foreach(int inputNum in numbers)
            {
                temp += inputNum;
            }
            return firstNumber - temp;
        }

        public static int Multiply(int firstNumber, params int[] inputNumbers)
        {
            int temp = 1;
            foreach(int inputNum in inputNumbers)
            {
                temp *= inputNum;
            }
            return temp * firstNumber;
        }

        public static int Divide(int firstNumber, params int[] inputNumbers)
        {
            int temp = firstNumber;
            foreach(int inputNum in inputNumbers)
            {
                temp /= inputNum;
            }
            return temp;
        }

        public static int Remainder(int firstNumber, params int[] inputNumbers)
        {
            int temp = firstNumber;
            foreach (int inputNum in inputNumbers)
            {
                temp %= inputNum;
            }
            return temp;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(85,92,163,204,888));
            Console.WriteLine(Subtract(10, 2, 3, 1));
            Console.WriteLine(Multiply(4,5,2,2));
            Console.WriteLine(Divide(20,2,5));
            Console.WriteLine(Remainder(14,5,2));
        }
    }
}
