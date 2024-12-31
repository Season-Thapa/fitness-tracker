using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pri.Ee.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddGaolProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Goals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Goals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "76cfb95d-89d1-4b69-bd03-82e4a91da733");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "4ed06383-8fb8-4b57-bff8-e16576a5f628");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "017b77ef-d4bb-4d9e-a527-906ab27b5c49", "AQAAAAIAAYagAAAAEAyoCwNrAIfrKb5awR0Z6vELr8Li9dvg0ymu7cdLymyXSqnnTnmD5BOnw6yrIQOYQg==", "7a0f897c-9788-4426-8397-d11ea00844ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96cb51e2-0a1b-4896-affa-bbe56895a03b", "AQAAAAIAAYagAAAAENoU5iwuZ9YJWHnZbdWTcEf00AYIZAG6JBzsppPSCZVM4MONYetczKBiGQRVnnCyQw==", "6f7708bd-d202-4a13-90f5-b5cf737b1743" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "EndDate", "Progress", "StartDate", "Target", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d90faaf-6ada-423d-b65f-dcf937b99c58"), "Run 10 km this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("54962663-d7b6-4e03-9320-1fb0ec8fee53"), "Swim 3 kilometers this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("746203a7-967c-4923-85a5-57b981a9b80e"), "Complete 5 yoga sessions", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("bcd758a4-26db-4e3a-ad95-f275f4a6b3a4"), "Burn 1000 calories this week", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("c97bd82d-fbb3-4ee4-a2f9-6a47480ea223"), "Lose 2 kg in 2 months", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "Date", "Duration", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("0034f97f-706a-4497-aad7-1b9979200535"), 600, new DateTime(2024, 12, 30, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9576), 90, "Hiking", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("1204ade3-a6cf-4088-9263-bbabc2b96195"), 100, new DateTime(2024, 12, 24, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9526), 30, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("5a0ff8b4-fd16-4875-86cd-e74e49f6300d"), 400, new DateTime(2024, 12, 27, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9562), 40, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6c74a235-8f0d-41ec-b517-dfc617797508"), 350, new DateTime(2024, 12, 25, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9530), 50, "Weightlifting", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("81a941cf-5c26-4174-b81c-627da537c630"), 270, new DateTime(2024, 12, 26, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9556), 25, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("8f3b5d5b-65a3-4ef3-af55-7dd54e7028d6"), 120, new DateTime(2024, 12, 29, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9571), 35, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("9907414f-d8d9-4ac6-aefa-685577fd5bf4"), 500, new DateTime(2024, 12, 22, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9515), 60, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("a0f9eaae-ac82-4770-9d20-06812a1abc7a"), 400, new DateTime(2024, 12, 23, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9521), 45, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("a5c21f8b-a84c-4343-8201-4ca1aa4b08b7"), 300, new DateTime(2024, 12, 21, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9403), 30, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("b2e6a753-c4e7-4843-96c0-f8fdf97edb8d"), 450, new DateTime(2024, 12, 28, 14, 10, 59, 694, DateTimeKind.Local).AddTicks(9567), 50, "Swimming", "00000000-0000-0000-0000-000000000002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("0d90faaf-6ada-423d-b65f-dcf937b99c58"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("54962663-d7b6-4e03-9320-1fb0ec8fee53"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("746203a7-967c-4923-85a5-57b981a9b80e"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("bcd758a4-26db-4e3a-ad95-f275f4a6b3a4"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("c97bd82d-fbb3-4ee4-a2f9-6a47480ea223"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("0034f97f-706a-4497-aad7-1b9979200535"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("1204ade3-a6cf-4088-9263-bbabc2b96195"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("5a0ff8b4-fd16-4875-86cd-e74e49f6300d"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("6c74a235-8f0d-41ec-b517-dfc617797508"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("81a941cf-5c26-4174-b81c-627da537c630"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("8f3b5d5b-65a3-4ef3-af55-7dd54e7028d6"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("9907414f-d8d9-4ac6-aefa-685577fd5bf4"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("a0f9eaae-ac82-4770-9d20-06812a1abc7a"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("a5c21f8b-a84c-4343-8201-4ca1aa4b08b7"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("b2e6a753-c4e7-4843-96c0-f8fdf97edb8d"));

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Goals");

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
    }
}
