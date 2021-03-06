﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheAmazingQuickBuy.Repository.Context;

namespace TheAmazingQuickBuy.Repository.Migrations
{
    [DbContext(typeof(QuickBuyContext))]
    [Migration("20200216044439_ajeitado")]
    partial class ajeitado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressNumber")
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("DateDelivered");

                    b.Property<DateTime>("DateOrder");

                    b.Property<int>("FormOfPaymentId");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FormOfPaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("QuantityItem");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.ObjectValue.FormOfPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("FormOfPayment");
                });

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.Entities.Order", b =>
                {
                    b.HasOne("TheAmazingQuickBuy.Domain.ObjectValue.FormOfPayment", "FormOfPayment")
                        .WithMany()
                        .HasForeignKey("FormOfPaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheAmazingQuickBuy.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheAmazingQuickBuy.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("TheAmazingQuickBuy.Domain.Entities.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
