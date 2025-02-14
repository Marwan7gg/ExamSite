using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string headerOfQuestion, string bodyOfTheQuestion, int mark, Answer rightAnswer) : base(headerOfQuestion, bodyOfTheQuestion, mark, rightAnswer)
        {
            Answers = new Answer[]
            {
                new Answer(1 , "true"),

                new Answer(2 , "false"),
            };



        }


        public override void DispLayTheQuestion()
        {

            Console.WriteLine($"Header : {HeaderOfQuestion} , Body:{BodyOfTheQuestion} , ( 1 for true or 2 for false)");


        }


    }
}
