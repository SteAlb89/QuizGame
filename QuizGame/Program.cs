using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Stefan\source\repos\QuizGame\QuizGame\questionList.xml";

            UI.DisplayWelcomeInformation();
            UI.AskingUserToPlayOrToAddQuestions();
            List<QuizCard> questionList = Logic.CreateQuizList();
            Random random = new Random();

            int answerPlayFill = UI.AskPlayFill();

            if (answerPlayFill == 1)
            {
                UI.CreateQuestion();
                Logic.SaveQuizCardList(questionList, path);
                Logic.LoaQuizCArdList(path);
                UI.AddMoreQuestions();
            }
            else
            {
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
                        if (corectSolution)
                        {
                            UI.DisplayTotalScore(corectSolution);
                            correctScore++;
                        }
                        questionList.RemoveAt(j);
                    }
                    else
                    {
                        UI.QuestionFinished();
                        UI.AddMoreQuestions();
                        gameOver = true;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
