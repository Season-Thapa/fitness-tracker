using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Ee.Core.Migrations
{
    /// <inheritdoc />
    public partial class Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurned = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "c2d98d40-dbd9-4a20-ac8a-72503e7e2b3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "35934bf3-4aa3-4040-a03a-9bf731fa8863");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5b23012-0b86-4d35-91e3-50834ae3b7fd", "AQAAAAIAAYagAAAAEGD6CuncRXosBfcE7KTXULz113rODifN5R0xeV1O3rvoZAwojWhMQo+1Pyi3GFSHSw==", "65c24bbc-962e-428f-bcf6-2d46238965d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e14f6de-9dbb-439e-8cc8-1f20e532697c", "AQAAAAIAAYagAAAAEPlHQ46bJG1h5WienTZq0AD3xldhsRUjnuDokXaEFOcLJgJNND7z/Rdo5ye3NX/j1w==", "aaed7c49-6612-40c8-9a3d-85e73a4d44e6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "1e555e20-22a2-43da-a744-b9788e71428f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "4f90a12b-258c-4424-8676-80462351ebd1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb7b1105-e149-4af0-9a85-c87cfa3f90fd", "AQAAAAIAAYagAAAAEH2q9FTY1nbibxDUIfQQ7SOX255sZAJgTpFsPW2nPmgdeO9i9kXYSvgZntKXbzWcdg==", "7c6da4d9-e9f9-4ab5-b259-bc22c9e9257d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2155899e-b35b-4b93-9cfe-b3893fa7671d", "AQAAAAIAAYagAAAAEG5owka90OVsIEGjM28Cvy/ByIFa6FPz12WEtJcRJSuoCjWXZwte0/nWHvSxJGdteQ==", "49b3d818-078b-43d2-b953-931c9d733fb8" });
        }
    }
}
