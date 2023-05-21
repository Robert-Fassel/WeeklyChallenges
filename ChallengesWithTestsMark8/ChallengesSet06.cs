using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (string w in words)
            {
                if (w != null && w.Equals(word, comparison))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1; 
            }

            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (letterCounts.ContainsKey(currentChar))
                {
                    letterCounts[currentChar]++;
                }
                else
                {
                    letterCounts[currentChar] = 1;
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                if (letterCounts[currentChar] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    

        public int MaxConsecutiveCount(int[] numbers)
       
        {
            int maxCount = 0;
            int currentCount = 0;
            int previousNumber = int.MinValue; 

            foreach (int number in numbers)
            {
                if (number == previousNumber)
                {
                    
                    currentCount++;
                }
                else
                {
                   
                    currentCount = 1;
                }

                
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }

                previousNumber = number; 
            }

            return maxCount;
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[] { };
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
