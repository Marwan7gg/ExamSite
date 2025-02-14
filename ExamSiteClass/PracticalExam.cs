using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestion) : base(time, numberOfQuestion)
        {

        }

        public override void showExam()
        {
            Console.WriteLine("Practical Exam ");
            foreach (var question in Questions)
            {
                question.DispLayTheQuestion();
            }
        }


        public void ShowRightAnswersAfterEnding()
        {
            if (Questions?.Length > 0)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    Console.WriteLine($"question {i + 1} : {Questions[i].HeaderOfQuestion}");
                    Console.WriteLine($" {Questions[i].BodyOfTheQuestion}");


                    if (Questions[i] is MCQQuestion mcq)
                    {
                        Console.WriteLine("possible Answers");
                        foreach (var ans in mcq.Answers)
                        {
                            Console.WriteLine($"{ans.AnswerId} : {ans.AnswerText}");
                        }
                        Console.WriteLine($"the wirght answer is {mcq.RightAnswer.AnswerText}");
                    }

                }
            }
        }
    }
}
