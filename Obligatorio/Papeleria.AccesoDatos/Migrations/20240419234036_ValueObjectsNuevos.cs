using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Papeleria.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class ValueObjectsNuevos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Password_Password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "Email_DireccionEmail");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioFinal",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "NombreCompleto_Apellido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreCompleto_Nombre",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioFinal",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "NombreCompleto_Apellido",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NombreCompleto_Nombre",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Password_Password",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Email_DireccionEmail",
                table: "Usuarios",
                newName: "Email");
        }
    }
}
