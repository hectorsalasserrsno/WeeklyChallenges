using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals) 
            {
                if (val == false)                // return vals != null && vals.Length != 0 && vals.contains(false);
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;

            }
                
            int sum = 0;
           foreach (var number in numbers) 
            {
                if(number % 2 != 0) 
                {
                    sum += number;
                }
            
            }
            if (sum % 2 != 0)
            {
                return true;

            }
            else 
            {
                 return false;
            
            }
            //return numbers != null && numbers.Where(x =>x % 2 == 0).Sum() != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
                //return password.Any(char.IsNumber)
                //&& password.Any(char.IsUpper)
                //&& password.Any(char.IsLower);
            
            bool isLetter = false;
            bool isDigit = false;
            bool isUpper = false;
            foreach (var letter in password) 
            {
                if (char.IsLower(letter))
                {
                    isLetter = true;
                
                }
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                
                }
                
                if (char.IsUpper(letter)) 
                {
                    isUpper = true;
                
                }
                
            }
            return isUpper && isLetter && isDigit;
            
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
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(0, 100).Where(x => x % 2 == 1).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].ToUpper();
            
            }
        }
    }
}
