using System;
using System.Collections.Generic;

namespace QuizGame
{
    public class UI
    {
        public static void DisplayWelcomeInformation()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Welcome To Our Interactive Game ~~ QUIZ ~~~ ");
        }
        public static void DisplayQuestion(QuizCard question)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(question.Question);
        }
      
        public static void DisplayAnswer(QuizCard answer)
        {
            answer.Answers.ForEach(Console.WriteLine);
            Console.WriteLine("************************************************");

        }
        public static int ChooseAnswer()
        {
            Console.Write("Select 1, 2, 3 or 4: ");
            int selectedAnswer = int.Parse(Console.ReadLine());

            return selectedAnswer;
        }

        public static void DisplayRightAnswer(bool right)
        {
            if(right)
            {
                Console.WriteLine("The selected answer is correct!");
            }
            else
            {
                Console.WriteLine("The selected answer is wrong!");
            }
        }
    }
}

