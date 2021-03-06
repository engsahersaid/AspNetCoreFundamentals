﻿// <auto-generated />
using System;
using AspNetCore.Fundamentals.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCore.Fundamentals.Store.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCore.Fundamentals.Domain.Model.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("IdNo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Phone");

                    b.Property<double>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("IdNo")
                        .IsUnique()
                        .HasName("IX_Employee_UniqueIdNo");

                    b.ToTable("Employees","HR");
                });

            modelBuilder.Entity("AspNetCore.Fundamentals.Domain.Model.Employee", b =>
                {
                    b.OwnsOne("AspNetCore.Fundamentals.Domain.Model.Address", "Address", b1 =>
                        {
                            b1.Property<Guid?>("EmployeeId");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(100);

                            b1.Property<string>("Line1")
                                .IsRequired()
                                .HasMaxLength(200);

                            b1.Property<string>("Line2")
                                .HasMaxLength(200);

                            b1.ToTable("Employees","HR");

                            b1.HasOne("AspNetCore.Fundamentals.Domain.Model.Employee")
                                .WithOne("Address")
                                .HasForeignKey("AspNetCore.Fundamentals.Domain.Model.Address", "EmployeeId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
