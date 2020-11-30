using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TeamCSharpRegistration.Models
{
    // Shanice - establish Transcript Item model for possible use.
    public class TranscriptItem
    {
        public int TranscriptItemID { get; set; }

        public string UserId { get; set; } // foreign key

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        public int CourseID { get; set; } // foreign key
        public Course Course { get; set; }

        public string Grade { get; set; }

        public TranscriptItem()
        {

        }
    }
}
