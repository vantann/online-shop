﻿// <auto-generated />
using Domain.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.ActionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Browser")
                        .HasMaxLength(300);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Data");

                    b.Property<string>("Host")
                        .HasMaxLength(100);

                    b.Property<string>("IpAddress")
                        .HasMaxLength(20);

                    b.Property<string>("LogLevel")
                        .HasMaxLength(50);

                    b.Property<string>("Message")
                        .HasMaxLength(2000);

                    b.Property<string>("Path")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("ActionLog");
                });

            modelBuilder.Entity("Domain.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.Models.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Domain.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("Active");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FamilyName");

                    b.Property<string>("GivenName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleName");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<int?>("OfficeNumber");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Picture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AspNetUser");
                });

            modelBuilder.Entity("Domain.Models.GroupUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(20);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("GroupUser");
                });

            modelBuilder.Entity("Domain.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Culture")
                        .HasMaxLength(10);

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(256);

                    b.Property<string>("Icon")
                        .HasMaxLength(128);

                    b.Property<bool?>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("Ordering");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Domain.Models.LanguageText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption")
                        .HasMaxLength(500);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<int?>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LanguageId");

                    b.Property<int?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("LanguageText");
                });

            modelBuilder.Entity("Domain.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupUserId");

                    b.Property<string>("RoleId")
                        .HasMaxLength(50);

                    b.Property<string>("UserId")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("GroupUserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("Domain.Models.UserInGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupUserId");

                    b.Property<string>("RoleId")
                        .HasMaxLength(250);

                    b.Property<string>("UserId")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("GroupUserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInGroup");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Models.LanguageText", b =>
                {
                    b.HasOne("Domain.Models.Language", "Language")
                        .WithMany("LanguageTexts")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.Permission", b =>
                {
                    b.HasOne("Domain.Models.GroupUser", "GroupUser")
                        .WithMany("Permissions")
                        .HasForeignKey("GroupUserId");

                    b.HasOne("Domain.Models.AspNetRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Domain.Models.AspNetUser", "User")
                        .WithMany("BEPermissions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Domain.Models.UserInGroup", b =>
                {
                    b.HasOne("Domain.Models.GroupUser", "GroupUser")
                        .WithMany("UserInGroups")
                        .HasForeignKey("GroupUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.AspNetRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Domain.Models.AspNetUser", "User")
                        .WithMany("BEUserInGroups")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Domain.Models.AspNetRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Domain.Models.AspNetRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
