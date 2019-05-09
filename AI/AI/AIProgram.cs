using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class AIProgram
    {
        public static int age, experience, hearAboutJob;
        public static string name, AnswerMcDonalds, Leaving, DegreeYN, NumDegrees;
        public static string[] DegreesArray;
        public static bool student;
        public static void Todd()
        {
            string temp;
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);

            Console.WriteLine("Have you worked in hospitality before? Yes/No");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                Console.WriteLine("How many years have you worked in hospitality?");
                temp = Console.ReadLine();
                experience = Convert.ToInt32(temp);
            }

            Console.WriteLine("Are you currently a student? Yes/No");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                student = true;
            }
            else
            {
                student = false;
            }

            Console.ReadLine();

        }
        public static void Fynn()
        {
            string preanswer1, answer2, answer3, answer4, answer5, driving;
            int answer1;

            Console.WriteLine("Would You like to work Part time(1) or Full time(2)? ");
            preanswer1 = Console.ReadLine();
            while (preanswer1 != "1" && preanswer1 != "2")
            {
                Console.WriteLine("That is not a valid input");
                Console.WriteLine("Would You like to work Part time(1) or Full time(2)? ");
                preanswer1 = Console.ReadLine();
                

            }
            answer1 = Convert.ToInt32(preanswer1);
           
            
            if (answer1 == 1)
            {
                Console.WriteLine("Would you like to work day or night? ");
                answer2 = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("How many hours per week would you like to work? ");
                answer3 = Console.ReadLine();

            }

            Console.WriteLine("Can you work weekends? ");
            answer4 = Console.ReadLine();
            Console.WriteLine("Do you have a drivers license? (Yes/No) ");
            answer5 = Console.ReadLine().ToLower();
            if (answer5 == "yes")
            {
                Console.WriteLine("Would you want to do deliveries? ");
                driving = Console.ReadLine().ToLower();
            }
        }
        public static void Dhugald()
        {
            Console.WriteLine($"Have you worked at McDonalds in the past? (Yes/No)");
            AnswerMcDonalds = Console.ReadLine().ToUpper();

            if (AnswerMcDonalds == "YES")
            {
                Console.WriteLine("Please enter your reason for leaving: ");
                Leaving = Console.ReadLine();
            }
            if (AnswerMcDonalds != "YES" && AnswerMcDonalds != "NO")
            {
                Console.WriteLine("Invalid answer Please enter again: ");
            }

            Multichoice1();
            Console.WriteLine("Please enter a number for the answer");
            string temp = Console.ReadLine();
            hearAboutJob = Convert.ToInt32(temp);

            string HearAboutJobAnswer;
            if (hearAboutJob == 1)
            {
                HearAboutJobAnswer = "On an advertisement";
                
            }
            if (hearAboutJob == 2)
            {
                HearAboutJobAnswer = "From a friend";
            }
            if (hearAboutJob == 3)
            {
                HearAboutJobAnswer = "Phonebook";
            }
            if (hearAboutJob == 4)
            {
                Console.WriteLine("Please enter 'other' answer: ");
                HearAboutJobAnswer = Console.ReadLine();
            }


            Console.WriteLine("Do you have any Degree(s)? (Yes/No)");
            string degreeYN = Console.ReadLine().ToLower();
            int NumDegrees = 0;
            if (degreeYN == "yes")
            {
                Console.WriteLine("How many?");
                temp = Console.ReadLine();
                NumDegrees = Convert.ToInt32(temp);

                for (int i = 0; i < NumDegrees; i++)
                {
                    Console.WriteLine($"Please enter number {i+1} degree: ");
                    temp = Console.ReadLine();
                    string[] DegreesArray = new string[NumDegrees];
                }
            }



        








        }
        public static void Multichoice1()
        {
            Console.Clear();
            Console.WriteLine("How did you hear about the job?");
            Console.WriteLine("1    On an advertisement");
            Console.WriteLine("2    From a friend");
            Console.WriteLine("3    Phonebook");
            Console.WriteLine("4    Other");

        }

        public static void Results() //Taylor
        {
            Console.WriteLine("Results");
            Console.WriteLine($"Age:{age}\n Name:{name}");
            Console.WriteLine($"Part(1) or Full(2) Time: {answer1}");
        }



        static void Main() //Taylor Format and Edit Code
        {
            string choice = null;
            while (choice != "yes")
            {
                Todd();
                Results();
                Fynn();
                Dhugald();
                Console.WriteLine("Do you want to make changes? ");
                choice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Thank you for your submission.");
        }
    }
}
