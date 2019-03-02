using System;

namespace StudentAttendance
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public bool HasSixOrMore()
        {
            return (Scores.Length > 5)? true : false;
        }
    }
}