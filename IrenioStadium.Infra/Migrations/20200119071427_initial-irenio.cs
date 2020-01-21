using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IrenioStadium.Infra.Migrations
{
    public partial class initialirenio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Gol = table.Column<int>(nullable: false),
                    Assistencia = table.Column<int>(nullable: false),
                    JogadorDaPartida = table.Column<int>(nullable: false),
                    HatTrick = table.Column<int>(nullable: false),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
