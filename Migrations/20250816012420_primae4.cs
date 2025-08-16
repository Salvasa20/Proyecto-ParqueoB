using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Primera.Migrations
{
    /// <inheritdoc />
    public partial class primae4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_Id_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_Id_Cliente",
                table: "Vehiculos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId_Cliente",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ClienteId_Cliente",
                table: "Vehiculos",
                column: "ClienteId_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos",
                column: "ClienteId_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Id_Cliente",
                table: "Vehiculos",
                column: "Id_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_Id_Cliente",
                table: "Vehiculos",
                column: "Id_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
