using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelier.DataAccessLayer.Migrations
{
    public partial class update_aboutid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutUsID",
                table: "Abouts",
                newName: "AboutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "AboutUsID");
        }
    }
}
