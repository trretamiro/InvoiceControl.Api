using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceControl.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Number = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Complement = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Neighborhood = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Telephone = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAdress = table.Column<long>(type: "bigint", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    StateRegistration = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                    table.ForeignKey(
                        name: "CT_Provider_Addresss",
                        column: x => x.IdAdress,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAdress = table.Column<long>(type: "bigint", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    StateRegistration = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Id);
                    table.ForeignKey(
                        name: "CT_Receiver_Addresss",
                        column: x => x.IdAdress,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<long>(type: "bigint", maxLength: 10, nullable: false),
                    DateIssue = table.Column<DateTime>(type: "date", nullable: false),
                    VerificationCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    IntermediateIdent = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    IntermediateName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    ServiceDesc = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    Amount = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    UnitaryValue = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    ItemValue = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    NoteValue = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    Taxes = table.Column<decimal>(type: "decimal(10,3)", maxLength: 30, nullable: false),
                    INSS = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    IRRF = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    CSLL = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    CONFIS = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    PIS = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    PASEB = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    ServiceCode = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    DeductionsValue = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    BasisCalculation = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    Aliquot = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    ISSValue = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(10,3)", maxLength: 20, nullable: false),
                    Information = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    ReceiverId = table.Column<long>(type: "bigint", nullable: false),
                    ProviderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Services_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Services_Receiver_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Receiver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Services_ProviderId",
                table: "Invoice_Services",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Services_ReceiverId",
                table: "Invoice_Services",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Provider_IdAdress",
                table: "Provider",
                column: "IdAdress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_IdAdress",
                table: "Receiver",
                column: "IdAdress",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice_Services");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropTable(
                name: "Receiver");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
