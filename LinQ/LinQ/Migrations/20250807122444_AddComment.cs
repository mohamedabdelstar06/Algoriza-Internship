using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class AddComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "Blogging",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Mohamed Abdlstar Mazal Dawla",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Url",
                schema: "Blogging",
                table: "Blogs",
                type: "int",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Mohamed Abdlstar Mazal Dawla");
        }
    }
}
