namespace HospitalApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }     // Primary Key
        public string Name { get; set; }
        public int Age { get; set; }

        // Foreign key
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }     // Navigation property
    }
}
