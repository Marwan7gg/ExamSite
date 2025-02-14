using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    public abstract class Question
    {
        public string HeaderOfQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(string headerOfQuestion, string bodyOfTheQuestion, int mark, Answer rightAnswer)
        {
            HeaderOfQuestion = headerOfQuestion;
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
            RightAnswer = rightAnswer;
        }

        public abstract void DispLayTheQuestion();


    }
}

