using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Gestion.Responsable.Data.Migrations
{
    public partial class uji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filiales",
                columns: table => new
                {
                    FilialeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiales", x => x.FilialeID);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    MotDePasse = table.Column<string>(nullable: true),
                    FilialeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurID);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Filiales_FilialeID",
                        column: x => x.FilialeID,
                        principalTable: "Filiales",
                        principalColumn: "FilialeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_FilialeID",
                table: "Utilisateurs",
                column: "FilialeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Filiales");
        }
    }
}
