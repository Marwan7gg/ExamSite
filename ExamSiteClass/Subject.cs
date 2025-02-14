using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSiteClass
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName, Exam subjectExam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            SubjectExam = subjectExam;
        }


        public void CreateExam()
        {
            Console.WriteLine($"Exam For Subject : {SubjectName} with id {SubjectId} created ");
            SubjectExam.showExam();
        }
    }
}
