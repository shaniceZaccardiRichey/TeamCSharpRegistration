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
        public Course CourseID { get; set; } //foreign key
        public int InstructorID { get; set; } //nullable
        public Campus CampusID { get; set; } //foreign key
        public string Building { get; set; } //nullable
        public string Room { get; set; } //nullable
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Seats { get; set; }
        public int StudentsEnrolled { get; set; }
        public string ScheduleType { get; set; }
        public string Notes { get; set; }


        //Create constructor - Marshall
        public Section(int iD, string number, int cRN, Course courseID, int instructorID, Campus campusID, string building, string room, string type, DateTime startDate, DateTime endDate, int seats, int studentsEnrolled, string scheduleType, string notes)
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
