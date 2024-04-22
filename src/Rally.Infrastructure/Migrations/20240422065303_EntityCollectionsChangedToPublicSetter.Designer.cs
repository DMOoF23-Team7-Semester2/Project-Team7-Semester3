﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rally.Infrastructure.Data;

#nullable disable

namespace Rally.Infrastructure.Migrations
{
    [DbContext(typeof(RallyContext))]
    [Migration("20240422065303_EntityCollectionsChangedToPublicSetter")]
    partial class EntityCollectionsChangedToPublicSetter
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rally.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Rules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Rally.Core.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquipmentBaseId")
                        .HasColumnType("int");

                    b.Property<string>("Rotation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XCoordinate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YCoordinate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentBaseId");

                    b.ToTable("Equipment", (string)null);
                });

            modelBuilder.Entity("Rally.Core.Entities.EquipmentBase", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentBases", (string)null);
                });

            modelBuilder.Entity("Rally.Core.Entities.Sign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Rotation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SignBaseId")
                        .HasColumnType("int");

                    b.Property<int>("SignNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<string>("XCoordinate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YCoordinate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SignBaseId");

                    b.HasIndex("TrackId");

                    b.ToTable("Signs", (string)null);
                });

            modelBuilder.Entity("Rally.Core.Entities.SignBase", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipmentBaseId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentBaseId");

                    b.ToTable("SignBases", (string)null);
                });

            modelBuilder.Entity("Rally.Core.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tracks", (string)null);
                });

            modelBuilder.Entity("Rally.Core.Entities.Equipment", b =>
                {
                    b.HasOne("Rally.Core.Entities.EquipmentBase", "EquipmentBase")
                        .WithMany("Equipments")
                        .HasForeignKey("EquipmentBaseId");

                    b.Navigation("EquipmentBase");
                });

            modelBuilder.Entity("Rally.Core.Entities.Sign", b =>
                {
                    b.HasOne("Rally.Core.Entities.SignBase", "SignBase")
                        .WithMany("Signs")
                        .HasForeignKey("SignBaseId");

                    b.HasOne("Rally.Core.Entities.Track", "Track")
                        .WithMany("Signs")
                        .HasForeignKey("TrackId");

                    b.Navigation("SignBase");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Rally.Core.Entities.SignBase", b =>
                {
                    b.HasOne("Rally.Core.Entities.Category", "Category")
                        .WithMany("SignBases")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Rally.Core.Entities.EquipmentBase", "EquipmentBase")
                        .WithMany("SignBases")
                        .HasForeignKey("EquipmentBaseId");

                    b.Navigation("Category");

                    b.Navigation("EquipmentBase");
                });

            modelBuilder.Entity("Rally.Core.Entities.Track", b =>
                {
                    b.HasOne("Rally.Core.Entities.Category", "Category")
                        .WithMany("Tracks")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Rally.Core.Entities.Category", b =>
                {
                    b.Navigation("SignBases");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Rally.Core.Entities.EquipmentBase", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("SignBases");
                });

            modelBuilder.Entity("Rally.Core.Entities.SignBase", b =>
                {
                    b.Navigation("Signs");
                });

            modelBuilder.Entity("Rally.Core.Entities.Track", b =>
                {
                    b.Navigation("Signs");
                });
#pragma warning restore 612, 618
        }
    }
}
