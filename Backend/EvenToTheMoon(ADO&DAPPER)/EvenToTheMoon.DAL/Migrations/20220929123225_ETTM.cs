using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvenToTheMoon.DAL.Migrations
{
    public partial class ETTM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfDiscount = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Size = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HotelType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HotelClass = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeNutrition = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TourCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourCategorie = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tour = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    DateOfDepartue = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    CityOfDepartue = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CountOfPerson = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    DaysAndNights = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    ID_Country = table.Column<int>(type: "int", nullable: false),
                    ID_Hotel = table.Column<int>(type: "int", nullable: false),
                    ID_Discount = table.Column<int>(type: "int", nullable: false),
                    ID_Nutrition = table.Column<int>(type: "int", nullable: false),
                    ID_Tour_Categories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Country_ID_Country",
                        column: x => x.ID_Country,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_Discount_ID_Discount",
                        column: x => x.ID_Discount,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_Hotel_ID_Hotel",
                        column: x => x.ID_Hotel,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_Nutrition_ID_Nutrition",
                        column: x => x.ID_Nutrition,
                        principalTable: "Nutrition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_TourCategories_ID_Tour_Categories",
                        column: x => x.ID_Tour_Categories,
                        principalTable: "TourCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ID_Country",
                table: "Tours",
                column: "ID_Country");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ID_Discount",
                table: "Tours",
                column: "ID_Discount");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ID_Hotel",
                table: "Tours",
                column: "ID_Hotel");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ID_Nutrition",
                table: "Tours",
                column: "ID_Nutrition");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_ID_Tour_Categories",
                table: "Tours",
                column: "ID_Tour_Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "TourCategories");
        }
    }
}
