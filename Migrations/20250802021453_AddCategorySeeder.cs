using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Klinik.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorySeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Categories (Name, Image, Description, Status) VALUES
                ('General Medicine', 'https://example.com/images/general_medicine.jpg', 'General medicine services for all ages.', true),
                ('Pediatrics', 'https://example.com/images/pediatrics.jpg', 'Specialized care for children and adolescents.', true),
                ('Dermatology', 'https://example.com/images/dermatology.jpg', 'Skin care and treatment services.', true),
                ('Cardiology', 'https://example.com/images/cardiology.jpg', 'Heart health and cardiovascular services.', true),
                ('Orthopedics', 'https://example.com/images/orthopedics.jpg', 'Bone and joint care services.', true);
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //truncate the Categories table to remove seeded data
            migrationBuilder.Sql("TRUNCATE TABLE Categories;");
        }
    }
}
