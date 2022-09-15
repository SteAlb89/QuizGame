using System.Collections.Generic;
using System;

namespace QuizGame
{
    public class QuizCard
    {
        public string Question;
        public List<string> Answers = new List<string>(4);
        public int RightAnswer;
    }
}
