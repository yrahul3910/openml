﻿// <auto-generated />
using System;
using MLServer.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MLServer.Infra.Data.Migrations
{
    [DbContext(typeof(MLServerContext))]
    partial class MLServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MLServer.Domain.Models.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreationDate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<int>("EpochsRun")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Jobs", (string)null);
                });

            modelBuilder.Entity("MLServer.Domain.Models.UserAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreationDate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
