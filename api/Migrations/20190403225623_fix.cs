using Microsoft.EntityFrameworkCore.Migrations;

namespace Fisher.Bookstore.Api.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "publicationDate",
                table: "Books",
                newName: "PublishDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishDate",
                table: "Books",
                newName: "publicationDate");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                nullable: true);
        }
    }
}
