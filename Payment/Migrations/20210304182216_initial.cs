using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreditCardNumber = table.Column<string>(nullable: true),
                    CardHolder = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    SecurityCode = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessPayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentState",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    PPID = table.Column<Guid>(nullable: false),
                    ProcessPaymentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentState_ProcessPayment_ProcessPaymentId",
                        column: x => x.ProcessPaymentId,
                        principalTable: "ProcessPayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentState_ProcessPaymentId",
                table: "PaymentState",
                column: "ProcessPaymentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentState");

            migrationBuilder.DropTable(
                name: "ProcessPayment");
        }
    }
}
