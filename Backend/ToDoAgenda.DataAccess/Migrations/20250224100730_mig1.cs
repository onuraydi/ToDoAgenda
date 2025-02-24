using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ToDoAgenda.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportanceLevels",
                columns: table => new
                {
                    importanceLevelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    importanceLevelDegree = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportanceLevels", x => x.importanceLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Net",
                columns: table => new
                {
                    netId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    totalQuestionCount = table.Column<int>(type: "integer", nullable: false),
                    trueCount = table.Column<int>(type: "integer", nullable: false),
                    falseCount = table.Column<int>(type: "integer", nullable: false),
                    totalNet = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Net", x => x.netId);
                });

            migrationBuilder.CreateTable(
                name: "OtherType",
                columns: table => new
                {
                    otherTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherType", x => x.otherTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    taskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    taskName = table.Column<string>(type: "text", nullable: false),
                    taskDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.taskId);
                });

            migrationBuilder.CreateTable(
                name: "TestQuestion",
                columns: table => new
                {
                    testQuestionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    totalQuestionCount = table.Column<int>(type: "integer", nullable: false),
                    trueCount = table.Column<int>(type: "integer", nullable: false),
                    falseCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestion", x => x.testQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    themeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    themeDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.themeId);
                });

            migrationBuilder.CreateTable(
                name: "Timers",
                columns: table => new
                {
                    timerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    targetTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    completeTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    totalBreakTime = table.Column<TimeSpan>(type: "interval", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timers", x => x.timerId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    UserSurname = table.Column<string>(type: "text", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ExamTrial",
                columns: table => new
                {
                    examTrialId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    netId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTrial", x => x.examTrialId);
                    table.ForeignKey(
                        name: "FK_ExamTrial_Net_netId",
                        column: x => x.netId,
                        principalTable: "Net",
                        principalColumn: "netId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultTypes",
                columns: table => new
                {
                    resultTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    netId = table.Column<int>(type: "integer", nullable: false),
                    examTrialId = table.Column<int>(type: "integer", nullable: false),
                    testQuestionId = table.Column<int>(type: "integer", nullable: false),
                    themeId = table.Column<int>(type: "integer", nullable: false),
                    otherTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultTypes", x => x.resultTypeId);
                    table.ForeignKey(
                        name: "FK_ResultTypes_ExamTrial_examTrialId",
                        column: x => x.examTrialId,
                        principalTable: "ExamTrial",
                        principalColumn: "examTrialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultTypes_Net_netId",
                        column: x => x.netId,
                        principalTable: "Net",
                        principalColumn: "netId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultTypes_OtherType_otherTypeId",
                        column: x => x.otherTypeId,
                        principalTable: "OtherType",
                        principalColumn: "otherTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultTypes_TestQuestion_testQuestionId",
                        column: x => x.testQuestionId,
                        principalTable: "TestQuestion",
                        principalColumn: "testQuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultTypes_Theme_themeId",
                        column: x => x.themeId,
                        principalTable: "Theme",
                        principalColumn: "themeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    resultId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    resultTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.resultId);
                    table.ForeignKey(
                        name: "FK_Results_ResultTypes_resultTypeId",
                        column: x => x.resultTypeId,
                        principalTable: "ResultTypes",
                        principalColumn: "resultTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefinedTasks",
                columns: table => new
                {
                    DefinedTaskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    taskId = table.Column<int>(type: "integer", nullable: false),
                    resultId = table.Column<int>(type: "integer", nullable: false),
                    timerId = table.Column<int>(type: "integer", nullable: false),
                    importanceLevelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinedTasks", x => x.DefinedTaskId);
                    table.ForeignKey(
                        name: "FK_DefinedTasks_ImportanceLevels_importanceLevelId",
                        column: x => x.importanceLevelId,
                        principalTable: "ImportanceLevels",
                        principalColumn: "importanceLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefinedTasks_Results_resultId",
                        column: x => x.resultId,
                        principalTable: "Results",
                        principalColumn: "resultId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefinedTasks_Tasks_taskId",
                        column: x => x.taskId,
                        principalTable: "Tasks",
                        principalColumn: "taskId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefinedTasks_Timers_timerId",
                        column: x => x.timerId,
                        principalTable: "Timers",
                        principalColumn: "timerId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExamTrial_netId",
                table: "ExamTrial",
                column: "netId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_resultTypeId",
                table: "Results",
                column: "resultTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultTypes_examTrialId",
                table: "ResultTypes",
                column: "examTrialId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultTypes_netId",
                table: "ResultTypes",
                column: "netId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultTypes_otherTypeId",
                table: "ResultTypes",
                column: "otherTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultTypes_testQuestionId",
                table: "ResultTypes",
                column: "testQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultTypes_themeId",
                table: "ResultTypes",
                column: "themeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefinedTasks");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ImportanceLevels");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Timers");

            migrationBuilder.DropTable(
                name: "ResultTypes");

            migrationBuilder.DropTable(
                name: "ExamTrial");

            migrationBuilder.DropTable(
                name: "OtherType");

            migrationBuilder.DropTable(
                name: "TestQuestion");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "Net");
        }
    }
}
