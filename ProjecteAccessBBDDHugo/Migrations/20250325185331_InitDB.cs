using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjecteAccessBBDDHugo.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Simulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoresSol = table.Column<double>(type: "float", nullable: false),
                    VelocitatVent = table.Column<double>(type: "float", nullable: false),
                    CabalAigua = table.Column<double>(type: "float", nullable: false),
                    Rati = table.Column<double>(type: "float", nullable: false),
                    EnergiaGenerada = table.Column<double>(type: "float", nullable: false),
                    CostKWh = table.Column<double>(type: "float", nullable: false),
                    PreuKWh = table.Column<double>(type: "float", nullable: false),
                    DataHora = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simulations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Simulations");
        }
    }
}
