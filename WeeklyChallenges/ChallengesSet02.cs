using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
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
            if(number % 2 == 0)
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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var numby = numbers.Count();

            if(numby == 0)
            {
                return 0;
            }


            

            var numbersMax = numbers.Max();
            var numbersMin = numbers.Min();
            var numbersSum = numbersMax + numbersMin;


            return numbersSum;

            

        }
        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
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

            if(numbers == null)
            {
                return 0;
            }


            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;




        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var numberss = numbers.Sum();
            if (numberss % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number < 0)
            {
                return 0;
            }
               
            return number / 2;
        }
    }
}
