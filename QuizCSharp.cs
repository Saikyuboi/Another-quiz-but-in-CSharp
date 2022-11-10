using System;
using System.Linq.Expressions;

namespace quizCSharp
{
    class program
    {
        static void Main(string[] args)
        {
            int control;
            Console.WriteLine("Welcome to this quiz");
            Console.WriteLine("Today's question themes are films");
            Console.WriteLine("Press a random key when you're ready");
            string akip=Console.ReadLine();
            Console.WriteLine("First question");
            control=Question("In \"The Matrix\", does Neo take the blue pill or the red pill?", "A)The red one", "B)The blue one", "C)None of them", "D)Both of them", "A");
            if (control==0)
            {
                Console.WriteLine("");
                Console.WriteLine("You Lost");
                return;
            }
            Console.WriteLine("Second Question");
            control = Question("What was the first movie in the Marvel Cinematic Universe?", "A)The Avengers", "B)Spider-Man", "C) Batman", "D)Iron Man", "D");
            if (control == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You Lost");
                return;
            }
            Console.WriteLine("Third question");
            control = Question("In the movie \"Frozen\", who is Olaf?", "A)A reindeer", "B)A snowman", "C)A ghost", "D)A knight", "B");
            if (control == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You Lost");
                return;
            }
            Console.WriteLine("Fourth question");
            control = Question("For which of these movies did Leonardo DiCaprio win an Oscar for Best Actor?", "A)Titanic", "B)The Revenant", "C)The Last King of Scotland", "D)Blood Diamond", "B");
            if (control == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You Lost");
                return;
            }
            Console.WriteLine("Fifth and last question");
            control = Question("True or False, Since 1930, the percentage of Americans who go to the cinema frequently has increased?", "A)False", "B)True", "", "", "A");
            if (control == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You Lost");
                return;
            }
            Console.WriteLine("You won, Congratulations!!!");
        }

        static int Question(string question,string AnswerA, string AnswerB, string AnswerC, string AnswerD, string answer)
        {
            Console.WriteLine(question);
            Console.WriteLine("");
            Console.WriteLine(AnswerA);
            Console.WriteLine(AnswerB);
            Console.WriteLine(AnswerC);
            Console.WriteLine(AnswerD);
            Console.WriteLine("");
            string playeranswer = Console.ReadLine();
            playeranswer = playeranswer.ToUpper();
            while (playeranswer != "A" && playeranswer != "B" && playeranswer != "C" && playeranswer != "D")
            {
                Console.WriteLine("Your answer is in the wrong format");
                Console.WriteLine("Try answering A, B, C or D");
                Console.WriteLine("");
                playeranswer = Console.ReadLine();
                playeranswer = playeranswer.ToUpper();
            }
            if (playeranswer == answer)
            {
                Console.WriteLine("Correct");
                return 1;
            }
            else
            {
                Console.WriteLine("Wrong");
                    return 0;
            }
        }
    }
}
