using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAO.Migrations
{
    public partial class startup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblFuncionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    HorarioEntrada = table.Column<string>(nullable: true),
                    HorarioSaida = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFuncionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblTiposEnderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTiposEnderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblTiposTelefones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTiposTelefones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailFuncionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Principal = table.Column<bool>(nullable: false),
                    ProprietarioId = table.Column<Guid>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailFuncionario_TblFuncionarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "TblFuncionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblEnderecoFuncionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cep = table.Column<string>(nullable: true),
                    Cidade = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Principal = table.Column<bool>(nullable: false),
                    ProprietarioId = table.Column<Guid>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    TipoEnderecoId = table.Column<int>(nullable: true),
                    UF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEnderecoFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblEnderecoFuncionario_TblFuncionarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "TblFuncionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEnderecoFuncionario_TblTiposEnderecos_TipoEnderecoId",
                        column: x => x.TipoEnderecoId,
                        principalTable: "TblTiposEnderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblTelefoneFuncionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoPais = table.Column<string>(nullable: true),
                    CodigoRegiao = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    Principal = table.Column<bool>(nullable: false),
                    ProprietarioId = table.Column<Guid>(nullable: true),
                    Ramal = table.Column<string>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    TipoTelefoneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTelefoneFuncionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblTelefoneFuncionarios_TblFuncionarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "TblFuncionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblTelefoneFuncionarios_TblTiposTelefones_TipoTelefoneId",
                        column: x => x.TipoTelefoneId,
                        principalTable: "TblTiposTelefones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailFuncionario_ProprietarioId",
                table: "EmailFuncionario",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEnderecoFuncionario_ProprietarioId",
                table: "TblEnderecoFuncionario",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TblEnderecoFuncionario_TipoEnderecoId",
                table: "TblEnderecoFuncionario",
                column: "TipoEnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTelefoneFuncionarios_ProprietarioId",
                table: "TblTelefoneFuncionarios",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTelefoneFuncionarios_TipoTelefoneId",
                table: "TblTelefoneFuncionarios",
                column: "TipoTelefoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailFuncionario");

            migrationBuilder.DropTable(
                name: "TblEnderecoFuncionario");

            migrationBuilder.DropTable(
                name: "TblTelefoneFuncionarios");

            migrationBuilder.DropTable(
                name: "TblTiposEnderecos");

            migrationBuilder.DropTable(
                name: "TblFuncionarios");

            migrationBuilder.DropTable(
                name: "TblTiposTelefones");
        }
    }
}
