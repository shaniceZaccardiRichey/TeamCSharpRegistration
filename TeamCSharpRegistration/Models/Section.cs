using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    // Create model and define properties - Shanice
    public class Section
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int CRN { get; set; }
        public int CourseID { get; set; } //foreign key
        public Course Course { get; set; }
        public int InstructorID { get; set; } //nullable
        public Instructor Instructor { get; set; }
        public int CampusID { get; set; } //foreign key
        public Campus Campus { get; set; }
        public string Building { get; set; } //nullable
        public string Room { get; set; } //nullable
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Seats { get; set; }
        public int StudentsEnrolled { get; set; }
        public string ScheduleType { get; set; }
        public string Notes { get; set; }

        public Section() { 
        
        }

        //Create constructor - Marshall
        public Section(int iD, string number, int cRN, int courseID, int instructorID, int campusID, string building, string room, string type, DateTime startDate, DateTime endDate, int seats, int studentsEnrolled, string scheduleType, string notes)
        {
            ID = iD;
            Number = number;
            CRN = cRN;
            CourseID = courseID;
            InstructorID = instructorID;
            CampusID = campusID;
            Building = building;
            Room = room;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Seats = seats;
            StudentsEnrolled = studentsEnrolled;
            ScheduleType = scheduleType;
            Notes = notes;
        }

    }

}
