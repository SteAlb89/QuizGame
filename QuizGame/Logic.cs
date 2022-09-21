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
        public static List<QuizCard> QuizList()
        {
            QuizCard question1 = new QuizCard();
            question1.Question = "What is the color of the sky?";
            question1.Answers.Add("1. Green");
            question1.Answers.Add("2. Red");
            question1.Answers.Add("3. Blue");
            question1.Answers.Add("4. White");
            question1.RightAnswer = 2;

            QuizCard question2 = new QuizCard();
            question2.Question = "How many bones are in the human body?";
            question2.Answers.Add("1. 206");
            question2.Answers.Add("2. 201");
            question2.Answers.Add("3. 213");
            question2.Answers.Add("4. 207");
            question2.RightAnswer = 0;

            QuizCard question3 = new QuizCard();
            question3.Question = "What is the only food that cannot go bad?";
            question3.Answers.Add("1. Dark Chocolate");
            question3.Answers.Add("2. Peanut Butter");
            question3.Answers.Add("3. Canned Tuna");
            question3.Answers.Add("4. Honey");
            question3.RightAnswer = 3;

            QuizCard question4 = new QuizCard();
            question4.Question = "Which of these EU countries does not use the euro as its currency?";
            question4.Answers.Add("1. Poland");
            question4.Answers.Add("2. Denmark");
            question4.Answers.Add("3. Sweden");
            question4.Answers.Add("4. All of the above");
            question4.RightAnswer = 3;

            QuizCard question5 = new QuizCard();
            question5.Question = "Which country’s national animal is a unicorn?";
            question5.Answers.Add("1. Scotland");
            question5.Answers.Add("2. New Zealand");
            question5.Answers.Add("3. France");
            question5.Answers.Add("4. Egypt");
            question5.RightAnswer = 0;

            List<QuizCard> questionList = new List<QuizCard>();
            questionList.Add(question1);
            questionList.Add(question2);
            questionList.Add(question3);
            questionList.Add(question4);
            questionList.Add(question5);

            return questionList;
        }
        public static bool CheckAnswer(int selectedAnswer, QuizCard checkAnswer )
        {
            selectedAnswer -= 1;
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
