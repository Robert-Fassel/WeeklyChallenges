﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public  int AddEvenSubtractOdd(int[] numbers)
        {
            var result = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                if (num % 2 != 0)
                {
                    result -= num;
                }

                
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            

            return strings.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>() { number1, number2, number3, number4 };
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            var n =double.TryParse(input, out double number);
            return n;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            if (count >= majority)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var nu = numbers.Where(num => num % 2 == 0);
            if (nu.Count() == 0)
            {
                return 0;
            }
            return nu.Average();
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            
            return number * Factorial(number - 1);
        }
    }
}
