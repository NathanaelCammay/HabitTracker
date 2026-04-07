using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HabitTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HabitEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HabitId = table.Column<int>(type: "int", nullable: false),
                    DateLogged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GymSession_WorkoutType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GymSession_DurationMinutes = table.Column<int>(type: "int", nullable: true),
                    GymSession_WeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CodingSession_Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodingSession_DurationMinutes = table.Column<int>(type: "int", nullable: true),
                    CodingSession_Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NutritionDetail_Calories = table.Column<int>(type: "int", nullable: true),
                    NutritionDetail_ProteinGrams = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NutritionDetail_FatGrams = table.Column<int>(type: "int", nullable: true),
                    NutritionDetail_CarbohydratesGrams = table.Column<int>(type: "int", nullable: true),
                    CommunicationDetail_SkillFocusedOn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CommunicationDetail_ConfidenceScore = table.Column<int>(type: "int", nullable: true),
                    CommunicationDetail_Reflection = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitEntries_Habits_HabitId",
                        column: x => x.HabitId,
                        principalTable: "Habits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HabitEntries_HabitId_DateLogged",
                table: "HabitEntries",
                columns: new[] { "HabitId", "DateLogged" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabitEntries");

            migrationBuilder.DropTable(
                name: "Habits");
        }
    }
}
