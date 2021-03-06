// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileStore.Data;

#nullable disable

namespace MobileStore.Migrations
{
    [DbContext(typeof(MobileStoreContext))]
    [Migration("20220622130355_BuyCart")]
    partial class BuyCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BuyCartPhone", b =>
                {
                    b.Property<int>("BuyCartsPhoneID")
                        .HasColumnType("int");

                    b.Property<int>("PhonesPhoneID")
                        .HasColumnType("int");

                    b.HasKey("BuyCartsPhoneID", "PhonesPhoneID");

                    b.HasIndex("PhonesPhoneID");

                    b.ToTable("BuyCartPhone");
                });

            modelBuilder.Entity("MobileStore.Models.AboutClient", b =>
                {
                    b.Property<int>("AboutClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutClientID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AboutClientID");

                    b.HasIndex("ClientID");

                    b.ToTable("AboutClient", (string)null);
                });

            modelBuilder.Entity("MobileStore.Models.AboutPhone", b =>
                {
                    b.Property<int>("AboutPhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutPhoneID"), 1L, 1);

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Camera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.HasKey("AboutPhoneID");

                    b.HasIndex("PhoneID")
                        .IsUnique();

                    b.ToTable("AboutPhone", (string)null);
                });

            modelBuilder.Entity("MobileStore.Models.BuyCart", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneID"), 1L, 1);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Firm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneID");

                    b.HasIndex("ClientID")
                        .IsUnique();

                    b.ToTable("BuyCart", (string)null);
                });

            modelBuilder.Entity("MobileStore.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("ClientID");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("MobileStore.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("MobileStore.Models.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneID"), 1L, 1);

                    b.Property<int>("AbouPhoneID")
                        .HasColumnType("int");

                    b.Property<string>("Firm")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Model");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Price");

                    b.HasKey("PhoneID");

                    b.ToTable("Phone", (string)null);
                });

            modelBuilder.Entity("BuyCartPhone", b =>
                {
                    b.HasOne("MobileStore.Models.BuyCart", null)
                        .WithMany()
                        .HasForeignKey("BuyCartsPhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileStore.Models.Phone", null)
                        .WithMany()
                        .HasForeignKey("PhonesPhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobileStore.Models.AboutClient", b =>
                {
                    b.HasOne("MobileStore.Models.Client", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("MobileStore.Models.AboutPhone", b =>
                {
                    b.HasOne("MobileStore.Models.Phone", "Phones")
                        .WithOne("AboutPhone")
                        .HasForeignKey("MobileStore.Models.AboutPhone", "PhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phones");
                });

            modelBuilder.Entity("MobileStore.Models.BuyCart", b =>
                {
                    b.HasOne("MobileStore.Models.Client", "Client")
                        .WithOne("BuyCarts")
                        .HasForeignKey("MobileStore.Models.BuyCart", "ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("MobileStore.Models.Client", b =>
                {
                    b.Navigation("BuyCarts")
                        .IsRequired();
                });

            modelBuilder.Entity("MobileStore.Models.Phone", b =>
                {
                    b.Navigation("AboutPhone")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
