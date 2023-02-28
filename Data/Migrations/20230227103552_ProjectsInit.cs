using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simple_Invoicing.Data.Migrations
{
    public partial class ProjectsInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
