using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScoring
{
    public class Season
    {
        public int Year { get; set; }

        public string? prophaseOrAnaphase;

        public List<Subject> subjects;

        public Season() { }

        public Season(int year, string poa)
        {
            Year = year;
            prophaseOrAnaphase = poa;

            subjects = new List<Subject>();
        }

        public void AddSubject(string subjectName, string studentName, int studentScore)
        {
            Subject subject = new Subject(subjectName);
            subject.AddStudentInfo(studentName, studentScore);
            subjects.Add(subject);
        }
    }
}
