using System;
using System.Collections.Generic;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeInformation();


            while (true)
            {
                List<QuizCard> questionList = Logic.QuizList();

                Random random = new Random();
                int i = random.Next(questionList.Count);

                QuizCard question = questionList[i];

                UI.DisplayQuestion(question);

                UI.DisplayAnswer(question);

                int selectedAnswer = UI.ChooseAnswer();

                bool corectSolution = Logic.CheckAnswer(selectedAnswer, questionList[i]);

                UI.DisplayRightAnswer(corectSolution);
            }

            Console.ReadLine();
        }
    }
}
