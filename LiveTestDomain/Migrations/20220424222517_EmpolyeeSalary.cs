using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveTestDomain.Migrations
{
    public partial class EmpolyeeSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "empolyees",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "empolyees");
        }
    }
}
