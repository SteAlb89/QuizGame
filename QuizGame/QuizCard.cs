using System.Collections.Generic;
using System;

namespace QuizGame
{
    public class QuizCard
    {
        public string question;
        public List<string> answers = new List<string> {};
        public int rightAnswer;
    }
}
