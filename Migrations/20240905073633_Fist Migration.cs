using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carserver.Migrations
{
    public partial class FistMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaimentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base_price = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Base_Coast = table.Column<double>(type: "float", nullable: false),
                    Special_Coast = table.Column<double>(type: "float", nullable: false),
                    Association_Cost = table.Column<double>(type: "float", nullable: false),
                    Fixed_cost = table.Column<double>(type: "float", nullable: false),
                    Custom_cost = table.Column<double>(type: "float", nullable: false),
                    Total_price = table.Column<double>(type: "float", nullable: false),
                    Buy_date = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaimentDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaimentDetails");
        }
    }
}
