using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogsWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class BlogAuthorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Blog");
        }
    }
}
