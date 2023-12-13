using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Menu_MS.Migrations
{
    /// <inheritdoc />
    public partial class menudata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "foodLists",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Rating = table.Column<float>(type: "real", nullable: false),
                    Product_Price = table.Column<float>(type: "real", nullable: false),
                    Product_Quantity = table.Column<int>(type: "int", nullable: false),
                    Product_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empty1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodLists", x => x.Product_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "foodLists");
        }
    }
}
