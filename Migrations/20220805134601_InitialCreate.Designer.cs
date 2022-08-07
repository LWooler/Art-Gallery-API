﻿// <auto-generated />
using Art_Gallery_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Art_Gallery_API.Migrations
{
    [DbContext(typeof(ArtworkContext))]
    [Migration("20220805134601_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Art_Gallery_API.Models.Artwork", b =>
                {
                    b.Property<int>("ArtworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtworkId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtworkId");

                    b.ToTable("Artworks");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.Medium", b =>
                {
                    b.Property<int>("MediumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediumId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediumId");

                    b.ToTable("Mediums");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.MediumMapper", b =>
                {
                    b.Property<int>("MediumMapperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediumMapperId"), 1L, 1);

                    b.Property<int>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<int>("MediumId")
                        .HasColumnType("int");

                    b.HasKey("MediumMapperId");

                    b.HasIndex("ArtworkId");

                    b.HasIndex("MediumId");

                    b.ToTable("MediumMappers");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.SubjectMapper", b =>
                {
                    b.Property<int>("SubjectMapperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectMapperId"), 1L, 1);

                    b.Property<int>("ArtworkId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("SubjectMapperId");

                    b.HasIndex("ArtworkId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectMappers");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.MediumMapper", b =>
                {
                    b.HasOne("Art_Gallery_API.Models.Artwork", "Artwork")
                        .WithMany("MediumMappers")
                        .HasForeignKey("ArtworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Art_Gallery_API.Models.Medium", "Medium")
                        .WithMany("MediumMappers")
                        .HasForeignKey("MediumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artwork");

                    b.Navigation("Medium");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.SubjectMapper", b =>
                {
                    b.HasOne("Art_Gallery_API.Models.Artwork", "Artwork")
                        .WithMany("SubjectMappers")
                        .HasForeignKey("ArtworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Art_Gallery_API.Models.Subject", "Subject")
                        .WithMany("SubjectMappers")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artwork");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.Artwork", b =>
                {
                    b.Navigation("MediumMappers");

                    b.Navigation("SubjectMappers");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.Medium", b =>
                {
                    b.Navigation("MediumMappers");
                });

            modelBuilder.Entity("Art_Gallery_API.Models.Subject", b =>
                {
                    b.Navigation("SubjectMappers");
                });
#pragma warning restore 612, 618
        }
    }
}
