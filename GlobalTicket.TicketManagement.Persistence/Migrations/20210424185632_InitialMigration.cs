using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalTicket.TicketManagement.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    OrderTotal = table.Column<int>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false),
                    OrderPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("18fcdf5e-e36a-45f6-9554-827ca0367b06"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Concerts" },
                    { new Guid("4b7209d3-06be-4595-aab6-8a2307ab4943"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Musicals" },
                    { new Guid("ecb7e526-bdf7-4ee9-a955-a5388f6fd1ed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Plays" },
                    { new Guid("65157130-0489-4cf0-bd4f-4d44b237e57c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Conferences" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "OrderPaid", "OrderPlaced", "OrderTotal", "UserId" },
                values: new object[,]
                {
                    { new Guid("abe9c743-4a18-402c-976d-1f98ac7d0f0e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 4, 24, 21, 56, 32, 90, DateTimeKind.Local).AddTicks(5399), 200, new Guid("cef94dee-a7b0-49b4-915e-c8bb764f89c7") },
                    { new Guid("9b739dd9-ac04-4f68-b33a-91ba54b091d3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 4, 24, 21, 56, 32, 90, DateTimeKind.Local).AddTicks(7125), 300, new Guid("ff5f5fe1-b4a3-492b-9477-4ce6174f0627") }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "CreatedBy", "CreatedDate", "Date", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "Price" },
                values: new object[] { new Guid("b0aa8647-403e-4fb6-aad1-727820b97caf"), "Sezen Aksu", new Guid("18fcdf5e-e36a-45f6-9554-827ca0367b06"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 24, 21, 56, 32, 87, DateTimeKind.Local).AddTicks(4175), "Bu bir Sezen Aksu konseri için yapılan açıklamadır.", "https://images.app.goo.gl/kCcpzuubW44VtY8F6", null, null, "Sezen Aksu Live", 300 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "CreatedBy", "CreatedDate", "Date", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "Price" },
                values: new object[] { new Guid("e56c5e17-e600-4b69-92e3-f41778cebceb"), "Erol Evgin", new Guid("18fcdf5e-e36a-45f6-9554-827ca0367b06"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 21, 56, 32, 90, DateTimeKind.Local).AddTicks(2350), "Bu bir Erol Evgin konseri için yapılan açıklamadır.", "https://images.app.goo.gl/S8TC2NSkmhpyLrnr9", null, null, "Erol Evgin Live", 200 });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
