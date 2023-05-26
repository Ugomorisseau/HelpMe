﻿// <auto-generated />
using HelpMe.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HelpMe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230525142309_Seeder")]
    partial class Seeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HelpMe.Domain.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");
                    
                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.HeroIncident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HeroId")
                        .HasColumnType("integer");

                    b.Property<int>("IncidentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.HasIndex("IncidentId");

                    b.ToTable("HeroIncidents");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsResolved")
                        .HasColumnType("boolean");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<int>("TypeIncidentId")
                        .HasColumnType("integer");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TypeIncidentId");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.TypeIncident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeIncidents");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.TypeIncidentHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HeroId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeIncidentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.HasIndex("TypeIncidentId");

                    b.ToTable("TypeIncidentHeroes");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.HeroIncident", b =>
                {
                    b.HasOne("HelpMe.Domain.Models.Hero", "Hero")
                        .WithMany("HeroIncident")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HelpMe.Domain.Models.Incident", "Incident")
                        .WithMany("HeroIncident")
                        .HasForeignKey("IncidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("Incident");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.Incident", b =>
                {
                    b.HasOne("HelpMe.Domain.Models.TypeIncident", "TypeIncident")
                        .WithMany("Incidents")
                        .HasForeignKey("TypeIncidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeIncident");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.TypeIncidentHero", b =>
                {
                    b.HasOne("HelpMe.Domain.Models.Hero", "Hero")
                        .WithMany("TypeIncidentHero")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HelpMe.Domain.Models.TypeIncident", "TypeIncident")
                        .WithMany("TypeIncidentHero")
                        .HasForeignKey("TypeIncidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("TypeIncident");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.Hero", b =>
                {
                    b.Navigation("HeroIncident");

                    b.Navigation("TypeIncidentHero");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.Incident", b =>
                {
                    b.Navigation("HeroIncident");
                });

            modelBuilder.Entity("HelpMe.Domain.Models.TypeIncident", b =>
                {
                    b.Navigation("Incidents");

                    b.Navigation("TypeIncidentHero");
                });
#pragma warning restore 612, 618
        }
    }
}
