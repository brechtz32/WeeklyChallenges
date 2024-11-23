using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var myString = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };

            return myString.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var myNumber = new List<int> { number1, number2, number3, number4 };

            return myNumber.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return(
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                );
            /*var myTriangle = new List<int>() { sideLength1, sideLength2, sideLength3};
            myTriangle.OrderBy(x => x);

            if (myTriangle[0] + myTriangle[1] > myTriangle[2])
            {
                return true;
            }
            else return false;*/
        }

        public bool IsStringANumber(string input)
        {
            var isItMyNumber = double.TryParse(input, out double number);
            return isItMyNumber;                        
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var obj in objs )
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
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
               
            var avgEvens = numbers.Where(x => x % 2 == 0);
            if (avgEvens.Count() == 0)
            {
                return 0;
            }
            return avgEvens.Average();
        }

        public int Factorial(int number)
        {
            var factorial = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for( int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
