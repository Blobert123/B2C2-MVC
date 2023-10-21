using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B2C2_2023_Inleveropdracht_MVC.Migrations
{
    /// <inheritdoc />
    public partial class KlassenNaarDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bestellings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TotaalPrijs = table.Column<int>(type: "int", nullable: false),
                    KlantId = table.Column<int>(type: "int", nullable: false),
                    Punten = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestellings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klantenkaarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Punten = table.Column<int>(type: "int", nullable: false),
                    Korting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klantenkaarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prijs = table.Column<int>(type: "int", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Naam", "Wachtwoord" },
                values: new object[] { 1, "Admin", "Wachtwoord" });

            migrationBuilder.InsertData(
                table: "Bestellings",
                columns: new[] { "Id", "KlantId", "ProductId", "Punten", "TotaalPrijs" },
                values: new object[] { 1, 0, 1, 1, 5 });

            migrationBuilder.InsertData(
                table: "Klantenkaarts",
                columns: new[] { "Id", "Korting", "Punten" },
                values: new object[] { 1, 5, 40 });

            migrationBuilder.InsertData(
                table: "Klants",
                columns: new[] { "Id", "Naam", "Wachtwoord" },
                values: new object[] { 1, "Klant1", "Wachtwoord" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Beschrijving", "Prijs" },
                values: new object[] { 1, "Product beschrijving 123", 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Bestellings");

            migrationBuilder.DropTable(
                name: "Klantenkaarts");

            migrationBuilder.DropTable(
                name: "Klants");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
