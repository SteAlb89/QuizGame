using System;

namespace QuizGame
{
    public class UI
    {
        public static void DisplayWelcomeInformation()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("Welcome To Our Interactive Game ~~ QUIZ ~~~ ");
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
        public static void DisplayTotalScore(int correctScore)
        {
            Console.WriteLine($"The total score is: {correctScore}");
        }
        public static void QuestionFinished()
        {
            Console.WriteLine("Sorry , we don't have anymore question");
        }
    }
}




