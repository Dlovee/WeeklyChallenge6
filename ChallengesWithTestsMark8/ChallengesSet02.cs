using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstvuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number) //They're giving us an int number, and returning a true or false. I want to know if it's even.
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

        public bool IsNumberOdd(int num) //Got it on the first try!
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
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2) //They're giving me two strings, and I'm returning  an integer.
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
            //Linq
            if (numbers == null) //I need to loop through these numbers and add them up as I go.
            {
                return 0;
            }
            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num; //sum = sum + num
            }

            return sum; 
        }

        public int SumEvens(int[] numbers)
        {
           if (numbers == null)
           {
                return 0;
           }
           
           var evenSum = 0;

           for (int i = 0; i < numbers.Length; i++)
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
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number) //This mean that the number will be huge.
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
