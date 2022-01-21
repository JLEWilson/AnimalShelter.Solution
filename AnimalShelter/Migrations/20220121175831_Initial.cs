using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Species = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "ArrivalDate", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 2, 6, new DateTime(2017, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Luna", "Cat" },
                    { 1, 3, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Milo", "Cat" },
                    { 3, 3, new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Nala", "Cat" },
                    { 4, 2, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Leo", "Cat" },
                    { 5, 5, new DateTime(2018, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Charlie", "Cat" },
                    { 6, 2, new DateTime(2020, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Daisy", "Dog" },
                    { 7, 1, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Bailey", "Dog" },
                    { 8, 2, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "Lola", "Dog" },
                    { 9, 3, new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Max", "Dog" },
                    { 10, 2, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Dule", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
