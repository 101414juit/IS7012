﻿// <auto-generated />
using System;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCrud.Migrations
{
    [DbContext(typeof(CoreCrudContext))]
    partial class CoreCrudContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCrud.Models.HockeyTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget");

                    b.Property<bool>("IsTeamActive");

                    b.Property<int>("NationalityID");

                    b.Property<DateTime>("TeamCreationDate");

                    b.Property<DateTime?>("TeamEndDate");

                    b.Property<string>("TeamName");

                    b.HasKey("ID");

                    b.HasIndex("NationalityID");

                    b.ToTable("HockeyTeam");
                });

            modelBuilder.Entity("CoreCrud.Models.Nationality", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("ID");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("CoreCrud.Models.HockeyTeam", b =>
                {
                    b.HasOne("CoreCrud.Models.Nationality")
                        .WithMany("HockeyTeams")
                        .HasForeignKey("NationalityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
