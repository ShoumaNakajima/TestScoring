using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable annotations

namespace TestScoring
{
    public class StudentInfo
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public StudentInfo() { }

        public StudentInfo(string studentName, int studentScore)
        {
            Name = studentName;
            Score = studentScore;
        }
    }
}
