using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pri.Ee.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "324f2426-cdf0-4079-abb5-f2017dca735a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "55ca22e5-d2e3-4d66-b749-292e23f072dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d42517-302b-4108-9341-3f774ee504e8", "AQAAAAIAAYagAAAAEGvf6lwwtiGZXvgFcpoVS+Xqrfz/L/v0GmKzNTuiEn/NxMvChzpa3eblsYYYTrp7CA==", "2f4d676a-33c8-4d54-aad8-1174f419c409" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e289e21b-f2b9-42da-afa3-73539f1393e4", "AQAAAAIAAYagAAAAEABA3uq6AFIglajCJ5WEGO3FOTjHhCo4BnKeFDzDPLmqhIaG2/KEGRz827Jr3vt4kw==", "aa474b39-2bd3-43ce-aa98-b8ca1632d2e2" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "Progress", "Target", "UserId" },
                values: new object[,]
                {
                    { new Guid("3e72f62d-8143-4ced-ab32-96ceebae23a4"), "Run 10 km this month", 6, 10, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("41f77a2d-8c60-4c03-ad50-c91a61956b37"), "Swim 3 kilometers this month", 1, 3, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("750caf02-b401-4a7a-b45c-818074a131ee"), "Complete 5 yoga sessions", 2, 5, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("a36662cf-02a5-4328-83d7-a2461b2d52c0"), "Lose 2 kg in 2 months", 1, 2, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("f3606610-e504-4038-a65b-e9cef19bc985"), "Burn 1000 calories this week", 750, 1000, "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "Date", "Duration", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("20259eb5-e248-434e-8687-f2c1f8fc4be1"), 100, new DateTime(2024, 12, 17, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1656), 30, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6961918d-2c31-4722-aa4a-b98859d38560"), 400, new DateTime(2024, 12, 16, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1653), 45, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6e440cdc-f88d-4541-b1af-a01564b1c8b3"), 600, new DateTime(2024, 12, 23, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1692), 90, "Hiking", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("77fd22e9-928f-4fa7-b74c-78ce7a77cad3"), 450, new DateTime(2024, 12, 21, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1688), 50, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("9ba67b4e-5f69-4e54-8626-7faef5684d3a"), 270, new DateTime(2024, 12, 19, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1684), 25, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("a573f9e1-32c1-460d-a3b0-ab22ff673cef"), 400, new DateTime(2024, 12, 20, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1686), 40, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("ab6660fa-3d74-4aba-b979-479089e2a4a4"), 350, new DateTime(2024, 12, 18, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1666), 50, "Weightlifting", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("cf38cdf5-26a3-4ba4-b0a1-e9b15ee4e515"), 500, new DateTime(2024, 12, 15, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1651), 60, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("d2a9da72-78a9-47b1-aa3c-d792e8d135bd"), 300, new DateTime(2024, 12, 14, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1547), 30, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("ea2fb51b-a31e-4ae8-b055-230acb9a19a4"), 120, new DateTime(2024, 12, 22, 16, 7, 35, 574, DateTimeKind.Local).AddTicks(1690), 35, "Yoga", "00000000-0000-0000-0000-000000000002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("3e72f62d-8143-4ced-ab32-96ceebae23a4"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("41f77a2d-8c60-4c03-ad50-c91a61956b37"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("750caf02-b401-4a7a-b45c-818074a131ee"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("a36662cf-02a5-4328-83d7-a2461b2d52c0"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("f3606610-e504-4038-a65b-e9cef19bc985"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("20259eb5-e248-434e-8687-f2c1f8fc4be1"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("6961918d-2c31-4722-aa4a-b98859d38560"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("6e440cdc-f88d-4541-b1af-a01564b1c8b3"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("77fd22e9-928f-4fa7-b74c-78ce7a77cad3"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("9ba67b4e-5f69-4e54-8626-7faef5684d3a"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("a573f9e1-32c1-460d-a3b0-ab22ff673cef"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("ab6660fa-3d74-4aba-b979-479089e2a4a4"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("cf38cdf5-26a3-4ba4-b0a1-e9b15ee4e515"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("d2a9da72-78a9-47b1-aa3c-d792e8d135bd"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("ea2fb51b-a31e-4ae8-b055-230acb9a19a4"));

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
    }
}
