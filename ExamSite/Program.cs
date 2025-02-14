using ExamSiteClass;
namespace ExamSite
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region validation on numbers of question 

            Console.Write("Question numbers ");
            int QuestionNum;
            while (!int.TryParse(Console.ReadLine(), out QuestionNum) || QuestionNum <= 0)
            {
                Console.WriteLine("number must be positive integer");
            }
            #endregion



            #region storing questions

            Question[] questions = new Question[QuestionNum];

            #endregion

            #region Add question

            for (int i = 0; i < questions.Length; i++)
            {
                Console.Write("Q1 :");
                Console.Write("please enter 1 for MCQ question and 2 for true or false ");
                int Qtype;

                while (!int.TryParse(Console.ReadLine(), out Qtype) || (Qtype != 1 && Qtype != 2))
                {
                    Console.Write("please enter 1 for MCQ question and 2 foe true or false");
                }

                Console.Write("header : ");
                string header = Console.ReadLine();

                Console.Write("body : ");
                string body = Console.ReadLine();

                Console.Write("Mark : ");
                int mark;

                while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                {
                    Console.WriteLine("invalid enter positive only");
                }

                /*add mcq question*/
                #region add MCQ Question
                if (Qtype == 1)
                {
                    Console.WriteLine("enter possible answers  from 2 to 4 ");

                    int AnswersNumber;
                    while (!int.TryParse(Console.ReadLine(), out AnswersNumber) || AnswersNumber <= 1 || AnswersNumber > 4)
                    {
                        Console.WriteLine("enter possible answers  from 2 to 4");
                    }

                    Answer[] answers = new Answer[AnswersNumber];
                    Console.WriteLine("null is not valid enter a value ");
                    for (int j = 0; j < AnswersNumber; j++)
                    {
                        Console.WriteLine($"enter answer {j + 1} :");

                        string answerText = Console.ReadLine();

                        answers[j] = new Answer(j + 1, answerText);
                    }

                    Console.WriteLine("enter number of the correct answer");
                    int correctAnsID;
                    while (!int.TryParse(Console.ReadLine(), out correctAnsID) || correctAnsID < 1 || correctAnsID > AnswersNumber)
                    {
                        Console.WriteLine("invalid enter avalid answer");
                    }

                    Answer rightAnswer = answers[correctAnsID - 1];

                    questions[i] = new MCQQuestion(header, body, mark, rightAnswer, answers);


                }
                #endregion



                else
                {
                    Console.WriteLine("enter correct answer 1 for true , 2 for false");

                    int CorrectAnsId;
                    while (!int.TryParse(Console.ReadLine(), out CorrectAnsId) || (CorrectAnsId != 1 && CorrectAnsId != 2))
                    {
                        Console.WriteLine("enter correct answer 1 for true , 2 for false");
                    }

                    Answer rightAnswer = new Answer(CorrectAnsId, CorrectAnsId == 1 ? "true" : "false");
                    questions[i] = new TrueOrFalseQuestion(header, body, mark, rightAnswer);



                }

            }

            Console.Clear();

            #endregion

            #region startExam

            if (questions.Length > 0)
            {
                Console.WriteLine("Exam started");

                int totalmarks = 0;
                int userScore = 0;

                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine("question");
                    questions[i].DispLayTheQuestion();

                    Console.WriteLine("enter your answer number");

                    int userAnswerId;
                    while (!int.TryParse(Console.ReadLine(), out userAnswerId))
                    {
                        Console.WriteLine("unvalid enter number");

                    }
                    if (userAnswerId == questions[i].RightAnswer.AnswerId)
                    {
                        Console.WriteLine("Correct!");
                        userScore += questions[i].Mark;
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }

                    totalmarks += questions[i].Mark;

                }

                Console.WriteLine($"your score {userScore} / {totalmarks}");


            }

            else
            {
                Console.WriteLine("no question added ");
            }




            #endregion


        }
    }
}


    

