using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Primera.Migrations
{
    /// <inheritdoc />
    public partial class prima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_EspacioEstacionamientos_Id_Espacio",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Tarifas_Id_Tarifa",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Cliente_Id_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_EspacioEstacionamientos_Id_Espacio",
                table: "Tickets",
                column: "Id_Espacio",
                principalTable: "EspacioEstacionamientos",
                principalColumn: "Id_Espacio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Tarifas_Id_Tarifa",
                table: "Tickets",
                column: "Id_Tarifa",
                principalTable: "Tarifas",
                principalColumn: "Id_Tarifa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_Id_Cliente",
                table: "Vehiculos",
                column: "Id_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_EspacioEstacionamientos_Id_Espacio",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Tarifas_Id_Tarifa",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_Id_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_EspacioEstacionamientos_Id_Espacio",
                table: "Tickets",
                column: "Id_Espacio",
                principalTable: "EspacioEstacionamientos",
                principalColumn: "Id_Espacio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Tarifas_Id_Tarifa",
                table: "Tickets",
                column: "Id_Tarifa",
                principalTable: "Tarifas",
                principalColumn: "Id_Tarifa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Cliente_Id_Cliente",
                table: "Vehiculos",
                column: "Id_Cliente",
                principalTable: "Cliente",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
