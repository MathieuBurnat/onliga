using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onliga.Data.Migrations
{
    public partial class books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                           name: "Books",
                           columns: table => new
                           {
                               Id = table.Column<int>(type: "INTEGER", nullable: false)
                                   .Annotation("Sqlite:Autoincrement", true),
                               Title = table.Column<string>(type: "TEXT", nullable: true),
                               Description = table.Column<string>(type: "TEXT", nullable: true),
                               ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                               Genre = table.Column<string>(type: "TEXT", nullable: true)
                           },
                           constraints: table =>
                           {
                               table.PrimaryKey("PK_Books", x => x.Id);
                           });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
