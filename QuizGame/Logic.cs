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
        public static List<quizCard> QuizList()
        {
            quizCard question1 = new quizCard();
            question1.Question = "What is the color of the sky?";
            question1.Answers.Add("1. Green");
            question1.Answers.Add("2. Red");
            question1.Answers.Add("3. Blue");
            question1.Answers.Add("4. White");
            question1.RightAnswer = 2;

            quizCard question2 = new quizCard();
            question2.Question = "How many bones are in the human body?";
            question2.Answers.Add("1. 206");
            question2.Answers.Add("2. 201");
            question2.Answers.Add("3. 213");
            question2.Answers.Add("4. 207");
            question2.RightAnswer = 0;

            quizCard question3 = new quizCard();
            question3.Question = "What is the only food that cannot go bad?";
            question3.Answers.Add("1. Dark Chocolate");
            question3.Answers.Add("2. Peanut Butter");
            question3.Answers.Add("3. Canned Tuna");
            question3.Answers.Add("4. Honey");
            question3.RightAnswer = 3;

            quizCard question4 = new quizCard();
            question4.Question = "Which of these EU countries does not use the euro as its currency?";
            question4.Answers.Add("1. Poland");
            question4.Answers.Add("2. Denmark");
            question4.Answers.Add("3. Sweden");
            question4.Answers.Add("4. All of the above");
            question4.RightAnswer = 3;

            quizCard question5 = new quizCard();
            question5.Question = "Which country’s national animal is a unicorn?";
            question5.Answers.Add("1. Scotland");
            question5.Answers.Add("2. New Zealand");
            question5.Answers.Add("3. France");
            question5.Answers.Add("4. Egypt");
            question5.RightAnswer = 0;

            List<quizCard> questionList = new List<quizCard>();
            questionList.Add(question1);
            questionList.Add(question2);
            questionList.Add(question3);
            questionList.Add(question4);
            questionList.Add(question5);

            return questionList;
        }
        //return true or false based on user input
        public static bool CheckAnswer(int selectedAnswer, quizCard checkAnswer )
        {
            return (checkAnswer.RightAnswer == selectedAnswer);
        }
    }
}
