using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payment.Migrations
{
    public partial class updatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentState_ProcessPayment_ProcessPaymentId",
                table: "PaymentState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProcessPayment",
                table: "ProcessPayment");

            migrationBuilder.DropIndex(
                name: "IX_PaymentState_ProcessPaymentId",
                table: "PaymentState");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProcessPayment");

            migrationBuilder.DropColumn(
                name: "PPID",
                table: "PaymentState");

            migrationBuilder.DropColumn(
                name: "ProcessPaymentId",
                table: "PaymentState");

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentId",
                table: "ProcessPayment",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentState",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentId",
                table: "PaymentState",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProcessPaymentPaymentId",
                table: "PaymentState",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProcessPayment",
                table: "ProcessPayment",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentState_ProcessPaymentPaymentId",
                table: "PaymentState",
                column: "ProcessPaymentPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentState_ProcessPayment_ProcessPaymentPaymentId",
                table: "PaymentState",
                column: "ProcessPaymentPaymentId",
                principalTable: "ProcessPayment",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentState_ProcessPayment_ProcessPaymentPaymentId",
                table: "PaymentState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProcessPayment",
                table: "ProcessPayment");

            migrationBuilder.DropIndex(
                name: "IX_PaymentState_ProcessPaymentPaymentId",
                table: "PaymentState");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "ProcessPayment");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PaymentState");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "PaymentState");

            migrationBuilder.DropColumn(
                name: "ProcessPaymentPaymentId",
                table: "PaymentState");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ProcessPayment",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PPID",
                table: "PaymentState",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProcessPaymentId",
                table: "PaymentState",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProcessPayment",
                table: "ProcessPayment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentState_ProcessPaymentId",
                table: "PaymentState",
                column: "ProcessPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentState_ProcessPayment_ProcessPaymentId",
                table: "PaymentState",
                column: "ProcessPaymentId",
                principalTable: "ProcessPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
