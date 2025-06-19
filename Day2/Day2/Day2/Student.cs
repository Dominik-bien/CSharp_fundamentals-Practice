
using System;

namespace Day2
{
    //public class Address
    //{
    //    public string City { get; set; }
    //    public string Street { get; set; }
    //}
    //public class Student : Person
    public class Student
    {

        //public Student()
        //{
        //    Address = new Address();
        //}

        //private string _property;
        //public string MyProperty {
        //    get
        //    {
        //        if (_property == "1")
        //            throw new System.Exception("Invalid Value");

        //        return _property;
        //    }
        //    set
        //    {
        //        System.Windows.Forms.MessageBox.Show("Assign value - set");
        //        _property = value;
        //    }
        //}

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Comments { get; set; }

        public string Math {  get; set; }
        public string Physics { get; set; }
        public string English { get; set; }

        //public Address address { get; set; }

        //public override string GetInfo()
        //{
        //    return $"{FirstName} {LastName} - Math mark: {Math}.";

        //}
    }

}
