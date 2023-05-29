using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum %2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsNumber)&&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower);
            //var isLower = false; 
            //var isUpper = false;
            //var isDigit = false;

            //foreach (var letter in password)
            //{
            //    if (char.IsLower(letter)) 
            //    { 
            //        isLower = true; 
            //    }
            //    if (char.IsUpper(letter))
            //    {
            //        isUpper = true;
            //    }
            //    if (char.IsDigit(letter))
            //    {
            //        isDigit = true;
            //    }
            //}
            //return isUpper && isLower && isDigit; 
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor ==0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1,100).Where(x => x %2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
