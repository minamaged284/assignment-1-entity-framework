using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StuIDID",
                table: "studCourse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_studCourse_StuIDID",
                table: "studCourse",
                column: "StuIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_studCourse_students_StuIDID",
                table: "studCourse",
                column: "StuIDID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studCourse_students_StuIDID",
                table: "studCourse");

            migrationBuilder.DropIndex(
                name: "IX_studCourse_StuIDID",
                table: "studCourse");

            migrationBuilder.DropColumn(
                name: "StuIDID",
                table: "studCourse");
        }
    }
}
