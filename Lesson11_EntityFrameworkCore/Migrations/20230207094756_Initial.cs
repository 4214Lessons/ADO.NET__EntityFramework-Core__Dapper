using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson11_EntityFrameworkCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: true),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Soft drinks, coffees, teas, beers, and ales", "Beverages" },
                    { 2, "Sweet and savory sauces, relishes, spreads, and seasonings", "Condiments" },
                    { 3, "Desserts, candies, and sweet breads", "Confections" },
                    { 4, "Cheeses", "Dairy Products" },
                    { 5, "Breads, crackers, pasta, and cereal", "Grains/Cereals" },
                    { 6, "Prepared meats", "Meat/Poultry" },
                    { 7, "Dried fruit and bean curd", "Produce" },
                    { 8, "Seaweed and fish", "Seafood" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 1, "49 Gilbert St.", "Exotic Liquids", "(171) 555-2222" },
                    { 2, "P.O. Box 78934", "New Orleans Cajun Delights", "(100) 555-4822" },
                    { 3, "707 Oxford Rd.", "Grandma Kelly's Homestead", "(313) 555-5735" },
                    { 4, "Sekimai Musashino-shi", "Tokyo Traders", "(03) 3555-5011" },
                    { 5, "Calle del Rosal 4", "Cooperativa de Quesos", "(98) 598 76 54" },
                    { 6, "92 Setsuko Chuo-ku", "Mayumi's", "(06) 431-7877" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "SupplierId", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 1, "Chai", 1, 18.00m, (short)39 },
                    { 2, 1, "Chang", 1, 19.00m, (short)17 },
                    { 3, 2, "Aniseed Syrup", 1, 10.00m, (short)13 },
                    { 4, 2, "Chef Anton's Cajun Seasoning", 2, 22.00m, (short)53 },
                    { 5, 2, "Chef Anton's Gumbo Mix", 2, 21.35m, (short)0 },
                    { 6, 2, "Grandma's Boysenberry Spread", 3, 25.00m, (short)120 },
                    { 7, 7, "Uncle Bob's Organic Dried Pears", 3, 30.00m, (short)15 },
                    { 8, 2, "Northwoods Cranberry Sauce", 3, 40.00m, (short)6 },
                    { 9, 6, "Mishi Kobe Niku", 4, 97.00m, (short)29 },
                    { 10, 8, "Ikura", 4, 31.00m, (short)31 },
                    { 11, 4, "Queso Cabrales", 5, 21.00m, (short)22 },
                    { 12, 4, "Queso Manchego La Pastora", 5, 38.00m, (short)86 },
                    { 13, 8, "Konbu", 6, 6.00m, (short)24 },
                    { 14, 7, "Tofu", 6, 23.25m, (short)35 },
                    { 15, 2, "Genen Shouyu", 6, 15.50m, (short)39 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
