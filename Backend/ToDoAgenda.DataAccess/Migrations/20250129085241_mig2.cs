using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoAgenda.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImportanceLevelId",
                table: "Tasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "Tasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimerId",
                table: "Tasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DefinedTaskName",
                table: "DefinedTasks",
                type: "text",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ImportanceLevels_ImportanceLevelId",
                table: "Tasks",
                column: "ImportanceLevelId",
                principalTable: "ImportanceLevels",
                principalColumn: "ImportanceLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Results_ResultId",
                table: "Tasks",
                column: "ResultId",
                principalTable: "Results",
                principalColumn: "ResultId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Timers_TimerId",
                table: "Tasks",
                column: "TimerId",
                principalTable: "Timers",
                principalColumn: "TimerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ImportanceLevels_ImportanceLevelId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Results_ResultId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Timers_TimerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ImportanceLevelId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ResultId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TimerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ImportanceLevelId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TimerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DefinedTaskName",
                table: "DefinedTasks");
        }
    }
}
