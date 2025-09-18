using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaSaint.Infrestructura.Migrations
{
    /// <inheritdoc />
    public partial class gEntidades1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Edad",
                schema: "CAT",
                table: "Paciente",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                schema: "CAT",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
