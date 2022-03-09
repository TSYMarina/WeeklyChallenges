using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evensSum = 0;
            int oddsSum = 0;
            if (numbers != null && numbers.Length != 0)
            {
                foreach (int num in numbers)
                {
                    if (num % 2 != 0)
                    {
                        oddsSum += num;
                    }
                    else
                    {
                        evensSum += num;
                    }
                }
            }
            return evensSum - oddsSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] words = { str1, str2, str3, str4 };
            int minValue = str1.Length;
            foreach (string str in words)
            {
                if (str.Length < minValue)
                minValue = str.Length;
            }
            return minValue;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] nums = { number1, number2, number3, number4 };
            int minValue = number1;
            foreach (int num in nums)
            {
                if (num < minValue)
                  minValue = num;
            }
            return minValue;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if ((sideLength1 > 0 || sideLength2 > 0 || sideLength3 > 0)
                && sideLength1 + sideLength2 > sideLength3
                && sideLength3 + sideLength2 > sideLength1
                && sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            return false;
        }

        // Alternative:
        //        if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
        //    {
        //        return false;
        //    }
        //    else if (sideLength1 + sideLength2 <= sideLength3)
        //    {
        //        return false;
        //    }
        //    else if (sideLength3 + sideLength2 <= sideLength1)
        //    {
        //        return false;
        //    }
        //    else if (sideLength1 + sideLength3 <= sideLength2)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public bool IsStringANumber(string input)
        {
            double number;
            var answer = double.TryParse(input, out number);
            return answer;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int numOfNulls = 0;
            bool answer = true;
            foreach (object item in objs)
            {
               if (item == null)
                  numOfNulls++;
               if (numOfNulls > objs.Length / 2)
                  answer = true;
               else
                   answer = false;
            }
            return answer;
        }

    

        public double AverageEvens(int[] numbers)
        {
            double sumEvens = 0;
            double countEvens = 0;
            double answer = 0;
            if (numbers != null)
            {
                foreach (int item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        sumEvens += item;
                        countEvens++;
                        answer = sumEvens / countEvens;
                    }
                }
            }
            return answer;
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            if (number == 0)
                return 1;

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
