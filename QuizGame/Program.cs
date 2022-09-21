using System;
using System.Collections.Generic;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeInformation();
            List<QuizCard> questionList = Logic.QuizList();

            Random random = new Random();


            for (int i = 0; i < questionList.Count; i++)
            {
                int j = random.Next(questionList.Count);

                QuizCard question = questionList[j];

                UI.DisplayQuestion(question);

                UI.DisplayAnswer(question);

                int selectedAnswer = UI.ChooseAnswer();

                bool corectSolution = Logic.CheckAnswer(selectedAnswer, questionList[j]);

                UI.DisplayRightAnswerOrNot(corectSolution, i);
            }

            Console.ReadLine();
        }
    }
}
