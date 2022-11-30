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
    [Migration("20221128173514_mg2")]
    partial class mg2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.CustomerCard", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Expiry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_6digits")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Issuer")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Last_4digits")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TokenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Expiry");

                    b.HasIndex("First_6digits");

                    b.HasIndex("Issuer");

                    b.HasIndex("Last_4digits");

                    b.HasIndex("ProfileId");

                    b.ToTable("CustomerCard");
                });

            modelBuilder.Entity("Domain.Entities.CustomerPlan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("AccruedInterest")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<double?>("ExpectedAmount")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<double?>("ExpectedInterest")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<double?>("ExpectedPrincipal")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double?>("InterestRate")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<string>("PlanDetailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProfileAccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("StartDate")
                        .HasMaxLength(20)
                        .HasColumnType("datetime2");

                    b.Property<double?>("Tax")
                        .HasColumnType("float");

                    b.Property<int?>("TenorCount")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime?>("Termination")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlanDetailId");

                    b.HasIndex("ProfileAccountId");

                    b.ToTable("CustomerPlans");
                });

            modelBuilder.Entity("Domain.Entities.OtpHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AttemptCount")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("ChangeToken")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Domain.Entities.Plan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChargesGLCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GLCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("ChargesGLCode");

                    b.HasIndex("GLCode");

                    b.HasIndex("ProductType");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Domain.Entities.PlanDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AllowsWithdrawal")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<string>("ChargesGLCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GLCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InterestIsCalculated")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double?>("InterestRate")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLocked")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<int?>("MaxWithdrawal")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<int?>("MinTenor")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PlanId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Tax")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ChargesGLCode");

                    b.HasIndex("GLCode");

                    b.HasIndex("PlanId");

                    b.ToTable("PlanDetails");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChargesGLCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GLCode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("InterestCalculation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double?>("InterestRate")
                        .HasMaxLength(5)
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<bool>("IsStashed")
                        .HasColumnType("bit");

                    b.Property<double?>("MinimumAmount")
                        .HasMaxLength(5)
                        .HasColumnType("float");

                    b.Property<int?>("MinimumTenior")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("WithdrawalLimit")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GLCode");

                    b.HasIndex("Name");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entities.ProductDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountToCredit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AccountToDebit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ActionType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AccountToCredit");

                    b.HasIndex("AccountToDebit");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("Domain.Entities.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bvn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BvnDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BvnVerificationDate")
                        .HasColumnType("datetime2");

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

                    b.Property<bool?>("HasConfirmedBvn")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Domain.Entities.ProfileAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<bool>("IsWallet")
                        .HasMaxLength(20)
                        .HasColumnType("bit");

                    b.Property<string>("PlanDetailId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AccountNumber");

                    b.HasIndex("IsWallet");

                    b.HasIndex("PlanDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProfileId");

                    b.ToTable("ProfileAccounts");
                });

            modelBuilder.Entity("Domain.Entities.TransactionLog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Account_Id")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Amount")
                        .HasMaxLength(100)
                        .HasColumnType("float");

                    b.Property<double?>("App_fee")
                        .HasMaxLength(100)
                        .HasColumnType("float");

                    b.Property<string>("Auth_Model")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Charged_Amount")
                        .HasMaxLength(30)
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Device_Fingerprint")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Flw_Ref")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IP")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRecurrent")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<double?>("Merchant_Fee")
                        .HasColumnType("float");

                    b.Property<string>("Narration")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Payment_Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Processor_Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TransSessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TransStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("TransactionCompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("TransactionHasBeenPosted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TransactionPostingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionRefId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TransactionType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Transaction_Ref")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Transfer_Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("amount_settled")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Account_Id");

                    b.HasIndex("IsRecurrent");

                    b.HasIndex("ProfileId");

                    b.HasIndex("TransSessionId");

                    b.HasIndex("TransactionHasBeenPosted");

                    b.HasIndex("TransactionRefId");

                    b.HasIndex("TransactionType");

                    b.HasIndex("Transaction_Ref");

                    b.ToTable("TransactionLogs");
                });

            modelBuilder.Entity("Domain.Entities.CustomerCard", b =>
                {
                    b.HasOne("Domain.Entities.Profile", "Profile")
                        .WithMany("Cards")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Domain.Entities.CustomerPlan", b =>
                {
                    b.HasOne("Domain.Entities.ProfileAccount", "ProfileAccount")
                        .WithMany("CustomerPlans")
                        .HasForeignKey("ProfileAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfileAccount");
                });

            modelBuilder.Entity("Domain.Entities.PlanDetail", b =>
                {
                    b.HasOne("Domain.Entities.Plan", "Plan")
                        .WithMany("PlanDetails")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Domain.Entities.ProductDetail", b =>
                {
                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany("ProductConfigurations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.ProfileAccount", b =>
                {
                    b.HasOne("Domain.Entities.PlanDetail", "PlanDetail")
                        .WithMany("PlanAccounts")
                        .HasForeignKey("PlanDetailId");

                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Domain.Entities.Profile", "Profile")
                        .WithMany("PlanAccounts")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanDetail");

                    b.Navigation("Product");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Domain.Entities.TransactionLog", b =>
                {
                    b.HasOne("Domain.Entities.Profile", "Profile")
                        .WithMany("TransactionLog")
                        .HasForeignKey("ProfileId");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Domain.Entities.Plan", b =>
                {
                    b.Navigation("PlanDetails");
                });

            modelBuilder.Entity("Domain.Entities.PlanDetail", b =>
                {
                    b.Navigation("PlanAccounts");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductConfigurations");
                });

            modelBuilder.Entity("Domain.Entities.Profile", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("PlanAccounts");

                    b.Navigation("TransactionLog");
                });

            modelBuilder.Entity("Domain.Entities.ProfileAccount", b =>
                {
                    b.Navigation("CustomerPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
