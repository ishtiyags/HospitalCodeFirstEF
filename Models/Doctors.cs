namespace HospitalApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }      // Primary Key
        public string Name { get; set; }
        public string Specialty { get; set; }

        // Navigation property (One doctor can have many patients)
        public List<Patient> Patients { get; set; }
    }
}
