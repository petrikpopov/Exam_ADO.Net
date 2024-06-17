using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_.Net_Core_Class_Home_Work.Migrations
{
    /// <inheritdoc />
    public partial class EmailConfirmCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailConfirmCode",
                table: "users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailConfirmCode",
                table: "users");
        }
    }
}
