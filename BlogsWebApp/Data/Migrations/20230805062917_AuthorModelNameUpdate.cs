using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogsWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorModelNameUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Blog",
                newName: "userName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userName",
                table: "Blog",
                newName: "UserID");
        }
    }
}
