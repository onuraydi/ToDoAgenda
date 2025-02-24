using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoAgenda.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "resultId",
                table: "DefinedTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DefinedTasks_importanceLevelId",
                table: "DefinedTasks",
                column: "importanceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedTasks_resultId",
                table: "DefinedTasks",
                column: "resultId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedTasks_taskId",
                table: "DefinedTasks",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedTasks_timerId",
                table: "DefinedTasks",
                column: "timerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedTasks_ImportanceLevels_importanceLevelId",
                table: "DefinedTasks",
                column: "importanceLevelId",
                principalTable: "ImportanceLevels",
                principalColumn: "importanceLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedTasks_Results_resultId",
                table: "DefinedTasks",
                column: "resultId",
                principalTable: "Results",
                principalColumn: "resultId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedTasks_Tasks_taskId",
                table: "DefinedTasks",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "taskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedTasks_Timers_timerId",
                table: "DefinedTasks",
                column: "timerId",
                principalTable: "Timers",
                principalColumn: "timerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefinedTasks_ImportanceLevels_importanceLevelId",
                table: "DefinedTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_DefinedTasks_Results_resultId",
                table: "DefinedTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_DefinedTasks_Tasks_taskId",
                table: "DefinedTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_DefinedTasks_Timers_timerId",
                table: "DefinedTasks");

            migrationBuilder.DropIndex(
                name: "IX_DefinedTasks_importanceLevelId",
                table: "DefinedTasks");

            migrationBuilder.DropIndex(
                name: "IX_DefinedTasks_resultId",
                table: "DefinedTasks");

            migrationBuilder.DropIndex(
                name: "IX_DefinedTasks_taskId",
                table: "DefinedTasks");

            migrationBuilder.DropIndex(
                name: "IX_DefinedTasks_timerId",
                table: "DefinedTasks");

            migrationBuilder.AlterColumn<int>(
                name: "resultId",
                table: "DefinedTasks",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
