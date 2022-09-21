﻿using System;

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
        //Display answer 
        public static void DisplayAnswer(QuizCard answer)
        {

            answer.Answers.ForEach(Console.WriteLine);
            Console.WriteLine("************************************************");

        }
        //Read user input and convert it to an index
        public static int ChooseAnswer()
        {
            Console.Write("Select 1, 2, 3 or 4: ");
            int selectedAnswer = int.Parse(Console.ReadLine());
            while (selectedAnswer > 4 || selectedAnswer < 1)
            {
                Console.Write("Please enter a number between 1 - 4 included: ");
                selectedAnswer = int.Parse(Console.ReadLine());
            }

            return selectedAnswer - 1;
        }
        //Display message based on the condition
        public static void DisplayRightAnswerOrNot(bool right)
        {
            if (right)
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




