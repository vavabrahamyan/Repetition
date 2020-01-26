
using Home.Lesson.Repository.Attributes;
using System;

namespace Home.Lesson.Repository.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        //[DateFormat("dd/MM/yyyy")]
        [DateFormat]
        public DateTime BirthDay { get; set; }

        [Ignore]
        public int Age
        {
            get
            {
                TimeSpan age = DateTime.Now - BirthDay;
                return age.Days / 365;
            }
        }

        public override string ToString()
        {
            return $"{FirstName}\t{Lastname}\t{Age}";
        }
    }
}
