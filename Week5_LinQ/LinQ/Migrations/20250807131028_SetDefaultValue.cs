using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class SetDefaultValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Postat",
                schema: "Blogging");

            migrationBuilder.RenameTable(
                name: "Books",
                schema: "Blogging",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Blogs",
                schema: "Blogging",
                newName: "Blogs");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Mohamed Abdelstar",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Blogging");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Books",
                newSchema: "Blogging");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blogs",
                newSchema: "Blogging");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                schema: "Blogging",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Mohamed Abdelstar");

            migrationBuilder.CreateTable(
                name: "Postat",
                schema: "Blogging",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postat_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "Blogging",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postat_BlogId",
                schema: "Blogging",
                table: "Postat",
                column: "BlogId");
        }
    }
}
