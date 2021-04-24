﻿// <auto-generated />
using System;
using GlobalTicket.TicketManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlobalTicket.TicketManagement.Persistence.Migrations
{
    [DbContext(typeof(GlobalTicketDbContext))]
    partial class GlobalTicketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GlobalTicket.TicketManagement.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("18fcdf5e-e36a-45f6-9554-827ca0367b06"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Concerts"
                        },
                        new
                        {
                            CategoryId = new Guid("4b7209d3-06be-4595-aab6-8a2307ab4943"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Musicals"
                        },
                        new
                        {
                            CategoryId = new Guid("ecb7e526-bdf7-4ee9-a955-a5388f6fd1ed"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Plays"
                        },
                        new
                        {
                            CategoryId = new Guid("65157130-0489-4cf0-bd4f-4d44b237e57c"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Conferences"
                        });
                });

            modelBuilder.Entity("GlobalTicket.TicketManagement.Domain.Entities.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("b0aa8647-403e-4fb6-aad1-727820b97caf"),
                            Artist = "Sezen Aksu",
                            CategoryId = new Guid("18fcdf5e-e36a-45f6-9554-827ca0367b06"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2021, 10, 24, 21, 56, 32, 87, DateTimeKind.Local).AddTicks(4175),
                            Description = "Bu bir Sezen Aksu konseri için yapılan açıklamadır.",
                            ImageUrl = "https://images.app.goo.gl/kCcpzuubW44VtY8F6",
                            Name = "Sezen Aksu Live",
                            Price = 300
                        },
                        new
                        {
                            EventId = new Guid("e56c5e17-e600-4b69-92e3-f41778cebceb"),
                            Artist = "Erol Evgin",
                            CategoryId = new Guid("18fcdf5e-e36a-45f6-9554-827ca0367b06"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 1, 24, 21, 56, 32, 90, DateTimeKind.Local).AddTicks(2350),
                            Description = "Bu bir Erol Evgin konseri için yapılan açıklamadır.",
                            ImageUrl = "https://images.app.goo.gl/S8TC2NSkmhpyLrnr9",
                            Name = "Erol Evgin Live",
                            Price = 200
                        });
                });

            modelBuilder.Entity("GlobalTicket.TicketManagement.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OrderPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("abe9c743-4a18-402c-976d-1f98ac7d0f0e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 4, 24, 21, 56, 32, 90, DateTimeKind.Local).AddTicks(5399),
                            OrderTotal = 200,
                            UserId = new Guid("cef94dee-a7b0-49b4-915e-c8bb764f89c7")
                        },
                        new
                        {
                            Id = new Guid("9b739dd9-ac04-4f68-b33a-91ba54b091d3"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 4, 24, 21, 56, 32, 90, DateTimeKind.Local).AddTicks(7125),
                            OrderTotal = 300,
                            UserId = new Guid("ff5f5fe1-b4a3-492b-9477-4ce6174f0627")
                        });
                });

            modelBuilder.Entity("GlobalTicket.TicketManagement.Domain.Entities.Event", b =>
                {
                    b.HasOne("GlobalTicket.TicketManagement.Domain.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
