using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Card.Migrations
{
    /// <inheritdoc />
    public partial class NewM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Satuse",
                table: "StudentCards",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "StudentCards",
                newName: "Satuse");
        }
    }
}
