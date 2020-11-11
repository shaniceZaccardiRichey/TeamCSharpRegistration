using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    // Create model and define properties - Shanice
    public class Course
    {
        public int ID { get; set; } //primary key
        public string Department { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public int? LectureHours { get; set; } //nullable

        //Create constructors - Marshall
        public Course()
        {
       
        }

        public Course(string department, string number, string title, string description, int creditHours)
        {
            Department = department;
            Number = number;
            Title = title;
            Description = description;
            CreditHours = creditHours;
        }

        public Course(int iD, string department, string number, string title, string description, int creditHours, int lectureHours)
        {
            ID = iD;
            Department = department;
            Number = number;
            Title = title;
            Description = description;
            CreditHours = creditHours;
            LectureHours = lectureHours;
        }

        // getDeptAndNumber and getCampuses methods - Marshall
        public string getDeptAndNumber()
        {
            return Department + " " + Number;
        }
        public List<Campus> getCampuses()
        {
            //not yet implemented
            List<Campus> campuses = new List<Campus>();
            campuses.Add(new Campus(0, "FV", "Florissant Valley", "3400 Pershall Road, Ferguson, MO 63135", "314-513-4200"));
            campuses.Add(new Campus(1, "FP", "Forest Park", "5600 Oakland Ave., St. Louis, MO 63110", "314-644-9100"));
            return campuses;

        }
    }
}
