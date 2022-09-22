using System;
using System.Collections.Generic;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeInformation();
            List<QuizCard> questionList = Logic.CreateQuizList();

            Random random = new Random();


            int correctScore = 0;
            bool gameOver = false;
            while (!gameOver)
            {
                if (!(questionList.Count == 0))
                {
                    int j = random.Next(questionList.Count);

                    QuizCard question = questionList[j];
                    UI.DisplayQuestion(question);

                    UI.DisplayAnswers(question);

                    int selectedAnswer = UI.ChooseAnswer();

                    bool corectSolution = Logic.CheckAnswer(selectedAnswer, question);
                    if (corectSolution == true)
                    {
                        UI.DisplayTotalScore(correctScore);
                        correctScore++;
                    }
                    questionList.RemoveAt(j);
                }
                else
                {
                    UI.QuestionFinished();
                    gameOver = true;
                }
                
            }
            Console.ReadLine();
        }
    }
}
