﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PizzaWorld.Storing.Migrations
{
    [DbContext(typeof(PizzaWorldContext))]
    partial class PizzaWorldContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<long?>("UserEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("StoreEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Orders");
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
                            EntityId = 637465591856093746L,
                            Name = "Dominos"
                        },
                        new
                        {
                            EntityId = 637465591856105522L,
                            Name = "Pizza Hut"
                        });
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Topping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("APizzaModelEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.HasIndex("APizzaModelEntityId");

                    b.ToTable("Topping");
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

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            EntityId = 637465591856113801L,
                            Name = "Darren"
                        },
                        new
                        {
                            EntityId = 637465591856113830L,
                            Name = "Fred"
                        },
                        new
                        {
                            EntityId = 637465591856113833L,
                            Name = "Isaiah"
                        });
                });

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId");

                    b.OwnsOne("PizzaWorld.Domain.Models.Crust", "Crust", b1 =>
                        {
                            b1.Property<long>("APizzaModelEntityId")
                                .HasColumnType("bigint");

                            b1.Property<long>("EntityId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Price")
                                .HasColumnType("float");

                            b1.HasKey("APizzaModelEntityId");

                            b1.ToTable("Crusts");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelEntityId");
                        });

                    b.OwnsOne("PizzaWorld.Domain.Models.Size", "Size", b1 =>
                        {
                            b1.Property<long>("APizzaModelEntityId")
                                .HasColumnType("bigint");

                            b1.Property<long>("EntityId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Price")
                                .HasColumnType("float");

                            b1.HasKey("APizzaModelEntityId");

                            b1.ToTable("Sizes");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelEntityId");
                        });

                    b.Navigation("Crust");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Store", "store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaWorld.Domain.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserEntityId");

                    b.Navigation("store");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Topping", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Abstracts.APizzaModel", null)
                        .WithMany("Toppings")
                        .HasForeignKey("APizzaModelEntityId");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.Navigation("Toppings");
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
