using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Primera.Migrations
{
    /// <inheritdoc />
    public partial class primae : Migration
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
                name: "FK_Vehiculos_Clientes_Id_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_Id_Cliente",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<string>(
                name: "NoPlaca",
                table: "Vehiculos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

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
                name: "FK_Tickets_EspacioEstacionamientos_Id_Espacio",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Tarifas_Id_Tarifa",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<string>(
                name: "NoPlaca",
                table: "Vehiculos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Id_Cliente",
                table: "Vehiculos",
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
    }
}
