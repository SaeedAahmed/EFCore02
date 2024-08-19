using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class Realtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ins_id",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Dep_id",
                table: "Student",
                newName: "Dep_Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 20, 0, 31, 57, 747, DateTimeKind.Local).AddTicks(5251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 19, 22, 17, 24, 864, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_Id",
                table: "Student",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dep_Id",
                table: "Instructors",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Top_Id",
                table: "Course",
                column: "Top_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_Top_Id",
                table: "Course",
                column: "Top_Id",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dep_Id",
                table: "Instructors",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Departments_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_Top_Id",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dep_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Departments_Dep_Id",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_Id",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dep_Id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Course_Top_Id",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "Dep_Id",
                table: "Student",
                newName: "Dep_id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 19, 22, 17, 24, 864, DateTimeKind.Local).AddTicks(7351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 20, 0, 31, 57, 747, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.AddColumn<int>(
                name: "Ins_id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
