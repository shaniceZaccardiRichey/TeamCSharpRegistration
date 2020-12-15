using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    // Shanice - Create SectionViewModel to group models to send to Section view @Model
    public class SectionViewModel { 
        public Section Section { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        public Campus Campus { get; set; }
        public List<Meeting> Meetings { get; set; }

        public SectionViewModel()
        {
            
        }

    }
}
