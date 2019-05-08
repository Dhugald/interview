using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class AIProgram
    {
        public static int age;

        public static void Todd()
        {
            string temp;
            Console.WriteLine("How old are you?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);

            Console.WriteLine($"{age}");
            Console.ReadLine();



        }
        public static void Fynn()
        {





        }
        public static void Taylor()
        {





        }
        public static void Dhugald()
        {
            Console.WriteLine("What is your name? ");
            string answer1 = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine(answer1);


        }





        static void Main()
        {
            Dhugald();


        }
    }
}
