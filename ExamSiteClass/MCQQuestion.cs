using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string headerOfQuestion, string bodyOfTheQuestion, int mark, Answer rightAnswer, Answer[] answers) : base(headerOfQuestion, bodyOfTheQuestion, mark, rightAnswer)
        {
            Answers = answers;
        }



        public override void DispLayTheQuestion()
        {
            Console.WriteLine($"Hider : {HeaderOfQuestion}  ");/*head and body of Question*/
            Console.WriteLine($"Body : {BodyOfTheQuestion}");

            /*Answer of the question*/

            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine($" {i + 1}.{Answers[i].AnswerText} ");
            }

        }
    }
}
