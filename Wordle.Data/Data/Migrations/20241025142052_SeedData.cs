using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wordle.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "HasBeenPicked", "LastDatePicked", "Text" },
                values: new object[,]
                {
                    { new Guid("07e17255-0597-4d9c-ae09-d192899dd58a"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3897), "timer" },
                    { new Guid("0ba179bc-26be-4cad-8604-4f011a85b91d"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3845), "ghoul" },
                    { new Guid("1228e521-f815-43cd-818a-6e1cc398351c"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3784), "apple" },
                    { new Guid("152ea109-3d47-4358-87de-d48bc14cd980"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3893), "south" },
                    { new Guid("1ec17595-ba0d-4c69-b2aa-e75fff9b1cb5"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3856), "harsh" },
                    { new Guid("28bd30d5-0016-4c19-9af1-88997622ca1a"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3873), "mount" },
                    { new Guid("30b1f7bb-0dc1-4f9a-b320-d94dda6a85ad"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3867), "karma" },
                    { new Guid("3cbf7026-0410-4fdc-acae-b68ef1530030"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3838), "donut" },
                    { new Guid("3e14ee02-0787-455b-8bb1-6e292f982bb5"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3899), "under" },
                    { new Guid("443e2f67-1d94-4220-8b86-2c6d75960fc2"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3843), "found" },
                    { new Guid("5463f1a9-733c-420e-aa9e-e4bf072cc6de"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3879), "offer" },
                    { new Guid("562d7821-7ba3-41c0-bf9a-4e2bb0881aa6"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3885), "query" },
                    { new Guid("58cd89c0-e343-4740-b96b-996a87e8e02c"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3906), "xerox" },
                    { new Guid("676ed03d-6da8-4031-a9bf-fa66968cb325"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3840), "elder" },
                    { new Guid("67dbac2c-f099-4323-8ac1-e21afc34add7"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3836), "chair" },
                    { new Guid("69b5932a-125d-4188-932d-1ffb4e58c60f"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3870), "liver" },
                    { new Guid("71466e99-596e-4689-aae2-e0df31790ce9"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3890), "round" },
                    { new Guid("7d307cd4-7119-487b-a3e8-f32b10db7894"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3833), "broke" },
                    { new Guid("a8481094-220b-48d8-9dac-e6d9c1b09613"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3876), "novel" },
                    { new Guid("d32ec034-96b5-4baf-af43-04eb94c861db"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3911), "yield" },
                    { new Guid("d4551233-bb8f-4ad9-aa7e-2a14b813b148"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3901), "vocal" },
                    { new Guid("e9afa264-eb36-4e2d-baf9-7e57e00787f4"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3860), "index" },
                    { new Guid("f17fb8cc-e702-4308-81a9-4b3fb50fb878"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3913), "zebra" },
                    { new Guid("fc7f0ad0-d8ad-45d6-9fa4-b354396c13b6"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3863), "juice" },
                    { new Guid("fde410f9-b8b7-46ca-858f-b6cf0556d12a"), false, new DateTime(2024, 10, 25, 16, 20, 51, 752, DateTimeKind.Local).AddTicks(3903), "worth" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("07e17255-0597-4d9c-ae09-d192899dd58a"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0ba179bc-26be-4cad-8604-4f011a85b91d"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1228e521-f815-43cd-818a-6e1cc398351c"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("152ea109-3d47-4358-87de-d48bc14cd980"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1ec17595-ba0d-4c69-b2aa-e75fff9b1cb5"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("28bd30d5-0016-4c19-9af1-88997622ca1a"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("30b1f7bb-0dc1-4f9a-b320-d94dda6a85ad"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3cbf7026-0410-4fdc-acae-b68ef1530030"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3e14ee02-0787-455b-8bb1-6e292f982bb5"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("443e2f67-1d94-4220-8b86-2c6d75960fc2"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5463f1a9-733c-420e-aa9e-e4bf072cc6de"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("562d7821-7ba3-41c0-bf9a-4e2bb0881aa6"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("58cd89c0-e343-4740-b96b-996a87e8e02c"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("676ed03d-6da8-4031-a9bf-fa66968cb325"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("67dbac2c-f099-4323-8ac1-e21afc34add7"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("69b5932a-125d-4188-932d-1ffb4e58c60f"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("71466e99-596e-4689-aae2-e0df31790ce9"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7d307cd4-7119-487b-a3e8-f32b10db7894"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a8481094-220b-48d8-9dac-e6d9c1b09613"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d32ec034-96b5-4baf-af43-04eb94c861db"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d4551233-bb8f-4ad9-aa7e-2a14b813b148"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e9afa264-eb36-4e2d-baf9-7e57e00787f4"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f17fb8cc-e702-4308-81a9-4b3fb50fb878"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fc7f0ad0-d8ad-45d6-9fa4-b354396c13b6"));

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fde410f9-b8b7-46ca-858f-b6cf0556d12a"));
        }
    }
}
