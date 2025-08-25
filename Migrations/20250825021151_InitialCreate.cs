using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Primera.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Vehiculos_Id_Vehiculo",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Id_Vehiculo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Id_Vehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Id_Vehiculo",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "NoPlaca",
                table: "Vehiculos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId_Cliente",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoPlaca",
                table: "Tickets",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "NoPlaca");

            migrationBuilder.CreateTable(
                name: "TipoVehiculos",
                columns: table => new
                {
                    Id_Tipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoPlaca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VehiculoNoPlaca = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Id_Tarifa = table.Column<int>(type: "int", nullable: false),
                    TarifaId_Tarifa = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculos", x => x.Id_Tipo);
                    table.ForeignKey(
                        name: "FK_TipoVehiculos_Tarifas_TarifaId_Tarifa",
                        column: x => x.TarifaId_Tarifa,
                        principalTable: "Tarifas",
                        principalColumn: "Id_Tarifa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoVehiculos_Vehiculos_VehiculoNoPlaca",
                        column: x => x.VehiculoNoPlaca,
                        principalTable: "Vehiculos",
                        principalColumn: "NoPlaca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_NoPlaca",
                table: "Tickets",
                column: "NoPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_TipoVehiculos_TarifaId_Tarifa",
                table: "TipoVehiculos",
                column: "TarifaId_Tarifa");

            migrationBuilder.CreateIndex(
                name: "IX_TipoVehiculos_VehiculoNoPlaca",
                table: "TipoVehiculos",
                column: "VehiculoNoPlaca");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Vehiculos_NoPlaca",
                table: "Tickets",
                column: "NoPlaca",
                principalTable: "Vehiculos",
                principalColumn: "NoPlaca",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos",
                column: "ClienteId_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Vehiculos_NoPlaca",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos");

            migrationBuilder.DropTable(
                name: "TipoVehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_NoPlaca",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "NoPlaca",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId_Cliente",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NoPlaca",
                table: "Vehiculos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "Id_Vehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "TipoVehiculo",
                table: "Vehiculos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id_Vehiculo",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "Id_Vehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Id_Vehiculo",
                table: "Tickets",
                column: "Id_Vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Vehiculos_Id_Vehiculo",
                table: "Tickets",
                column: "Id_Vehiculo",
                principalTable: "Vehiculos",
                principalColumn: "Id_Vehiculo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteId_Cliente",
                table: "Vehiculos",
                column: "ClienteId_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente");
        }
    }
}
