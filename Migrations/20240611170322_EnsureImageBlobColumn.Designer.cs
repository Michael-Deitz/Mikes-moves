﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MikesMoves.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MikesMoves.Migrations
{
    [DbContext(typeof(MikesMovesDbContext))]
    [Migration("20240611170322_EnsureImageBlobColumn")]
    partial class EnsureImageBlobColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "01560c42-d8e0-4075-8b46-e3bbbfff3cb7",
                            Email = "admina@strator.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEJr6i3bGqNDQbFonVo69SDx74rhCCx0sagG1vgy3TyQpyy8qABS9BvJZH1fafrTQGQ==",
                            PhoneNumber = "4445556666",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95806742-4e8e-48f6-973e-d1a4f4536bae",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "d8d76512-74f1-43bb-b1fd-87d3a8aa36df",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b401712-0609-40c3-91e9-28362a5ba2e8",
                            Email = "john@doe.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEARRwPbWTmmE5swhcOATubo2dX56WIF6pr3mwNgj5MQoBBorIR0xeeuVP3kri0EJ8g==",
                            PhoneNumber = "3334445555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95611dcc-2d8e-4c42-8bcc-96a51e0cd902",
                            TwoFactorEnabled = false,
                            UserName = "JohnDoe"
                        },
                        new
                        {
                            Id = "a7d21fac-3b21-454a-a747-075f072d0cf3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba85bb35-19db-44a1-8701-595858c021ed",
                            Email = "jane@smith.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEBjfjxZrvlml4sKbmjBc9m0bIPrAyc1KrDBgq+fjN2vwYxBiBJ2du+IVPUTqfgpeHw==",
                            PhoneNumber = "2223334444",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ff27029d-d85f-408c-a3a9-e28f015ef87f",
                            TwoFactorEnabled = false,
                            UserName = "JaneSmith"
                        },
                        new
                        {
                            Id = "c806cfae-bda9-47c5-8473-dd52fd056a9b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f0d7443a-26a0-41f4-8f43-449f0a7c427a",
                            Email = "alice@johnson.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMdtB8KHZlLPQLwc4lXKtg0UmGJnocRZ0jRECMorA2uoBoAE55vVyBDwejiW92XyZg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3ac8df9d-bb6e-42a8-9568-8372977a2053",
                            TwoFactorEnabled = false,
                            UserName = "AliceJohnson"
                        },
                        new
                        {
                            Id = "9ce89d88-75da-4a80-9b0d-3fe58582b8e2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "89cc1528-6b7f-4c0c-8c52-bbe205c733bf",
                            Email = "bob@williams.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEE5wK8ErN6q9Z1FkD3nAujODOHjSmAs4Dzp39HaHghyMsgh1ksFifOQjhFt7R7UILw==",
                            PhoneNumber = "0987654321",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dc03299d-1f9b-44df-80ae-553907aff50c",
                            TwoFactorEnabled = false,
                            UserName = "BobWilliams"
                        },
                        new
                        {
                            Id = "d224a03d-bf0c-4a05-b728-e3521e45d74d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9c87867a-6221-4e29-a539-612b13ee7952",
                            Email = "Eve@Davis.comx",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEF0x6hgkUhpbasGwXTS0u1bv7bNeiT39Bri9y02BqC4qmFNle68fWwC24HVrT09Xkg==",
                            PhoneNumber = "1112223333",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "977d0607-ec7f-4c8d-85c7-2892c052bdf5",
                            TwoFactorEnabled = false,
                            UserName = "EveDavis"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        },
                        new
                        {
                            UserId = "d8d76512-74f1-43bb-b1fd-87d3a8aa36df",
                            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MikesMoves.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TrailerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TrailerId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            ImageUrl = "https://example.com/images/item1.jpg",
                            Name = "Item 1",
                            TrailerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            ImageUrl = "https://example.com/images/item2.jpg",
                            Name = "Item 2",
                            TrailerId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            ImageUrl = "https://example.com/images/item3.jpg",
                            Name = "Item 3",
                            TrailerId = 3
                        });
                });

            modelBuilder.Entity("MikesMoves.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Message 1",
                            DateCreated = new DateTime(2024, 6, 10, 12, 3, 22, 501, DateTimeKind.Local).AddTicks(1317),
                            ReceiverId = 2,
                            SenderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Message 2",
                            DateCreated = new DateTime(2024, 6, 10, 12, 3, 22, 501, DateTimeKind.Local).AddTicks(1425),
                            ReceiverId = 3,
                            SenderId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "Message 3",
                            DateCreated = new DateTime(2024, 6, 10, 12, 3, 22, 501, DateTimeKind.Local).AddTicks(1429),
                            ReceiverId = 1,
                            SenderId = 3
                        });
                });

            modelBuilder.Entity("MikesMoves.Models.Reservation", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("TrailerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateReserved")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId", "TrailerId");

                    b.HasIndex("TrailerId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            TrailerId = 1,
                            DateReserved = new DateTime(2024, 6, 10, 12, 3, 22, 501, DateTimeKind.Local).AddTicks(1476)
                        },
                        new
                        {
                            UserId = 2,
                            TrailerId = 2,
                            DateReserved = new DateTime(2024, 6, 9, 12, 3, 22, 501, DateTimeKind.Local).AddTicks(1480)
                        },
                        new
                        {
                            UserId = 3,
                            TrailerId = 3,
                            DateReserved = new DateTime(2024, 6, 8, 12, 3, 22, 501, DateTimeKind.Local).AddTicks(1488)
                        });
                });

            modelBuilder.Entity("MikesMoves.Models.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Length")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Trailers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 50m,
                            Capacity = 1000,
                            Height = 10,
                            ImageUrl = "https://example.com/images/trailer1.jpg",
                            Length = 20,
                            Location = "Location A",
                            Width = 5
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 60m,
                            Capacity = 1200,
                            Height = 12,
                            ImageUrl = "https://example.com/images/trailer2.jpg",
                            Length = 25,
                            Location = "Location B",
                            Width = 6
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 40m,
                            Capacity = 800,
                            Height = 8,
                            ImageUrl = "https://example.com/images/trailer3.jpg",
                            Length = 15,
                            Location = "Location C",
                            Width = 4
                        });
                });

            modelBuilder.Entity("MikesMoves.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("IdentityUserId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<byte[]>("ImageBlob")
                        .HasColumnType("bytea");

                    b.Property<string>("ImageLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Admina",
                            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                            ImageLocation = "https://robohash.org/numquamutut.png?size=150x150&set=set1",
                            LastName = "Strator"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            IdentityUserId = "d8d76512-74f1-43bb-b1fd-87d3a8aa36df",
                            ImageLocation = "https://robohash.org/nisiautemet.png?size=150x150&set=set1",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            IdentityUserId = "a7d21fac-3b21-454a-a747-075f072d0cf3",
                            ImageLocation = "https://robohash.org/molestiaemagnamet.png?size=150x150&set=set1",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alice",
                            IdentityUserId = "c806cfae-bda9-47c5-8473-dd52fd056a9b",
                            ImageLocation = "https://robohash.org/deseruntutipsum.png?size=150x150&set=set1",
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bob",
                            IdentityUserId = "9ce89d88-75da-4a80-9b0d-3fe58582b8e2",
                            ImageLocation = "https://robohash.org/quiundedignissimos.png?size=150x150&set=set1",
                            LastName = "Williams"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Eve",
                            IdentityUserId = "d224a03d-bf0c-4a05-b728-e3521e45d74d",
                            ImageLocation = "https://robohash.org/hicnihilipsa.png?size=150x150&set=set1",
                            LastName = "Davis"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MikesMoves.Models.Item", b =>
                {
                    b.HasOne("MikesMoves.Models.Trailer", "Trailer")
                        .WithMany("Items")
                        .HasForeignKey("TrailerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trailer");
                });

            modelBuilder.Entity("MikesMoves.Models.Message", b =>
                {
                    b.HasOne("MikesMoves.Models.UserProfile", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MikesMoves.Models.UserProfile", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("MikesMoves.Models.Reservation", b =>
                {
                    b.HasOne("MikesMoves.Models.Trailer", "Trailer")
                        .WithMany("Reservations")
                        .HasForeignKey("TrailerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikesMoves.Models.UserProfile", "UserProfile")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trailer");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("MikesMoves.Models.UserProfile", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("MikesMoves.Models.Trailer", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MikesMoves.Models.UserProfile", b =>
                {
                    b.Navigation("ReceivedMessages");

                    b.Navigation("Reservations");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}