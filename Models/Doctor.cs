using System;

namespace MouthOopChallenge.Models
{
    public class Doctor : Person
    {
        public int YearsPracticing { get; }
        public string AcademicSuffix { get; }
        public Doctor(string firstName, string lastName, int yearsPracticing, string academicSuffix = "DMD") : base(firstName, lastName)
        {
            YearsPracticing = yearsPracticing;
            AcademicSuffix = academicSuffix;
        }

        public void InspectMouth(Person person)
        {
            Console.WriteLine($"After inspecting {person.FirstName}'s mouth, my decade of education has lead me to the determination that it is {(person.Mouth.IsOpen ? "open" : "closed")}.");
        }

        public bool RequestMouthOpen(Person person)
        {
            return person.OpenMouthByRequest(this);
        }

        public bool RequestMouthClose(Person person)
        {
            return person.CloseMouthByRequest(this);
        }
    }
}