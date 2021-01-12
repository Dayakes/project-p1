﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaWorld.Storing;

namespace PizzaWorld.Storing.Migrations
{
    [DbContext(typeof(PizzaWorldContext))]
    [Migration("20210112175835_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("EntityId");

                    b.HasIndex("OrderEntityId");

                    b.ToTable("APizzaModel");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<long?>("UserEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("StoreEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Store", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            EntityId = 637460531155636694L,
                            Name = "Dominos"
                        },
                        new
                        {
                            EntityId = 637460531155662881L,
                            Name = "Pizza Hut"
                        });
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.User", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId");

                    b.OwnsOne("PizzaWorld.Domain.Models.Crust", "Crust", b1 =>
                        {
                            b1.Property<long>("APizzaModelEntityId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .UseIdentityColumn();

                            b1.Property<long>("EntityId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Price")
                                .HasColumnType("float");

                            b1.HasKey("APizzaModelEntityId");

                            b1.ToTable("APizzaModel");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelEntityId");
                        });

                    b.OwnsOne("PizzaWorld.Domain.Models.Size", "Size", b1 =>
                        {
                            b1.Property<long>("APizzaModelEntityId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .UseIdentityColumn();

                            b1.Property<long>("EntityId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Price")
                                .HasColumnType("float");

                            b1.HasKey("APizzaModelEntityId");

                            b1.ToTable("APizzaModel");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelEntityId");
                        });

                    b.OwnsMany("PizzaWorld.Domain.Models.Topping", "Toppings", b1 =>
                        {
                            b1.Property<long>("APizzaModelEntityId")
                                .HasColumnType("bigint");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<long>("EntityId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("APizzaModelEntityId", "Id");

                            b1.ToTable("Topping");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelEntityId");
                        });

                    b.Navigation("Crust");

                    b.Navigation("Size");

                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Store", null)
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId");

                    b.HasOne("PizzaWorld.Domain.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
