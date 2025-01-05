using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pri.Ee.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddMilestone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    GoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Milestones_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "f5ca5e20-57c0-4c94-b087-0eb700f81933");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "13a3050a-cff5-4a5c-ad4c-412a443d1450");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "944f6084-75d9-49da-9202-eb117ae77c30", "AQAAAAIAAYagAAAAEEZrTiqBNtEAENLs5chyRpR1BjopGi9Retum5/BJRDQgIFn6DR0ypN/LG8B1gmJnUQ==", "9aa7cd7b-29e0-4c60-b535-fa0cd48c21d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43140505-6909-4a16-82a4-58e2cf0d028e", "AQAAAAIAAYagAAAAECgUglUqKJ3IdZ+wT3rD83IWxunFEw0W0PzkNwzUXHOOPj+7MMo2IRYKym/1lhK1UQ==", "20ca419a-5d6c-4892-b8c9-14e901b6ac0b" });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "EndDate", "Progress", "StartDate", "Target", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fedeb03-d3ba-4e19-8fdf-bd65e71e0f18"), "Lose 2 kg in 2 months", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6a94dfe1-50e7-43e2-a1c4-dae844a90c39"), "Complete 5 yoga sessions", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("97ea1c82-4a63-4f5a-9c55-f8bc0e9a773d"), "Burn 1000 calories this week", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("d545023d-f0b0-476b-b1d9-d7dd59237940"), "Swim 3 kilometers this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "00000000-0000-0000-0000-000000000002" },
                    { new Guid("fa93776e-2751-44bd-9b54-63e3b0eccb21"), "Run 10 km this month", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "Date", "Duration", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("09251331-9350-4e97-9aa9-c4c12c29b5e3"), 270, new DateTime(2024, 12, 31, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7153), 25, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("1951152d-20e1-4b00-b636-3f62f2a36f9d"), 300, new DateTime(2024, 12, 26, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7073), 30, "Running", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("3b213f0a-3f76-4934-bb82-9b45b726e032"), 100, new DateTime(2024, 12, 29, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7140), 30, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("3bd964d3-acbb-44b5-82e6-f4258c54588b"), 600, new DateTime(2025, 1, 4, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7162), 90, "Hiking", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("4888d859-df8f-43a6-ba3b-2aced6ef6495"), 450, new DateTime(2025, 1, 2, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7157), 50, "Swimming", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("57d74fa0-ff02-4a8f-9c69-a7f8031e2271"), 400, new DateTime(2025, 1, 1, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7155), 40, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("6431a704-d51f-4216-8db2-7a4a02425945"), 350, new DateTime(2024, 12, 30, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7142), 50, "Weightlifting", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("76d71e75-98a1-44d6-b272-055b7daf4836"), 500, new DateTime(2024, 12, 27, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7132), 60, "Cycling", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("b9062a69-a591-49ff-aee4-5220703a0144"), 120, new DateTime(2025, 1, 3, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7159), 35, "Yoga", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("ecd4e575-1226-429f-919f-c8fd8a15aeff"), 400, new DateTime(2024, 12, 28, 19, 44, 35, 691, DateTimeKind.Local).AddTicks(7138), 45, "Swimming", "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_GoalId",
                table: "Milestones",
                column: "GoalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("0fedeb03-d3ba-4e19-8fdf-bd65e71e0f18"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("6a94dfe1-50e7-43e2-a1c4-dae844a90c39"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("97ea1c82-4a63-4f5a-9c55-f8bc0e9a773d"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("d545023d-f0b0-476b-b1d9-d7dd59237940"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("fa93776e-2751-44bd-9b54-63e3b0eccb21"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("09251331-9350-4e97-9aa9-c4c12c29b5e3"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("1951152d-20e1-4b00-b636-3f62f2a36f9d"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("3b213f0a-3f76-4934-bb82-9b45b726e032"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("3bd964d3-acbb-44b5-82e6-f4258c54588b"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("4888d859-df8f-43a6-ba3b-2aced6ef6495"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("57d74fa0-ff02-4a8f-9c69-a7f8031e2271"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("6431a704-d51f-4216-8db2-7a4a02425945"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("76d71e75-98a1-44d6-b272-055b7daf4836"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("b9062a69-a591-49ff-aee4-5220703a0144"));

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: new Guid("ecd4e575-1226-429f-919f-c8fd8a15aeff"));

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
    }
}
