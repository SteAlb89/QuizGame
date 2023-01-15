using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Security.AccessControl;
using System.Threading;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\tmp\questionList.xml";

            UI.DisplayWelcomeInformation();
            List<QuizCard> questionList1 = Logic.CreateQuizList();
            Random random = new Random();

            int answerPlayFill = UI.AskPlayFill();

            while (true)
            {
                if (answerPlayFill == 1)
                {
                        List<QuizCard> questionList = UI.CreateQuestion();
                        Logic.SaveQuizCardList(questionList, path);
                        Logic.LoadQuizCArdList(path);

                        UI.PlayOwnQuestion();
                        UI.QuestionFinished();
                }
                else
                {
                    int correctScore = 0;
                    bool gameOver = false;
                    while (!gameOver)
                    {
                        if (questionList1.Count != 0)
                        {
                            int j = random.Next(questionList1.Count);

                            QuizCard question = questionList1[j];
                            UI.DisplayQuestion(question);

                            UI.DisplayAnswers(question);

                            int selectedAnswer = UI.ChooseAnswer();
                            bool correctSolution = Logic.CheckAnswer(selectedAnswer, question);

                            if (correctSolution)
                            {
                                correctScore++;
                            }
                            questionList1.RemoveAt(j);
                            UI.DisplayTotalScore(correctSolution);

                        }
                        else
                        {
                            UI.QuestionFinished();
                            UI.FinalScore(correctScore);
                            UI.AddMoreQuestions();
                            gameOver = true;
                        }

                    }
                }
            }
        }
    }
}
