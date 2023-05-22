﻿// <auto-generated />
using System;
using InspectionTaskApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InspectionTaskApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230519040723_updateCRD4")]
    partial class updateCRD4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InspectionTaskApi.Models.AssignedToPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CopyRequestDtoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CopyRequestDtoId");

                    b.ToTable("AssignedToPersons");
                });

            modelBuilder.Entity("InspectionTaskApi.Models.CopyRequestDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignedToPersonId")
                        .HasColumnType("int");

                    b.Property<int>("CopyInspectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CopyRequests");
                });

            modelBuilder.Entity("InspectionTaskApi.Models.Inspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignedToPersonId")
                        .HasColumnType("int");

                    b.Property<int?>("CopyRequestDtoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToPersonId");

                    b.HasIndex("CopyRequestDtoId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("InspectionTaskApi.Models.AssignedToPerson", b =>
                {
                    b.HasOne("InspectionTaskApi.Models.CopyRequestDto", null)
                        .WithMany("AssignedToPersons")
                        .HasForeignKey("CopyRequestDtoId");
                });

            modelBuilder.Entity("InspectionTaskApi.Models.Inspection", b =>
                {
                    b.HasOne("InspectionTaskApi.Models.AssignedToPerson", "AssignedToPerson")
                        .WithMany()
                        .HasForeignKey("AssignedToPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InspectionTaskApi.Models.CopyRequestDto", null)
                        .WithMany("inspections")
                        .HasForeignKey("CopyRequestDtoId");

                    b.Navigation("AssignedToPerson");
                });

            modelBuilder.Entity("InspectionTaskApi.Models.CopyRequestDto", b =>
                {
                    b.Navigation("AssignedToPersons");

                    b.Navigation("inspections");
                });
#pragma warning restore 612, 618
        }
    }
}