namespace Klinik.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        public int DoctorId { get; set; }
        public bool Status { get; set; } //pending, confirmed, cancelled, etc.
        public DateTime AppointmentDate { get; set; }
        
        public Doctor? Doctor { get; set; }

    }
}
