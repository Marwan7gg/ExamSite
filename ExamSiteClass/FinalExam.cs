using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    public class FinalExam :Exam
    {
        public FinalExam(int time, int numberOfQuestion) : base(time, numberOfQuestion)
        {

        }
        public override void showExam()
        {

            Console.WriteLine("Final Exam");

            foreach (var question in Questions)
            {
                question.DispLayTheQuestion();
            }

        }

        public void showResultAndQuestionsAndMarksAfterEnding()
        {
            if (Questions?.Length > 0)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    Console.WriteLine($"question {i + 1} : {Questions[i].HeaderOfQuestion}");
                    Console.WriteLine($" {Questions[i].BodyOfTheQuestion}");
                    Console.WriteLine($" {Questions[i].Mark}");

                    if (Questions[i] is MCQQuestion mcq)
                    {
                        Console.WriteLine("possible Answers");
                        foreach (var ans in mcq.Answers)
                        {
                            Console.WriteLine($"{ans.AnswerId} : {ans.AnswerText}");
                        }
                        Console.WriteLine($"the wirght answer is {mcq.RightAnswer.AnswerText}");
                    }
                    else if (Questions[i] is TrueOrFalseQuestion TorF)
                    {
                        Console.WriteLine($"{TorF.RightAnswer.AnswerText}");
                    }
                }
            }
        }

    }
}
