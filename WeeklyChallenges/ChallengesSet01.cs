using System;

namespace WeeklyChallenges
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double subtract = minuend - subtrahend;
            return subtract;
        }

        public int Add(int number1, int number2)
        {
            int add = number1 + number2;
            return add;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int getsmallestnum;
            if (number1 > number2)
            {
                 getsmallestnum = number2;
            }
            else
            {
                getsmallestnum = number1;
            }
           /* else
            {
                getsmallestnum = 0;
            }*/
            return getsmallestnum;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        { string defa = "";
            if (nameOfPerson == null)
            {
                defa = "Hello!";
            }
            else {
                defa = "Hello";
            }
            return $"{defa}{nameOfPerson}!"; 
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
