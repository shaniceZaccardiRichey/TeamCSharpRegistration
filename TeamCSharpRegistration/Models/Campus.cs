using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    public class Campus
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } //nullable
        public int Phone { get; set; } //nullable
    }
}
