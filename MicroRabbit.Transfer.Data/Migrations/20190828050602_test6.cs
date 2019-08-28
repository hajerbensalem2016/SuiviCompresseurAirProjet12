using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.GestionCompresseur.Data.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_filialeDup",
                table: "filialeDup");

            migrationBuilder.RenameTable(
                name: "filialeDup",
                newName: "FilialesDup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilialesDup",
                table: "FilialesDup",
                column: "FilialeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FilialesDup",
                table: "FilialesDup");

            migrationBuilder.RenameTable(
                name: "FilialesDup",
                newName: "filialeDup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_filialeDup",
                table: "filialeDup",
                column: "FilialeID");
        }
    }
}
