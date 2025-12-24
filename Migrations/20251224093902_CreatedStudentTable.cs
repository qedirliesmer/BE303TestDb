using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE303TestDb.Migrations
{
    /// <inheritdoc />
    public partial class CreatedStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "StudentDetailId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentDetailId",
                table: "Students",
                column: "StudentDetailId",
                unique: true,
                filter: "[StudentDetailId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentDetails_StudentDetailId",
                table: "Students",
                column: "StudentDetailId",
                principalTable: "StudentDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentDetails_StudentDetailId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentDetailId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentDetailId",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
