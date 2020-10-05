using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable annotations

namespace TestScoring
{
    public class Subject
    {
        public string Name { get; set; }

        public List<StudentInfo> studentInfos;

        public Subject() { }

        public Subject(string subjectName)
        {
            Name = subjectName;
            studentInfos = new List<StudentInfo>();
        }

        public void AddStudentInfo(string studentName, int studentScore)
        {
            studentInfos.Add(new StudentInfo(studentName, studentScore));
        }
    }
}
