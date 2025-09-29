using System;
using System.Linq;
using HospitalApp.Models;
using HospitalApp;

namespace CodeFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new HospitalContext())
            {
                // Add sample doctors if none exist
                if (!context.Doctors.Any())
                {
                    var doctor1 = new Doctor { Name = "Dr. Smith", Specialty = "Cardiology" };
                    var doctor2 = new Doctor { Name = "Dr. Johnson", Specialty = "Neurology" };

                    context.Doctors.AddRange(doctor1, doctor2);
                    context.SaveChanges();

                    // Add some patients
                    var patient1 = new Patient { Name = "Alice", Age = 30, DoctorId = doctor1.DoctorId };
                    var patient2 = new Patient { Name = "Bob", Age = 25, DoctorId = doctor2.DoctorId };

                    context.Patients.AddRange(patient1, patient2);
                    context.SaveChanges();
                }

                // Read and display data
                var patients = context.Patients
                    .Select(p => new { p.Name, p.Age, DoctorName = p.Doctor.Name })
                    .ToList();

                Console.WriteLine("Patients List:");
                foreach (var p in patients)
                {
                    Console.WriteLine($"{p.Name} ({p.Age}) - Doctor: {p.DoctorName}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
