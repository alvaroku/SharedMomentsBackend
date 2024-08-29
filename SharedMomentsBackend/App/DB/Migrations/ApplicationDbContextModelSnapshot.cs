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

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("OwnerId");

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

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.MomentUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("MomentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MomentId");

                    b.HasIndex("UserId");

                    b.ToTable("MomentUsers");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extension")
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

                    b.Property<decimal>("Size")
                        .HasColumnType("decimal(20,0)");

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
                            Id = new Guid("2c7046ed-154d-4465-b5ba-a2bb1b9f7ec5"),
                            CreatedAt = new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(557),
                            IsActive = true,
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(561)
                        },
                        new
                        {
                            Id = new Guid("0cd538a8-7b59-4997-a0f7-1209a5419f29"),
                            CreatedAt = new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(564),
                            IsActive = true,
                            Name = "User",
                            UpdatedAt = new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(564)
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
                            Id = new Guid("3b52e1b1-af54-4ba7-b570-a541e0190331"),
                            CreatedAt = new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(698),
                            DateOfBirth = new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alvaroku123@gmail.com",
                            IsActive = true,
                            Name = "Alvaro Kú",
                            PasswordHash = "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7",
                            PhoneNumber = "9919596720",
                            RoleId = new Guid("2c7046ed-154d-4465-b5ba-a2bb1b9f7ec5"),
                            UpdatedAt = new DateTime(2024, 8, 13, 19, 18, 29, 661, DateTimeKind.Utc).AddTicks(699)
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

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Owner");
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

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.MomentUser", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Moment", "Moment")
                        .WithMany("MomentUsers")
                        .HasForeignKey("MomentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.User", "User")
                        .WithMany("MomentUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Moment");

                    b.Navigation("User");
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

                    b.Navigation("MomentUsers");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Resource", b =>
                {
                    b.Navigation("MomentResources");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.User", b =>
                {
                    b.Navigation("AlbumUsers");

                    b.Navigation("MomentUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
