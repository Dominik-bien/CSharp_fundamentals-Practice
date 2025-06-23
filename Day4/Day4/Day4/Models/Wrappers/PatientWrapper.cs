


namespace Day4.Models.Wrappers
{
   public class PatientWrapper
    {

        public PatientWrapper()
        {
            Gender = new GenderWrapper();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        
        public bool ActiveAccount { get; set; } 
        public GenderWrapper Gender {  get; set; }



    }
}
