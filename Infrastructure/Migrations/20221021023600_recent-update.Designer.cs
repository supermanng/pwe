﻿// <auto-generated />
using Infrastructure.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProfileDbContext))]
    [Migration("20221021023600_recent-update")]
    partial class recentupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.OtpHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AttemptCount")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateValidated")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InitiationDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmail")
                        .HasMaxLength(5)
                        .HasColumnType("bit");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RetrievalCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IsEmail");

                    b.HasIndex("Reference");

                    b.HasIndex("RetrievalCode");

                    b.ToTable("OtpHistories");
                });

            modelBuilder.Entity("Domain.Entities.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailValidated")
                        .HasMaxLength(5)
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EmailValidationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OtherName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("PhoneValidated")
                        .HasMaxLength(5)
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PhoneValidationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress");

                    b.HasIndex("PhoneNumber");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}