using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaSaint.Infrestructura.Migrations
{
    /// <inheritdoc />
    public partial class CSDS01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CAT");

            migrationBuilder.EnsureSchema(
                name: "RES");

            migrationBuilder.CreateTable(
                name: "Cliente",
                schema: "CAT",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                schema: "CAT",
                columns: table => new
                {
                    IdMedico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Identificacion = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.IdMedico);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                schema: "CAT",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Quirofano",
                schema: "CAT",
                columns: table => new
                {
                    IdQuirofano = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HorarioDisponible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quirofano", x => x.IdQuirofano);
                });

            migrationBuilder.CreateTable(
                name: "ReservaConsultaExterna",
                schema: "RES",
                columns: table => new
                {
                    IdReservaConsultaExterna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroConsulta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaConsultaExterna", x => x.IdReservaConsultaExterna);
                    table.ForeignKey(
                        name: "FK_ReservaConsultaExterna_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalSchema: "CAT",
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaConsultaExterna_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalSchema: "CAT",
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservaQuirofano",
                schema: "RES",
                columns: table => new
                {
                    IdReservaQuirofano = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroReserva = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaAgendamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCirugia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InicioCirugia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinCirugia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuracionEstimadaHoras = table.Column<int>(type: "int", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    Anestesiólogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdQuirofano = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaQuirofano", x => x.IdReservaQuirofano);
                    table.ForeignKey(
                        name: "FK_ReservaQuirofano_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalSchema: "CAT",
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaQuirofano_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalSchema: "CAT",
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaQuirofano_Quirofano_IdQuirofano",
                        column: x => x.IdQuirofano,
                        principalSchema: "CAT",
                        principalTable: "Quirofano",
                        principalColumn: "IdQuirofano",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cirugia",
                schema: "CAT",
                columns: table => new
                {
                    IdCirugia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IdReservaQuirofano = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpRegistro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: true),
                    IpModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UsuarioEliminacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpEliminacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cirugia", x => x.IdCirugia);
                    table.ForeignKey(
                        name: "FK_Cirugia_ReservaQuirofano_IdReservaQuirofano",
                        column: x => x.IdReservaQuirofano,
                        principalSchema: "RES",
                        principalTable: "ReservaQuirofano",
                        principalColumn: "IdReservaQuirofano",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cirugia_IdReservaQuirofano",
                schema: "CAT",
                table: "Cirugia",
                column: "IdReservaQuirofano");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaConsultaExterna_IdMedico",
                schema: "RES",
                table: "ReservaConsultaExterna",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaConsultaExterna_IdPaciente",
                schema: "RES",
                table: "ReservaConsultaExterna",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaQuirofano_IdMedico",
                schema: "RES",
                table: "ReservaQuirofano",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaQuirofano_IdPaciente",
                schema: "RES",
                table: "ReservaQuirofano",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaQuirofano_IdQuirofano",
                schema: "RES",
                table: "ReservaQuirofano",
                column: "IdQuirofano");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cirugia",
                schema: "CAT");

            migrationBuilder.DropTable(
                name: "Cliente",
                schema: "CAT");

            migrationBuilder.DropTable(
                name: "ReservaConsultaExterna",
                schema: "RES");

            migrationBuilder.DropTable(
                name: "ReservaQuirofano",
                schema: "RES");

            migrationBuilder.DropTable(
                name: "Medico",
                schema: "CAT");

            migrationBuilder.DropTable(
                name: "Paciente",
                schema: "CAT");

            migrationBuilder.DropTable(
                name: "Quirofano",
                schema: "CAT");
        }
    }
}
