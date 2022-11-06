using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Xml.Serialization;

namespace QuizGame
{
    public class Logic
    {
        /// <summary>
        /// Create a quizlist qith questions and answers and the correct answer
        /// </summary>
        /// <returns>return the quizlist</returns>
        public static List<QuizCard> CreateQuizList()
        {
            QuizCard question1 = new QuizCard();
            question1.question = "What is the color of the sky?";
            question1.answers.Add("1. Green");
            question1.answers.Add("2. Red");
            question1.answers.Add("3. Blue");
            question1.answers.Add("4. White");
            question1.rightAnswer = 2;

            QuizCard question2 = new QuizCard();
            question2.question = "How many bones are in the human body?";
            question2.answers.Add("1. 206");
            question2.answers.Add("2. 201");
            question2.answers.Add("3. 213");
            question2.answers.Add("4. 207");
            question2.rightAnswer = 0;

            QuizCard question3 = new QuizCard();
            question3.question = "What is the only food that cannot go bad?";
            question3.answers.Add("1. Dark Chocolate");
            question3.answers.Add("2. Peanut Butter");
            question3.answers.Add("3. Canned Tuna");
            question3.answers.Add("4. Honey");
            question3.rightAnswer = 3;

            QuizCard question4 = new QuizCard();
            question4.question = "Which of these EU countries does not use the euro as its currency?";
            question4.answers.Add("1. Poland");
            question4.answers.Add("2. Denmark");
            question4.answers.Add("3. Sweden");
            question4.answers.Add("4. All of the above");
            question4.rightAnswer = 3;

            QuizCard question5 = new QuizCard();
            question5.question = "Which country’s national animal is a unicorn?";
            question5.answers.Add("1. Scotland");
            question5.answers.Add("2. New Zealand");
            question5.answers.Add("3. France");
            question5.answers.Add("4. Egypt");
            question5.rightAnswer = 0;

            List<QuizCard> questionList = new List<QuizCard>();
            questionList.Add(question1);
            questionList.Add(question2);
            questionList.Add(question3);
            questionList.Add(question4);
            questionList.Add(question5);

            return questionList;
        }
        /// <summary>
        /// check if the question answer is the same as user input answer
        /// </summary>
        /// <param name="selectedAnswer">this is the user input </param>
        /// <param name="checkAnswer">this is the correct answer of the question</param>
        /// <returns></returns>
        public static bool CheckAnswer(int selectedAnswer, QuizCard checkAnswer )
        {
            return (checkAnswer.rightAnswer == selectedAnswer);
        }
        public static void SaveQuizCardList(List<QuizCard>questionList, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuizCard>));
            using(FileStream file = File.Create(path))
            {
                serializer.Serialize(file, questionList);
            }
        }
        public static List<QuizCard> LoaQuizCArdList(string path)
        {
            List<QuizCard> questionList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuizCard>));
            using(FileStream file = File.OpenRead(path))
            {
                questionList = serializer.Deserialize(file) as List<QuizCard>;
            }
            return questionList;
        }
    }
}
