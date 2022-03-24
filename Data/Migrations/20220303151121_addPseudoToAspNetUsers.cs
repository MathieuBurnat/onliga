using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onliga.Data.Migrations
{
    public partial class addPseudoToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
            name: "Pseudo",
            table: "Users",
            maxLength: 20);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
