﻿// <auto-generated />
using System;
using Core_neptune.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core_neptune.Migrations
{
    [DbContext(typeof(CoreContext))]
    [Migration("20220519141635_InitialCreate3")]
    partial class InitialCreate3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("Core_neptune.Models.Hobbie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonneId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.ToTable("Hobbie");
                });

            modelBuilder.Entity("Core_neptune.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Personne");
                });

            modelBuilder.Entity("Core_neptune.Models.Hobbie", b =>
                {
                    b.HasOne("Core_neptune.Models.Personne", null)
                        .WithMany("Hobbies")
                        .HasForeignKey("PersonneId");
                });

            modelBuilder.Entity("Core_neptune.Models.Personne", b =>
                {
                    b.Navigation("Hobbies");
                });
#pragma warning restore 612, 618
        }
    }
}
