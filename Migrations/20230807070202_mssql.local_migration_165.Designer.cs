﻿// <auto-generated />
using System;
using BBMApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BBMApi.Migrations
{
    [DbContext(typeof(BBMApiContext))]
    [Migration("20230807070202_mssql.local_migration_165")]
    partial class mssqllocal_migration_165
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BBMApi.Model.Church", b =>
                {
                    b.Property<int>("churchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("churchId"));

                    b.Property<string>("branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("churchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pastorId")
                        .HasColumnType("int");

                    b.Property<string>("province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("churchId");

                    b.ToTable("Church");
                });

            modelBuilder.Entity("BBMApi.Model.Leader", b =>
                {
                    b.Property<int>("leaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("leaderId"));

                    b.Property<string>("ministry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.HasKey("leaderId");

                    b.ToTable("Leader");
                });

            modelBuilder.Entity("BBMApi.Model.Person", b =>
                {
                    b.Property<int>("personId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("personId"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("churchId")
                        .HasColumnType("int");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("maritalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("personId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("BBMApi.Model.Stats", b =>
                {
                    b.Property<int>("statsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("statsId"));

                    b.Property<int>("adult")
                        .HasColumnType("int");

                    b.Property<int>("car")
                        .HasColumnType("int");

                    b.Property<int>("churchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("fk")
                        .HasColumnType("int");

                    b.Property<float>("offering")
                        .HasColumnType("real");

                    b.Property<int>("saved")
                        .HasColumnType("int");

                    b.Property<int>("visitors")
                        .HasColumnType("int");

                    b.HasKey("statsId");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("BBMApi.Model.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
