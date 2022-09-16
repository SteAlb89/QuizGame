using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeInformation();


            while(true)
            {
                QuizCard Question = new QuizCard();
                List<QuizCard> questionList = Logic.QuizList();

                Random random = new Random();
                int i = random.Next(questionList.Count);

                QuizCard question = questionList[i];

                UI.DisplayQuestion(question);

                UI.DisplayAnswer(question);

                int selectedAnswer = UI.ChooseAnswer();

                bool solution = Logic.CheckAnswer(selectedAnswer, Question);

                UI.DisplayRightAnswer(solution);
            }
            
            Console.ReadLine();
        }
    }
}
