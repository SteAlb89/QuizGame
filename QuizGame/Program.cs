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
            bool played = false;
            while(!played)
            {
                QuizCard Question = new QuizCard();
                List<QuizCard> ListOfQuestion = Logic.ListOfQuiz();

                Random random = new Random();
                int i = random.Next(ListOfQuestion.Count);

                UI.DisplayTheQuestion(ListOfQuestion[i]);

                UI.DisplayTheAnswer(ListOfQuestion[i]);

                int selectedAnswer = UI.ChooseAnAnswer();

                bool solution = Logic.CheckAnswer(selectedAnswer, Question);

                UI.DisplatRightAnswer(solution);
            }
            


            //add loops to play more than 1 gamecard

            Console.ReadLine();
        }
    }
}
