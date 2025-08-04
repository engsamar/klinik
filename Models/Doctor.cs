namespace Klinik.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Facebook { get; set; } = string.Empty;
        public string Instagram { get; set; } = string.Empty;
        public string Twitter { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool Status { get; set; }

        public Category? Category { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        

    }
}
