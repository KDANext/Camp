﻿// <auto-generated />
using System;
using DatabaseImplement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseImplement.Migrations
{
    [DbContext(typeof(CampDatabase))]
    [Migration("20200601110005_newFix")]
    partial class newFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseImplement.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("DatabaseImplement.Models.ChildInterests", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ChildId");

                    b.HasIndex("InterestId");

                    b.ToTable("ChildInterests");
                });

            modelBuilder.Entity("DatabaseImplement.Models.Counsellor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId")
                        .IsUnique()
                        .HasFilter("[GroupId] IS NOT NULL");

                    b.ToTable("Counsellors");
                });

            modelBuilder.Entity("DatabaseImplement.Models.CounsellorInterests", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CounsellorId")
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CounsellorId");

                    b.HasIndex("InterestId");

                    b.ToTable("CounsellorInterests");
                });

            modelBuilder.Entity("DatabaseImplement.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeFrom")
                        .HasColumnType("int");

                    b.Property<int>("AgeTo")
                        .HasColumnType("int");

                    b.Property<int>("CounsellorId")
                        .HasColumnType("int");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CounsellorId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("DatabaseImplement.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Profile")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DatabaseImplement.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("interest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("DatabaseImplement.Models.Child", b =>
                {
                    b.HasOne("DatabaseImplement.Models.Group", "group")
                        .WithMany("children")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("DatabaseImplement.Models.ChildInterests", b =>
                {
                    b.HasOne("DatabaseImplement.Models.Child", "children")
                        .WithMany("interests")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseImplement.Models.Interest", "interest")
                        .WithMany("childInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseImplement.Models.Counsellor", b =>
                {
                    b.HasOne("DatabaseImplement.Models.Group", null)
                        .WithOne("counsellor")
                        .HasForeignKey("DatabaseImplement.Models.Counsellor", "GroupId");
                });

            modelBuilder.Entity("DatabaseImplement.Models.CounsellorInterests", b =>
                {
                    b.HasOne("DatabaseImplement.Models.Counsellor", "counsellors")
                        .WithMany("interests")
                        .HasForeignKey("CounsellorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseImplement.Models.Interest", "counsellorInterests")
                        .WithMany("counsellorInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseImplement.Models.Experience", b =>
                {
                    b.HasOne("DatabaseImplement.Models.Counsellor", "counsellor")
                        .WithMany("experience")
                        .HasForeignKey("CounsellorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
