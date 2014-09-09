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
            //call our fizzbuzz funtion for numbers 0 to 20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            
            LetterCounter('i', "I love buscuits and gravy.  It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up.  Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore.  She's from Sussex.");
            //keep the window open
            Console.ReadKey();
        }
        
        //Create function FizzBuzz
        static void FizzBuzz(int number)
        {
            //check to see if number is divisible by 5 and 3
            if (number % 3 == 0 && number % 5 == 0)
            {
                //if yes, print fizzbuzz
                Console.WriteLine("FizzBuzz");
            }
            //check to see if number is divisible by 5
            else if (number % 5 == 0)
            {
                //if yes, print fizz
                Console.WriteLine("Fizz");
            }
            //check to see if number is divisible by 3
            else if (number % 3 == 0)
            {
                //if yes, print buzz
                Console.WriteLine("Buzz");
            }
            //if number is not divisible by either 5 or 3
            else if (number % 3 != 0 && number % 5 != 0) 
            {
                //print number
                Console.WriteLine(number);
            }
        }
        //create a function called lettercounter that takes two parameters
        //character named letter and a string named inString
       static void LetterCounter(char letter, string inString)
        {
            int numLower = 0;
            int numUpper = 0;
            int numTotal = numLower + numUpper;


            for (int i = 0; i < inString.Length; i++)
            {
                if (letter.ToString().ToLower() == inString[i].ToString()) numLower++;
                if (letter.ToString().ToUpper() == inString[i].ToString()) numUpper++;  
            }

            Console.WriteLine(inString);
            Console.WriteLine("Number of Lowercase: " + numLower);
            Console.WriteLine("Number of Uppercase: " + numUpper);
            Console.WriteLine("Number of Total: " + numTotal);
        }
    }
}
