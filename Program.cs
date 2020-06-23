using System;

namespace Arithmetic_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A primary school teacher wants a computer 
             * program to test the basic arithmetic skills
             * of her students. Generate random questions 
             * (2 numbers only) consisting of addition, 
             * subtraction, multiplication and division.

            The system should ask the student’s name 
            and then ask ten questions. The program 
            should feed back if the answers are correct 
            or not, and then generate a final score at 
            the end.

            Extensions:

            1. Extend your program so that it stores
            the results somewhere. The teacher has three
            classes, so you need to enable the program 
            to distinguish between them.

            2. The teacher wants to be able to log 
            student performance in these tests. The teacher
            would like the program to store the last three 
            scores for each student and to be able to output 
            the results in alphabetical order with the student’s
            highest score first out of the three.
            */

            Console.WriteLine("Enter your full name");
            string pupilName = Console.ReadLine();
            int Score = 0;

            Console.WriteLine("Questrion 1:");
            Console.WriteLine("what is 8 + 16");
            string answer1 = Console.ReadLine();
            if (answer1 == "24")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 24");
            }
            Console.WriteLine("Questrion 2:");
            Console.WriteLine("what is 34 - 13");
            string answer2 = Console.ReadLine();
            if (answer2 == "21")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 31");
            }
            Console.WriteLine("Questrion 3:");
            Console.WriteLine("what is 4 x 23");
            string answer3 = Console.ReadLine();
            if (answer3 == "92")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 92");
            }
            Console.WriteLine("Questrion 4:");
            Console.WriteLine("what is 24 / 6");
            string answer4 = Console.ReadLine();
            if (answer4 == "4")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 4");
            }
            Console.WriteLine("Questrion 5:");
            Console.WriteLine("what is 43 x 2");
            string answer5 = Console.ReadLine();
            if (answer5 == "86")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 86");
            }
            Console.WriteLine("Questrion 6:");
            Console.WriteLine("what is 43 - 26");
            string answer6 = Console.ReadLine();
            if (answer6 == "17")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 24");
            }
            Console.WriteLine("Questrion 7:");
            Console.WriteLine("what is 7 x 7");
            string answer7 = Console.ReadLine();
            if (answer7 == "49")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 49");
            }
            Console.WriteLine("Questrion 8:");
            Console.WriteLine("what is 45 x 3");
            string answer8 = Console.ReadLine();
            if (answer8 == "135")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 135");
            }
            Console.WriteLine("Questrion 9:");
            Console.WriteLine("what is 72 / 8");
            string answer9 = Console.ReadLine();
            if (answer9 == "9")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 9");
            }
            Console.WriteLine("Questrion 10:");
            Console.WriteLine("what is 24 + 26");
            string answer10 = Console.ReadLine();
            if (answer10 == "50")
            {
                Console.WriteLine("Correct");
                Score++;

            }
            else
            {
                Console.WriteLine("That is incorrect, the answer is 50");
            }
            Console.WriteLine("");
            Console.WriteLine("Pupil "+pupilName+" scored " +Score+"/10");
        }
    }
}
