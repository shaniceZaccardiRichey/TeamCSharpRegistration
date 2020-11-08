using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    public class SectionViewModel { 
        public Section Section { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        public Campus Campus { get; set; }
        public List<Meeting> Meetings { get; set; }
    }
}
