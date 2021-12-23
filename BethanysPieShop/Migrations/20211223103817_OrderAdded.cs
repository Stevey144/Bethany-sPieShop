using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BethanysPieShop.Migrations
{
    public partial class OrderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Orders",
              columns: table => new
              {
                  OrderId = table.Column<int>(nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  FirstName = table.Column<string>(nullable: true),
                  LastName = table.Column<string>(nullable: true),
                  AddressLine1 = table.Column<string>(nullable: true),
                  AddressLine2 = table.Column<string>(nullable: true),
                  ZipCode = table.Column<string>(nullable: true),
                  City = table.Column<string>(nullable: true),
                  State = table.Column<string>(nullable: true),
                  Country = table.Column<string>(nullable: true),
                  PhoneNumber = table.Column<string>(nullable: true),
                  Email = table.Column<string>(nullable: true),
                  OrderTotal = table.Column<decimal>(nullable: false),
                  OrderPlaced = table.Column<DateTime>(nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Orders", x => x.OrderId);
              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
