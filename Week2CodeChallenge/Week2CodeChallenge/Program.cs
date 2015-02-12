using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
      

        static void Main(string[] args)
        {
            //for (int i = 0; i < 21; i++)
            //{
            //    FizzBuzz(i);
            //}
            //LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            //LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            //LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            //string s1 = "Cshr";
            //string s2 = s1.Insert(3, "a");
            //string s3 = s2.Insert(6, "p");
         

            //Console.WriteLine(s3);
            int a = 5;
            int b = 2;
            int result = MakeComplicatedCalculation(a, b);
            Console.WriteLine(result);
        }



        static int MakeComplicatedCalculation(int a, int b)
        {
            return a * b;
        }
           
       
        /// <summary>
        /// Prints out Fizz or Buzz if a number is divisible by 5 or 3, or FizzBuzz if divisible by both 5 and 3.
        /// Otherwise, prints out a number itself.
        /// </summary>
        /// <param name="number">Number to be proccessed</param>
        static void FizzBuzz(int number)
        {
            //checking if divisible by both 5 and 3
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //checking if divisible by 5
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //checking if divisible by 3
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //if not divible by 3 or 5, returns the number itself
            else
            {
                Console.WriteLine(number);
            }
        }
        /// <summary>
        /// Counts how many times the input letter occurs in input string in both lower and uppercases.
        /// </summary>
        /// <param name="letter">Letter to be checked.</param>
        /// <param name="inString">String to be processed.</param>
        static void LetterCounter(char letter, string inString)
        {
            //creating counters for upper and lower cases
            int lowerCaseCounter = 0;
            int upperCaseCounter = 0;
            //looping through each letter in the input string
            for (int i = 0; i < inString.Length; i++)
            {
                //checking if the upper case letter is the same as input letter
                if (inString[i].ToString() == letter.ToString().ToUpper())
                {
                    upperCaseCounter++;
                }
                //checking if the lower case letter is the same as input letter
                else if (inString[i].ToString() == letter.ToString().ToLower())
                {
                    lowerCaseCounter++;
                }
            }
            //printin out results
            Console.WriteLine(@"
Input: ""{0}""
Number of lowercase {3}'s:{1, 6}
Number of UPPERCASE {3}'s:{2, 6}
Total Number of {3}'s found:{4, 4}", inString, lowerCaseCounter, upperCaseCounter, letter, lowerCaseCounter+upperCaseCounter);
        }

    }
}
