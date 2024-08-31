﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedMomentsBackend.App.DB;

#nullable disable

namespace SharedMomentsBackend.App.DB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240831203345_security")]
    partial class security
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
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

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Action", b =>
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

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Module", b =>
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

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.ModuleAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActionId");

                    b.HasIndex("ModuleId");

                    b.ToTable("ModuleActions");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModuleActionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ModuleActionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Role", b =>
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
                            Id = new Guid("ee363e14-80a8-40ae-b662-b24b8e22472a"),
                            CreatedAt = new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1546),
                            IsActive = true,
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1547)
                        },
                        new
                        {
                            Id = new Guid("c176c03f-b269-459c-9d48-5c8a27dc9b2b"),
                            CreatedAt = new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1549),
                            IsActive = true,
                            Name = "User",
                            UpdatedAt = new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1549)
                        });
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.RolePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
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
                            Id = new Guid("af6e602e-eed1-4c05-a1ee-31280ba1fb49"),
                            CreatedAt = new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1687),
                            DateOfBirth = new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alvaroku123@gmail.com",
                            IsActive = true,
                            Name = "Alvaro Kú",
                            PasswordHash = "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7",
                            PhoneNumber = "9919596720",
                            RoleId = new Guid("ee363e14-80a8-40ae-b662-b24b8e22472a"),
                            UpdatedAt = new DateTime(2024, 8, 31, 20, 33, 45, 54, DateTimeKind.Utc).AddTicks(1687)
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

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.ModuleAction", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Security.Action", "Action")
                        .WithMany("ModuleActions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Security.Module", "Module")
                        .WithMany("ModuleActions")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Permission", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Security.ModuleAction", "ModuleAction")
                        .WithMany()
                        .HasForeignKey("ModuleActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleAction");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.RolePermission", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Security.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Security.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.User", b =>
                {
                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Resource", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("SharedMomentsBackend.App.Models.Entities.Security.Role", "Role")
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

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Action", b =>
                {
                    b.Navigation("ModuleActions");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Module", b =>
                {
                    b.Navigation("ModuleActions");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("SharedMomentsBackend.App.Models.Entities.Security.Role", b =>
                {
                    b.Navigation("RolePermissions");
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
