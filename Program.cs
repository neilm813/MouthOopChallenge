using System;
using MouthOopChallenge.Models;

namespace MouthOopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Dennis", "Trident", 30);
            Person patient = new Person("Neil", "M", doctor);

            /* Property or indexer 'IMouth.IsOpen' cannot be assigned to -- it is read only */
            // patient.Mouth.IsOpen = true;

            doctor.InspectMouth(patient);
            Console.WriteLine(doctor.RequestMouthOpen(patient));
            doctor.InspectMouth(patient);

        }
    }
}
