using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    public abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfQuestion { get; set; }

        public Question[] Questions { get; set; }

        protected Exam(int time, int numberOfQuestion)
        {
            Time = time;
            NumberOfQuestion = numberOfQuestion;
            Questions = new Question[NumberOfQuestion];
        }

        public abstract void showExam();


    }
}
