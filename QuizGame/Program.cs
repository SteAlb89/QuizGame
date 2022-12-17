using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            UI.DisplayWelcomeInformation();
            UI.AskingUserToPlayOrToAddQuestions();
            List<QuizCard> questionList = Logic.CreateQuizList();
            Random random = new Random();

            int answerPlayFill = UI.AskPlayFill();

            if (answerPlayFill == 1)
            {
                UI.CreateQuestion();
                string moreQuestion = UI.PlayOwnQuestion();
                if (moreQuestion == "y")
                {
                    Logic.SaveQuizCardList(questionList, path);
                    Logic.LoadQuizCArdList(path);
                }
                else
                {
                    UI.QuestionFinished();
                }
                UI.AddMoreQuestions();
            }
            else
            {
                int correctScore = 0;
                bool gameOver = false;
                while (!gameOver)
                {
                    if (questionList.Count != 0)
                    {
                        int j = random.Next(questionList.Count);

                        QuizCard question = questionList[j];
                        UI.DisplayQuestion(question);

                        UI.DisplayAnswers(question);

                        int selectedAnswer = UI.ChooseAnswer();
                        bool correctSolution = Logic.CheckAnswer(selectedAnswer, question);
                        if(correctSolution)
                        {
                            correctScore++;
                        }
                        questionList.RemoveAt(j);
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
            Console.ReadLine();
        }
    }
}
