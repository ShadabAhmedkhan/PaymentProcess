﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Payment.Models;

namespace Payment.Migrations
{
    [DbContext(typeof(PaymentDbContext))]
    [Migration("20210313083103_update model")]
    partial class updatemodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Payment.Models.PaymentState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("PaymentId")
                        .HasColumnName("PaymentId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProcessPaymentPaymentId")
                        .HasColumnType("uuid");

                    b.Property<string>("State")
                        .HasColumnName("State")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProcessPaymentPaymentId");

                    b.ToTable("PaymentState");
                });

            modelBuilder.Entity("Payment.Models.ProcessPayment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PaymentId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnName("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("CardHolder")
                        .HasColumnName("CardHolder")
                        .HasColumnType("text");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnName("CreditCardNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnName("ExpirationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SecurityCode")
                        .HasColumnName("SecurityCode")
                        .HasColumnType("text");

                    b.HasKey("PaymentId");

                    b.ToTable("ProcessPayment");
                });

            modelBuilder.Entity("Payment.Models.PaymentState", b =>
                {
                    b.HasOne("Payment.Models.ProcessPayment", "ProcessPayment")
                        .WithMany()
                        .HasForeignKey("ProcessPaymentPaymentId");
                });
#pragma warning restore 612, 618
        }
    }
}