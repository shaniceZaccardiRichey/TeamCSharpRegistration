using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }

        public Course()
        {
       
        }

        public Course(string title, int creditHours, string description)
        {
            Title = title;
            CreditHours = creditHours;
            Description = description;
        }
    }
}
