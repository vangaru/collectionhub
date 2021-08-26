﻿// <auto-generated />
using System;
using CollectionHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CollectionHub.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210816082834_OptionalFieldsFixes4")]
    partial class OptionalFieldsFixes4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("CollectionHub.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstOptionalBoolFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstOptionalDateTimeFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstOptionalNumberFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstOptionalStringFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstOptionalTextFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageStorageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondOptionalBoolFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondOptionalDateTimeFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondOptionalNumberFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondOptionalStringFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondOptionalTextFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ThirdOptionalBoolFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ThirdOptionalDateTimeFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ThirdOptionalNumberFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ThirdOptionalStringFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("ThirdOptionalTextFieldName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("CollectionHub.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CollectionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstOptionalBoolFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstOptionalDateTimeFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstOptionalNumberFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstOptionalStringFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstOptionalTextFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int?>("SecondOptionalBoolFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondOptionalDateTimeFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondOptionalNumberFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondOptionalStringFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondOptionalTextFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdOptionalBoolFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdOptionalDateTimeFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdOptionalNumberFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdOptionalStringFieldId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdOptionalTextFieldId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.HasIndex("FirstOptionalBoolFieldId");

                    b.HasIndex("FirstOptionalDateTimeFieldId");

                    b.HasIndex("FirstOptionalNumberFieldId");

                    b.HasIndex("FirstOptionalStringFieldId");

                    b.HasIndex("FirstOptionalTextFieldId");

                    b.HasIndex("SecondOptionalBoolFieldId");

                    b.HasIndex("SecondOptionalDateTimeFieldId");

                    b.HasIndex("SecondOptionalNumberFieldId");

                    b.HasIndex("SecondOptionalStringFieldId");

                    b.HasIndex("SecondOptionalTextFieldId");

                    b.HasIndex("ThirdOptionalBoolFieldId");

                    b.HasIndex("ThirdOptionalDateTimeFieldId");

                    b.HasIndex("ThirdOptionalNumberFieldId");

                    b.HasIndex("ThirdOptionalStringFieldId");

                    b.HasIndex("ThirdOptionalTextFieldId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CollectionHub.Models.OptionalBoolField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("OptionalBoolFields");
                });

            modelBuilder.Entity("CollectionHub.Models.OptionalDateTimeField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OptionalDateTimeFields");
                });

            modelBuilder.Entity("CollectionHub.Models.OptionalNumberField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("OptionalNumberFields");
                });

            modelBuilder.Entity("CollectionHub.Models.OptionalStringField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OptionalStringFields");
                });

            modelBuilder.Entity("CollectionHub.Models.OptionalTextField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OptionalTextFields");
                });

            modelBuilder.Entity("CollectionHub.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CollectionHub.Data.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("CollectionHub.Models.Collection", b =>
                {
                    b.HasOne("CollectionHub.Data.ApplicationUser", null)
                        .WithMany("Collections")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("CollectionHub.Models.Item", b =>
                {
                    b.HasOne("CollectionHub.Models.Collection", null)
                        .WithMany("Items")
                        .HasForeignKey("CollectionId");

                    b.HasOne("CollectionHub.Models.OptionalBoolField", "FirstOptionalBoolField")
                        .WithMany()
                        .HasForeignKey("FirstOptionalBoolFieldId");

                    b.HasOne("CollectionHub.Models.OptionalDateTimeField", "FirstOptionalDateTimeField")
                        .WithMany()
                        .HasForeignKey("FirstOptionalDateTimeFieldId");

                    b.HasOne("CollectionHub.Models.OptionalNumberField", "FirstOptionalNumberField")
                        .WithMany()
                        .HasForeignKey("FirstOptionalNumberFieldId");

                    b.HasOne("CollectionHub.Models.OptionalStringField", "FirstOptionalStringField")
                        .WithMany()
                        .HasForeignKey("FirstOptionalStringFieldId");

                    b.HasOne("CollectionHub.Models.OptionalTextField", "FirstOptionalTextField")
                        .WithMany()
                        .HasForeignKey("FirstOptionalTextFieldId");

                    b.HasOne("CollectionHub.Models.OptionalBoolField", "SecondOptionalBoolField")
                        .WithMany()
                        .HasForeignKey("SecondOptionalBoolFieldId");

                    b.HasOne("CollectionHub.Models.OptionalDateTimeField", "SecondOptionalDateTimeField")
                        .WithMany()
                        .HasForeignKey("SecondOptionalDateTimeFieldId");

                    b.HasOne("CollectionHub.Models.OptionalNumberField", "SecondOptionalNumberField")
                        .WithMany()
                        .HasForeignKey("SecondOptionalNumberFieldId");

                    b.HasOne("CollectionHub.Models.OptionalStringField", "SecondOptionalStringField")
                        .WithMany()
                        .HasForeignKey("SecondOptionalStringFieldId");

                    b.HasOne("CollectionHub.Models.OptionalTextField", "SecondOptionalTextField")
                        .WithMany()
                        .HasForeignKey("SecondOptionalTextFieldId");

                    b.HasOne("CollectionHub.Models.OptionalBoolField", "ThirdOptionalBoolField")
                        .WithMany()
                        .HasForeignKey("ThirdOptionalBoolFieldId");

                    b.HasOne("CollectionHub.Models.OptionalDateTimeField", "ThirdOptionalDateTimeField")
                        .WithMany()
                        .HasForeignKey("ThirdOptionalDateTimeFieldId");

                    b.HasOne("CollectionHub.Models.OptionalNumberField", "ThirdOptionalNumberField")
                        .WithMany()
                        .HasForeignKey("ThirdOptionalNumberFieldId");

                    b.HasOne("CollectionHub.Models.OptionalStringField", "ThirdOptionalStringField")
                        .WithMany()
                        .HasForeignKey("ThirdOptionalStringFieldId");

                    b.HasOne("CollectionHub.Models.OptionalTextField", "ThirdOptionalTextField")
                        .WithMany()
                        .HasForeignKey("ThirdOptionalTextFieldId");

                    b.Navigation("FirstOptionalBoolField");

                    b.Navigation("FirstOptionalDateTimeField");

                    b.Navigation("FirstOptionalNumberField");

                    b.Navigation("FirstOptionalStringField");

                    b.Navigation("FirstOptionalTextField");

                    b.Navigation("SecondOptionalBoolField");

                    b.Navigation("SecondOptionalDateTimeField");

                    b.Navigation("SecondOptionalNumberField");

                    b.Navigation("SecondOptionalStringField");

                    b.Navigation("SecondOptionalTextField");

                    b.Navigation("ThirdOptionalBoolField");

                    b.Navigation("ThirdOptionalDateTimeField");

                    b.Navigation("ThirdOptionalNumberField");

                    b.Navigation("ThirdOptionalStringField");

                    b.Navigation("ThirdOptionalTextField");
                });

            modelBuilder.Entity("CollectionHub.Models.Tag", b =>
                {
                    b.HasOne("CollectionHub.Models.Item", null)
                        .WithMany("Tags")
                        .HasForeignKey("ItemId");
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

            modelBuilder.Entity("CollectionHub.Models.Collection", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("CollectionHub.Models.Item", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("CollectionHub.Data.ApplicationUser", b =>
                {
                    b.Navigation("Collections");
                });
#pragma warning restore 612, 618
        }
    }
}