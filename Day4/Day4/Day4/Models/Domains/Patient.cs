using Day4.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Models.Domains
{
    public class Patient
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PESEL { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }

        public bool ActiveAccount { get; set; }
        public int GenderId { get; set; }

        public Gender Gender { get; set; }

    }
}
