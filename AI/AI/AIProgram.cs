using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class AIProgram
    {
        public static int age, experience;
        public static string name, AnswerMcDonalds, Leaving;

        public static void Todd()
        {
            string temp;
            Console.WriteLine("How old are you?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);

            Console.WriteLine($"{age}");

            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine(name);

            Console.ReadLine();

        }
        public static void Fynn()
        {
            Console.WriteLine($"Because you are {age} years old do you think that you are qualified for this job? ");
            string answer2 = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine();




        }
        public static void Taylor()
        {





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
            if (AnswerMcDonalds == "NO")
            {

            }






       


        }





        static void Main()
        {
            Dhugald();
            Todd();
            Fynn();

        }
    }
}
