﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class AIProgram
    {
        public static int age, experience;
        public static string name;

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
            string preanswer1, answer2, answer3, answer4, answer5, driving;
            int answer1

            Console.WriteLine("Would You like to work Part time(1) or Full time(2)? ");
            preanswer1 = Console.ReadLine();
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
            Console.WriteLine("Do you have a drivers license? ");
            answer5 = Console.ReadLine().ToLower();
            if (answer5 == "yes")
            {
                Console.WriteLine("Would you want to do deliveries? ");
                driving = Console.ReadLine().ToLower();
            }
        }
        public static void Taylor()
        {





        }
        public static void Dhugald()
        {
            


        }





        static void Main()
        {
            Dhugald();
            Todd();
            Fynn();

        }
    }
}
