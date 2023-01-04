using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Computations.Mathematical
{


    public interface ICalculatingMean
    {
        double GetMean(int[] arr);
    }
    public class CalculatingMean : ICalculatingMean
    {
        public double GetMean(int[] arr)
        
        {
            int arrSum = 0;
            for (
                int index = 0; index < arr.Length; index++)
            {
                arrSum += arr[index];
            }
            Console.WriteLine("SUm = " + arrSum);
            var arrLength=arr.Length;
            var meanString = String.Format("{0:0.00}", (double)arrSum / arrLength);
            Console.WriteLine("mean = " + meanString);
            var meanFInal = Convert.ToDouble(meanString);
            return meanFInal;
        }
    }
    public interface IAverageOfElementAWholeNumber
    {
        bool IsAverageWholeNumber(int[] arr4);
    }
    public class AverageOfElementAWholeNumber : IAverageOfElementAWholeNumber
    {
        public bool IsAverageWholeNumber(int[] numbers)
        {
            int sumDisplay = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                sumDisplay += (numbers[index]);
                Console.WriteLine("sumDisplay = " + sumDisplay);
            }

            Console.WriteLine("sumDisplay = " + sumDisplay);

            var averageResult = sumDisplay % numbers.Length;
            if (averageResult == 0)
                return true;
            else
                return false;
        }
    }
    public interface IrEliminatingOddNumbersWithinAnArray
    {
        int[] Get(int[] arr3);
    }
    public class rEliminatingOddNumbersWithinAnArray : IrEliminatingOddNumbersWithinAnArray
    {
        public int[] Get(int[] arr3)
        {

            var arrlength = arr3.Length;
            var newArray = new int[arrlength];

            for (int index = 0; index < arrlength; index++)
            {
                if (arr3[index] % 2 == 0)
                {

                }
                    newArray[index] = arr3[index];
            }
            int item = 0;
            newArray = Array.FindAll(newArray, i => i != item).ToArray();
            return newArray;
        }
    }
    public interface INextNumberGreaterThanAB
    {
        int DivisibleByB(int a, int b);
    }
    public class NextNumberGreaterThanAB : INextNumberGreaterThanAB
    {
        public int DivisibleByB(int a, int b)
        {
            if (a % b == 0)
                return a;
            if (b < 0)
                return 0;
            var NextNumber = (a / b);
            return NextNumber * b + b;

        }

    }
    public interface IFizzBuzzElseIf
    {
        string Get(int n);
    }
    public class FizzBuzzElseIf : IFizzBuzzElseIf
    {
        public string Get(int nx)
        {
            var numa = nx % 3;
            var numb = nx % 5;
            if (numa == 0 && numb == 0)
                return "FizzBuzz";
            if (numa == 0)
                return "Fizz";
            if (numb == 0)
                return "Buzz";
            else
                return Convert.ToString(nx);
        }
    }
    public interface IRepeatingOfLetter
    {
        string Get(int b);
    }
    public class RepeatingOfLetter : IRepeatingOfLetter
    {
        public string Get(int b)
        {
            string tabs = new String('r', b);
            return tabs;
        }
    }
    public interface IReturnFactorial
    {
        int Get(int num6);
    }
    public class ReturnFactorial : IReturnFactorial
    {
        public int Get(int num6)
        {
            int factorial = 1;
            for (int digit = 1; digit <= num6; digit++)
            {
                factorial = factorial * digit;
            }
            return factorial;
        }
    }
    public interface IPowerOfNumber
    {
        long Get(long number, long exponent);
    }
    public class PowerOfNumber : IPowerOfNumber
    {
        public long Get(long number, long exponent)
        {
            long result = 0;
            if (exponent != 0)
            {
                var powerOFExponent = Math.Pow(number, exponent);
                result = Convert.ToInt64(powerOFExponent);
            }
            return result;
        }
    }
    public interface IAbsoluteSum
    {
        int GetAbsSum(int[] arr);
    }
    public class AbsoluteSum : IAbsoluteSum
    {
        public int GetAbsSum(int[] arr2)
        {
            int sum = 0;
            for (int num2 = 0; num2 < arr2.Length; num2++)
            {
                var absolute = Math.Abs(arr2[num2]);
                sum += absolute;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
    public interface IPractice
    {
        int[] GetArray(int[] arr);
    }
    public class Practice : IPractice
    {
        public int[] GetArray(int[] arr)
        {
            var arrLength = arr.Length;
            int[] newarray = new int[arrLength];

            Console.WriteLine("The Lenth of Array is  :" + arrLength);
            for (int nums = 0; nums < arrLength; nums++)
            {
                var itemMultipliedByArrayLength = arr[nums] * arrLength;

                Console.WriteLine(arr[nums] + "x" + arrLength + " = " + itemMultipliedByArrayLength);
                newarray[nums] = itemMultipliedByArrayLength;

            }
            return newarray;
        }
    }


}

   
