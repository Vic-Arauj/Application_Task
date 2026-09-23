using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_Task.Database.Migrations
{
    /// <inheritdoc />
    public partial class TaskModelAddColumnCreatedTaskAndUpdateTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTask",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTask",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTask",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UpdateTask",
                table: "Tasks");
        }
    }
}
