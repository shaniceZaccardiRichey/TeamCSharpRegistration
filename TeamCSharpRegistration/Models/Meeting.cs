using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    // Create model and define properties - Shanice
    public class Meeting
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string? Building { get; set; } //nullable
        public string? Room { get; set; } //nullable
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Day { get; set; }

        // Establish foreign keys - Shanice
        public int SectionID { get; set; } //foreign key
        public Section Section { get; set; }
        public int CampusID { get; set; } //foreign key
        public Campus Campus { get; set; }

        public Meeting()
        {

        }

        //Create constructor - Marshall
        public Meeting(int iD, int sectionID, string type, int campusID, string building, string room, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, string day)
        {
            ID = iD;
            SectionID = sectionID;
            Type = type;
            CampusID = campusID;
            Building = building;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
            StartTime = startTime;
            EndTime = endTime;
            Day = day;
        }

    }
}
