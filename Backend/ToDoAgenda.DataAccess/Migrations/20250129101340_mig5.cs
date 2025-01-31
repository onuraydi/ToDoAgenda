using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoAgenda.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tasks_ImportanceLevelId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ResultId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TimerId",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ImportanceLevelId",
                table: "Tasks",
                column: "ImportanceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ResultId",
                table: "Tasks",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TimerId",
                table: "Tasks",
                column: "TimerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tasks_ImportanceLevelId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ResultId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TimerId",
                table: "Tasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ImportanceLevelId",
                table: "Tasks",
                column: "ImportanceLevelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ResultId",
                table: "Tasks",
                column: "ResultId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TimerId",
                table: "Tasks",
                column: "TimerId",
                unique: true);
        }
    }
}
