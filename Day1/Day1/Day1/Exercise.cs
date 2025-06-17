using System;


namespace Day1
{
    public class Exercise
    {
        private string _Name1;
        public string Name; 

        public Exercise(string name1)
        {
            _Name1 = name1;
            Console.WriteLine("Construct");
        }

        public Exercise()
        {
        }

        public void PollExercise() { 

        Console.WriteLine("Welcome to my first poll. What's your name? ");
            string name = Console.ReadLine();
        Console.WriteLine("What year were you born? ");
            var year = int.Parse(Console.ReadLine());

            var today = DateTime.Now.Year;

            int currentAge = today - year;

            Console.WriteLine($"Hello, {name}. You have {currentAge} age old. It was a great year");

            }

        public void sayHallo()
        {
            Console.WriteLine("Hello! User :D");
        }

        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

     
        
    }
}
