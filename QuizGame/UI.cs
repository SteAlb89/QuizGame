using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace QuizGame
{
    public class UI
    {
        public static void DisplayWelcomeInformation()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Welcome To Our Interactive Game ~~ QUIZ ~~~ ");
        }
        public static int AskPlayFill()
        {
            Console.Write("You may choose:  1 to add question and 2 to play: ");
            int answerPlayFill= Convert.ToInt32(Console.ReadLine());
            return answerPlayFill;
        }
        public static List<QuizCard> CreateQuestion()
        {
            QuizCard questionAnswer = new QuizCard();
            Console.WriteLine("");
            Console.Write("Please add your question: ");

            string userQuestion = Console.ReadLine();
            questionAnswer.question = userQuestion;

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Please add the {i+1} answers: ");
                string userAnswer = Console.ReadLine();
                questionAnswer.answers.Add(userAnswer);
            }
            Console.Write("Select the number of the correct answer: ");
            int correctAnswer = Convert.ToInt32(Console.ReadLine());

            questionAnswer.rightAnswer = correctAnswer;
            List<QuizCard> questionList = new List<QuizCard>();
            questionList.Add(questionAnswer);

            return CreateQuestion();
        }
        public static void DisplayQuestion(QuizCard quizCard)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(quizCard.question);
        }
        //Display answer 
        public static void DisplayAnswers(QuizCard quizCard)
        {
           foreach(string ans in quizCard.answers)
            {
                Console.WriteLine(ans);
            }
            Console.WriteLine("************************************************");
        }
        /// <summary>
        /// check if the number is between 1 and 4 ,and if isn't he ask again to enter another number
        /// </summary>
        /// <returns>return the answer minus 1</returns>
        public static int ChooseAnswer()
        {
            Console.Write("Select 1, 2, 3 or 4: ");
            int selectedAnswer = int.Parse(Console.ReadLine());
            while (selectedAnswer > 4 || selectedAnswer < 1)
            {
                Console.Write("Please enter a number between 1 - 4 included: ");
                selectedAnswer = int.Parse(Console.ReadLine());
            }
            return selectedAnswer - 1;
        }
        public static void DisplayTotalScore(bool correctSolution)
        {
            if(correctSolution)
            {
                Console.WriteLine("Your answer is correct");
            }
            else
            {
                Console.WriteLine("You answer is wrong");
            }
        }
        public static void QuestionFinished()
        {
            Console.WriteLine("Sorry , we don't have anymore questions");
        }
        public static bool AddMoreQuestions()
        {
            Console.Write("Would you like to add more questions: Y or N : ");
            string addQuestion = Console.ReadLine().ToLower();

            if (addQuestion == "y")
            {
                CreateQuestion();
            }
            return false;
        }
        public static bool PlayOwnQuestion()
        {
            Console.WriteLine("Would you like yo play your own quiz created by yourself: Y or N");
            string playOwnQuestion = Console.ReadLine().ToLower();
            if (playOwnQuestion == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void FinalScore(int correctScore)
        {
            Console.WriteLine($"Your final score is {correctScore}");
        }
    }
}




