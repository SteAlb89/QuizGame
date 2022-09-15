using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public class Logic
    {
        public static List<QuizCard> ListOfQuiz()
        {
            QuizCard Question1 = new QuizCard();
            Question1.Question = "What is the color of the sky?";
            Question1.Answers.Add("1. Green");
            Question1.Answers.Add("2. Red");
            Question1.Answers.Add("3. Blue");
            Question1.Answers.Add("4. White");
            Question1.RightAnswer = 2;

            QuizCard Question2 = new QuizCard();
            Question2.Question = "How many bones are in the human body?";
            Question2.Answers.Add("1. 206");
            Question2.Answers.Add("2. 201");
            Question2.Answers.Add("3. 213");
            Question2.Answers.Add("4. 207");
            Question2.RightAnswer = 0;

            QuizCard Question3 = new QuizCard();
            Question3.Question = "What is the only food that cannot go bad?";
            Question3.Answers.Add("1. Dark Chocolate");
            Question3.Answers.Add("2. Peanut Butter");
            Question3.Answers.Add("3. Canned Tuna");
            Question3.Answers.Add("4. Honey");
            Question3.RightAnswer = 3;

            QuizCard Question4 = new QuizCard();
            Question4.Question = "Which of these EU countries does not use the euro as its currency?";
            Question4.Answers.Add("1. Poland");
            Question4.Answers.Add("2. Denmark");
            Question4.Answers.Add("3. Sweden");
            Question4.Answers.Add("3. All of the above");
            Question4.RightAnswer = 4;

            QuizCard Question5 = new QuizCard();
            Question5.Question = "Which country’s national animal is a unicorn?";
            Question5.Answers.Add("1. Scotland");
            Question5.Answers.Add("2. New Zealand");
            Question5.Answers.Add("3. France");
            Question5.Answers.Add("4. Egypt");
            Question5.RightAnswer = 0;

            List<QuizCard> ListOfQuestion = new List<QuizCard>();
            ListOfQuestion.Add(Question1);
            ListOfQuestion.Add(Question2);
            ListOfQuestion.Add(Question3);
            ListOfQuestion.Add(Question4);
            ListOfQuestion.Add(Question5);

            return ListOfQuestion;
        }

        public static bool CheckAnswer(int selectedAnswer, QuizCard checkAnswer )
        {
            if (checkAnswer.RightAnswer == selectedAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
