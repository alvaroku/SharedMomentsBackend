﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedMomentsBackend.App.DB;

#nullable disable

namespace SharedMomentsBackend.App.DB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.AlbumUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("UserId");

                    b.ToTable("AlbumUsers");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Moment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("UserId");

                    b.ToTable("Moments");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.MomentResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MomentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MomentId");

                    b.HasIndex("ResourceId");

                    b.ToTable("MomentResources");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a0aa029-963a-49b2-b0fe-7a7055131229"),
                            CreatedAt = new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9870),
                            IsActive = true,
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9873)
                        },
                        new
                        {
                            Id = new Guid("004b448a-aace-4857-9da3-23b5b013e4ad"),
                            CreatedAt = new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9876),
                            IsActive = true,
                            Name = "User",
                            UpdatedAt = new DateTime(2024, 8, 9, 3, 58, 15, 971, DateTimeKind.Utc).AddTicks(9876)
                        });
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8cbffeff-5bb3-48da-8517-18384a4d660e"),
                            CreatedAt = new DateTime(2024, 8, 9, 3, 58, 15, 972, DateTimeKind.Utc).AddTicks(15),
                            DateOfBirth = new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alvaroku123@gmail.com",
                            IsActive = true,
                            Name = "Alvaro Kú",
                            PasswordHash = "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7",
                            PhoneNumber = "9919596720",
                            RoleId = new Guid("1a0aa029-963a-49b2-b0fe-7a7055131229"),
                            UpdatedAt = new DateTime(2024, 8, 9, 3, 58, 15, 972, DateTimeKind.Utc).AddTicks(15)
                        });
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Album", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.AlbumUser", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Album", "Album")
                        .WithMany("AlbumUsers")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.User", "User")
                        .WithMany("AlbumUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Moment", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Album", "Album")
                        .WithMany("Moments")
                        .HasForeignKey("AlbumId");

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.MomentResource", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Moment", "Moment")
                        .WithMany("MomentResources")
                        .HasForeignKey("MomentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Resource", "Resource")
                        .WithMany("MomentResources")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Moment");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.User", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Resource", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Album", b =>
                {
                    b.Navigation("AlbumUsers");

                    b.Navigation("Moments");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Moment", b =>
                {
                    b.Navigation("MomentResources");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Resource", b =>
                {
                    b.Navigation("MomentResources");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.User", b =>
                {
                    b.Navigation("AlbumUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
