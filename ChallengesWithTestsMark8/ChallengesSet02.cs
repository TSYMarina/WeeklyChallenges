using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return num %2 !=0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max, min;
            max = double.MinValue;
            min = double.MaxValue;
            if (numbers != null)
            {
              foreach (var num in numbers)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int numbersSum = 0;
            if (numbers != null && numbers.Length != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbersSum += numbers[i];
                }
            }
            return numbersSum;
        }

        public int SumEvens(int[] numbers)
        {
            int evensSum = 0;
            if (numbers != null && numbers.Length != 0)
                for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evensSum += numbers[i];
                }
            }
            return evensSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int numbersSum = 0;
            if (numbers != null && numbers.Count != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbersSum += numbers[i];
                }
            }
            return numbersSum % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long countOfPOsitiveOdd = 0;
                            for (long i = 0; i < number; i++)
                {
                    if (i % 2 != 0)
                    {
                        countOfPOsitiveOdd++;
                    }
                }
             return countOfPOsitiveOdd;
        }
    }
}
