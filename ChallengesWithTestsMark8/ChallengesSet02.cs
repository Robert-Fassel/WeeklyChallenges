using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return (Char.IsLetter(c));
        }
        

        public bool CountOfElementsIsEven(string[] vals)
        {
            var numCount = vals.Count();
            if (numCount %2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {   
           
            
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        { 
            if (numbers == null)
        {
            return 0;
        }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            var mx = numbers.Max(x => x);
            var mn = numbers.Min(x => x);
            return mx + mn;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int stringLength1 = str1.Length;
            int stringLength2 = str2.Length;
            return Math.Min(stringLength1, stringLength2);
        }

        public int Sum(int[] numbers)
        {   
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
           if (numbers == null)
            {
                return 0;
            }
            var evenSum = 0;
            for (int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var result = numbers.Sum();
            if (result % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
