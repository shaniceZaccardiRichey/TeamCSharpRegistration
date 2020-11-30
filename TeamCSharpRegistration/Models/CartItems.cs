using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    // Shanice - establish model for cart items.
    public class CartItem
    {
        public int CartItemID { get; set; }

        //public int IdentityUserID { get; set; } // foreign key
        //public IdentityUser IdentityUser { get; set; }
    
        public string UserId { get; set; } // foreign key

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }


        public int SectionID { get; set; } // foreign keey
        public Section Section { get; set; }

        public CartItem()
        {

        }

    }
}
