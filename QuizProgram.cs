using System;

namespace MyApp
{
    class MainClass
    {
        public static string userName;
        public static string firstInput;


        public static void Main(string[] args)
        {
            UserIntroduceYourSelf();
            DoesUserWantToStartQuiz();
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
            Console.WriteLine("Question one...");
        }
    }
}

