using System;

namespace MyApp
{
    class MainClass
    {
        public static int score = 0;
        public static string answer1;
        public static string answer2;
        public static string answer3;
        public static string userName;
        public static string firstInput;



        public static void Main(string[] args)
        {
            string restartConsole;
            do
            {
                UserIntroduceYourSelf();
                DoesUserWantToStartQuiz();
                DisplayResults();
                Console.WriteLine("\nYour score is  " + score + " Out of 3\n" );


                Console.WriteLine("\n\n\n");
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






        public static void DisplayResults()
        {
            Console.Clear();
            Console.WriteLine("Here are the results");
            Console.Write("First question:\n");
            TestAnswer1();
            Console.WriteLine("\nSecond question:");
            TestAnswer2();
            Console.WriteLine("Third question:");
            TestAnswer3();
        }




        public static void BeginQuiz()
        {
            Console.WriteLine("Answer the first three questions then i will show you the results after.\n");
            Question1();
            Question2();
            Question3();
        }




        public static void Question1()
        {

            Console.Clear();
            Console.WriteLine("Answer the first three questions then i will show you the results after.\n");
            Console.WriteLine("First question: \n");
            Console.WriteLine("Mary's father has five daughters: \n Nana, Nene, Nini, Nono, " +
                "and......?\n What is the name of the fifth daughter?\n");
            answer1 = Console.ReadLine();
       
        }




        public static void Question2()
        {
            Console.Clear();
            Console.WriteLine("Second question:\n");
            Console.WriteLine("If you had only one match and entered a dark room containing an oil lamp,\n" +
                "some newspaper, and some kindling wood,\n" +
                "which would you light first?");
            answer2 = Console.ReadLine();
        }





        public static void Question3()
        {
            Console.Clear();
            Console.WriteLine("Third question:\n");
            Console.WriteLine("You are participating in a race and overtake the person in the second place.\n" +
                "What position are will you be in?");
            answer3 = Console.ReadLine();
        }




        public static void TestAnswer1()
        {
            if (answer1 == "Mary" || answer1 == "mary")
            {
                Console.WriteLine("\t\tYour answer was correct \n\t\t Welldone");
                score += 1;
            }
            else
            {
                Console.WriteLine("\t\tYour answer was incorect\n");
                TeachUserAboutQuestion1();
            }

        }


        public static void TeachUserAboutQuestion1()
        {
           
            Console.WriteLine("\"Mary's father\" means that the first daughter is Mary then plus " +
                "the other four");
        }

        public static void TeachUserAboutQuestion2()
        {
            Console.WriteLine("Dear " + userName + " When you enter a dark room with a match " +
                ", you first light the macth then you may light anything else of your choice.");
        }

        public static void TeachUserAboutQuestion3()
        {
            Console.WriteLine("Dear " + userName + "If someone is in a second position," +
            	" it means that there is someone in the first position. So, if you overtake " +
            	"the one in the second positon, you become the one in the second place");
        }


        public static void TestAnswer2()
        {
            if (answer2 == "Match" || answer2 == "match")
            {
                Console.WriteLine("\t\tYour answer was correct \n\t\t Welldone");
                score += 1;
            }
            else
            {
                Console.WriteLine("\t\tYour answer was incorrect\n");
                TeachUserAboutQuestion2();
            }

        }

        public static void TestAnswer3()
        {
            if (answer3 == "Second" || answer3 == "second" || answer3 == "2")
            {
                Console.WriteLine("\t\tYour answer was correct \n\t\t Welldone");
                score += 1;
            }
            else
            {
                Console.WriteLine("\t\tYour answer was incorrect\n");
                TeachUserAboutQuestion3();
            }

        }
    }
}
