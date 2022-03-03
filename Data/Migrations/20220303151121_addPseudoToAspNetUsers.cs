using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onliga.Data.Migrations
{
    public partial class addPseudoToAspNetUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
            name: "Pseudo",
            table: "AspNetUsers",
            nullable: false,
            maxLength: 20);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
