using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public int SectionID { get; set; }
        public string Type { get; set; }
        public int CampusID { get; set; }
        public string Building { get; set; } //nullable
        public string Room { get; set; } //nullable
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Day { get; set; }
    }
}
