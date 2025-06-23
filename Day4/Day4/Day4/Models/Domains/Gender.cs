using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Models.Domains
{
    public class Gender
    {
        public Gender() {
            Patients = new Collection<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Patient> Patients { get; set; }

    }
}
