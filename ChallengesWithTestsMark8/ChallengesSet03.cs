using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }
        //Alternative:
        //public bool ArrayContainsAFalse2(bool[] vals)
        //{
        //    var retValue = false;
        //    foreach (var item in vals)
        //    {
        //        if (item == false)
        //        {
        //            retValue = true;
        //            break;
        //        }
        //    }
        //    return retValue;
        //}

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumOfOdds = 0;
            if (numbers != null)
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                        sumOfOdds++;
                    }
                }
            }
            bool answer = sumOfOdds % 2 != 0 ? true : false;
            return answer;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            {
                return password.Any(char.IsDigit) &&
                       password.Any(char.IsUpper) &&
                       password.Any(char.IsLower);
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char c = val[val.Length - 1];
            return c;
            // alternative: return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor != 0 ? dividend / divisor : 0;
            // Alternative:
            //if (divisor != 0)
            //{
            //    return dividend / divisor;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums[0];
            //Alternative:
            //int firstNum = nums[0];
            //int lastNum = nums[nums.Length - 1];
            //return lastNum - firstNum;
        }

        public int[] GetOddsBelow100()
        //public int[] GetOddsBelow100(int[] numArray)
        {
            int[] odds = Enumerable.Range(0, 100).Where(num => num % 2 != 0).ToArray();
            return odds;
        }


        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
