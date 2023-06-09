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
    [Migration("20230519203600_updateCRD5")]
    partial class updateCRD5
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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

                    b.Property<int?>("AssignedToPersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToPersonId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("InspectionTaskApi.Models.Inspection", b =>
                {
                    b.HasOne("InspectionTaskApi.Models.AssignedToPerson", "AssignedToPerson")
                        .WithMany()
                        .HasForeignKey("AssignedToPersonId");

                    b.Navigation("AssignedToPerson");
                });
#pragma warning restore 612, 618
        }
    }
}
