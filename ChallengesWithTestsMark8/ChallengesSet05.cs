﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber % n == 0)
            {
                return startNumber  + n;
            }
            int nextNumber = startNumber;

            while (nextNumber % n != 0)
            {
                nextNumber++;
            }

            return nextNumber;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {

            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {

               if (numbers == null || numbers.Length == 0)
                {
                    return false;
                }
               
            for (int i = 1; i < numbers.Length; i++)
            {
              if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
                
                
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";
            foreach  (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
               
            }
 if (sentence.Length == 0)
                {
                    return "";
                }
                sentence = sentence.Trim();
                sentence += ".";
                return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (set.Contains(complement))
                {
                    return true;
                }
                set.Add(num);
            }

            return false;
        }

    }
}
