using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamCSharpRegistration.Models
{
    public class Campus
    {
        public Campus(int iD, string code, string name, string address, string phone)
        {
            ID = iD;
            Code = code;
            Name = name;
            Address = address;
            Phone = phone;
        }

        public int ID { get; set; } //primary key
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } //nullable
        public string Phone { get; set; } //nullable
    }
}
