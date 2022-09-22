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
        public static void DisplayQuestion(quizCard question)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(question.question);
        }
        //Display answer 
        public static void DisplayAnswer(quizCard answer)
        {
            answer.answer.ForEach(Console.WriteLine);
            Console.WriteLine("************************************************");
        }
        //Read user input and convert it to an index
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

        //Display how many corect answers he knew
        public static void DisplayRightAnswerOrNot(bool right, int corectScore)
        {
            if (right)
            {
                corectScore++;
                Console.WriteLine($"You had {corectScore} correct answers");
            }
        }
    }
}




