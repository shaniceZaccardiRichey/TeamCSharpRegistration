using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TeamCSharpRegistration.Models
{
    // Shanice - establish Enrolled Class model for cart to save to.
    public class EnrolledClass
    {
        public int EnrolledClassID { get; set; }

        public string UserId { get; set; } // foreign key

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        public int SectionID { get; set; } // foreign keey
        public Section Section { get; set; }

        public EnrolledClass()
        {

        }
    }
}
