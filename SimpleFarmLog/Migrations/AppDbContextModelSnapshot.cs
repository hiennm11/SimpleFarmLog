﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleFarmLog.EF;

namespace SimpleFarmLog.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SimpleFarmLog.Entities.Boar", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Color")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("HerdId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 12, 11, 8, 41, 19, 915, DateTimeKind.Local).AddTicks(8726));

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("HerdId");

                    b.ToTable("Boars");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.BoarHerd", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 12, 11, 8, 41, 19, 923, DateTimeKind.Local).AddTicks(8672));

                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("BoarHerds");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Fodder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fodders");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Ingredient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.InjectLog", b =>
                {
                    b.Property<string>("HerdId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MedicineId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<DateTime>("InjectDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 12, 11, 8, 41, 19, 936, DateTimeKind.Local).AddTicks(4046));

                    b.HasKey("HerdId", "MedicineId");

                    b.HasIndex("MedicineId");

                    b.ToTable("InjectLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Medicine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.MixLog", b =>
                {
                    b.Property<string>("FodderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IngredientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("IngredientAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<DateTime>("MixDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 12, 11, 8, 41, 19, 938, DateTimeKind.Local).AddTicks(12));

                    b.HasKey("FodderId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("MixLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.PurchaseLog", b =>
                {
                    b.Property<string>("PurchaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IngredientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MedicineId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateTime>("PurchaseDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 12, 11, 8, 41, 19, 941, DateTimeKind.Local).AddTicks(7883));

                    b.HasKey("PurchaseId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("MedicineId");

                    b.ToTable("PurchaseLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.SeedLog", b =>
                {
                    b.Property<string>("HerdId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FodderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<DateTime>("SeedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 12, 11, 8, 41, 19, 939, DateTimeKind.Local).AddTicks(5132));

                    b.HasKey("HerdId", "FodderId");

                    b.HasIndex("FodderId");

                    b.ToTable("SeedLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Boar", b =>
                {
                    b.HasOne("SimpleFarmLog.Entities.BoarHerd", "Herd")
                        .WithMany("Boars")
                        .HasForeignKey("HerdId");

                    b.Navigation("Herd");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.InjectLog", b =>
                {
                    b.HasOne("SimpleFarmLog.Entities.BoarHerd", "BoarHerd")
                        .WithMany("InjectLogs")
                        .HasForeignKey("HerdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleFarmLog.Entities.Medicine", "Medicine")
                        .WithMany("InjectLogs")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoarHerd");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.MixLog", b =>
                {
                    b.HasOne("SimpleFarmLog.Entities.Fodder", "Fodder")
                        .WithMany("MixLogs")
                        .HasForeignKey("FodderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleFarmLog.Entities.Ingredient", "Ingredient")
                        .WithMany("MixLogs")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fodder");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.PurchaseLog", b =>
                {
                    b.HasOne("SimpleFarmLog.Entities.Ingredient", "Ingredient")
                        .WithMany("PurchaseLogs")
                        .HasForeignKey("IngredientId");

                    b.HasOne("SimpleFarmLog.Entities.Medicine", "Medicine")
                        .WithMany("PurchaseLogs")
                        .HasForeignKey("MedicineId");

                    b.Navigation("Ingredient");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.SeedLog", b =>
                {
                    b.HasOne("SimpleFarmLog.Entities.Fodder", "Fodder")
                        .WithMany("SeedLogs")
                        .HasForeignKey("FodderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleFarmLog.Entities.BoarHerd", "BoarHerd")
                        .WithMany("SeedLogs")
                        .HasForeignKey("HerdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoarHerd");

                    b.Navigation("Fodder");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.BoarHerd", b =>
                {
                    b.Navigation("Boars");

                    b.Navigation("InjectLogs");

                    b.Navigation("SeedLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Fodder", b =>
                {
                    b.Navigation("MixLogs");

                    b.Navigation("SeedLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Ingredient", b =>
                {
                    b.Navigation("MixLogs");

                    b.Navigation("PurchaseLogs");
                });

            modelBuilder.Entity("SimpleFarmLog.Entities.Medicine", b =>
                {
                    b.Navigation("InjectLogs");

                    b.Navigation("PurchaseLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
