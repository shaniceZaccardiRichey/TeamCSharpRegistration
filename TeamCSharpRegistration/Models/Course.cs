using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    public class Course
    {
        public int ID { get; set; } //primary key
        public string Department { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public int LectureHours { get; set; } //nullable
        

        public Course()
        {
       
        }

        public Course(string department, int number, string title, string description, int creditHours)
        {
            Department = department;
            Number = number;
            Title = title;
            Description = description;
            CreditHours = creditHours;
        }
    }
}
