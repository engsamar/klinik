using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Klinik.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Seed data for Doctors table
            migrationBuilder.Sql(@"
                INSERT INTO Doctors (Name, Bio, Image, Facebook, Instagram, Twitter, CategoryId, Status) VALUES
                ('Dr. John Doe', 'Experienced general practitioner with over 10 years in the field.', 'https://example.com/images/dr_john_doe.jpg', 'https://facebook.com/drjohn', 'https://instagram.com/drjohn', 'https://twitter.com/drjohn', 1, true),
                ('Dr. Jane Smith', 'Pediatric specialist with a passion for child health.', 'https://example.com/images/dr_jane_smith.jpg', 'https://facebook.com/drjane', 'https://instagram.com/drjane', 'https://twitter.com/drjane', 2, true),
                ('Dr. Emily Johnson', 'Dermatologist with expertise in skin conditions.', 'https://example.com/images/dr_emily_johnson.jpg', 'https://facebook.com/dremily', 'https://instagram.com/dremily', 'https://twitter.com/dremily', 3, true),
                ('Dr. Michael Brown', 'Cardiologist focused on heart health and wellness.', 'https://example.com/images/dr_michael_brown.jpg', 'https://facebook.com/drmichael', 'https://instagram.com/drmichael', 'https://twitter.com/drmichael', 4, true),
                ('Dr. Sarah Wilson', 'Orthopedic surgeon specializing in bone and joint care.', 'https://example.com/images/dr_sarah_wilson.jpg', 'https://facebook.com/drsarah', 'https://instagram.com/drsarah', 'https://twitter.com/drsarah', 5, true);         
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //truncate the Doctors table to remove seeded data
            migrationBuilder.Sql("TRUNCATE TABLE Doctors;");
        }
    }
}
