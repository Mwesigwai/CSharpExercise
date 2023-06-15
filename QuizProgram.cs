using System;

namespace MyApp
{
    class MainClass
    {
        public static string answer1;
        public static string answer2;
        public static string answer3;
        public static string answer4;

        public static string userName;
        public static string firstInput;
        public static void Main(string[] args)
        {
            string restartConsole;
            do
            {
                UserIntroduceYourSelf();
                DoesUserWantToStartQuiz();
                Console.WriteLine("Enter \"yes\" to restart or \"q\" to quit");
                restartConsole = Console.ReadLine();
                if (restartConsole == "q")
                {
                    break;
                }

            } while (restartConsole == "yes");
        }

        public static void UserIntroduceYourSelf()
        {
            Console.WriteLine("It is good to first tell me your name");
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome " + userName + "!");
            Console.WriteLine();
            Console.WriteLine("I am Isaac Mwesigwa");
            Console.WriteLine("Nice to meet you");
            Console.WriteLine();
        }

        public static void DoesUserWantToStartQuiz()
        {
            int numOfTrials = 0;
            Console.WriteLine("So should we begin the quiz?");
            firstInput = Console.ReadLine();

            if (firstInput == "yes")
            {
                BeginQuiz();
            }
            while (firstInput != "yes")
            {
                numOfTrials += 1;
                Console.WriteLine("Confirm your input");
                firstInput = Console.ReadLine();
                if (firstInput == "yes")
                {
                    BeginQuiz();
                }
                if (numOfTrials == 1 && firstInput != "yes")
                {
                    Console.WriteLine("ByeBye " + userName + " see you again");
                    break;
                }
            }
        }

        public static void BeginQuiz()
        {
            Question1();
            Question2();
        }

        public static void Question1()
        {

            Console.Clear();
            Console.WriteLine("Answer the first five questions then i will show you the results after.\n");
            Console.WriteLine("First question: \n");
            Console.WriteLine("Mary's father has five daughters: \n Nana, Nene, Nini, Nono, " +
                "and......?\n What is the name of the fifth daughter?\n");
            answer1 = Console.ReadLine();
        }

        public static void Question2()
        {
            Console.Clear();
            Console.WriteLine("If you had only one match and entered a dark room containing an oil lamp,\n" +
            	"some newspaper, and some kindling wood,\n" +
            	"which would you light first?");
            answer2 = Console.ReadLine();     
        }
    }
}
