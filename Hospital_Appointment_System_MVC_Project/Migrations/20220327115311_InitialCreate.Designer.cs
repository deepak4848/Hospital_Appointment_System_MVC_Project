﻿// <auto-generated />
using System;
using Hospital_Appointment_System_MVC_Project.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Appointment_System_MVC_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220327115311_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hospital_Appointment_System_MVC_Project.Models.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletedMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Prescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Doctor_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = "10.02.2022",
                            Doctor_Id = 2,
                            Patient_Id = 1,
                            Prescription = "Ağrı kesici ilacı",
                            Reason = "Karın ağrısı",
                            Time = "14:00"
                        },
                        new
                        {
                            Id = 2,
                            Date = "10.02.2022",
                            Doctor_Id = 2,
                            Patient_Id = 2,
                            Prescription = "Mide bulantısı ilacı",
                            Reason = "Mide bulantısı",
                            Time = "14:30"
                        },
                        new
                        {
                            Id = 3,
                            Date = "12.02.2022",
                            Doctor_Id = 3,
                            Patient_Id = 3,
                            Prescription = "Cinsiyeti belirlendi",
                            Reason = "Doğum için bebek kontrolü",
                            Time = "10:00"
                        },
                        new
                        {
                            Id = 4,
                            Date = "13.02.2022",
                            Doctor_Id = 1,
                            Patient_Id = 4,
                            Prescription = "Kilo vermesi için yeni bir diyet oluşturuldu.",
                            Reason = "Fazla kilo",
                            Time = "13:00"
                        },
                        new
                        {
                            Id = 5,
                            Date = "14.02.2022",
                            Doctor_Id = 5,
                            Patient_Id = 5,
                            Prescription = "Kol alçıya alındı",
                            Reason = "Kırık kol",
                            Time = "15:00"
                        });
                });

            modelBuilder.Entity("Hospital_Appointment_System_MVC_Project.Models.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletedMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Galata Mah.Beyoğlu/İstanbul",
                            Age = "41",
                            FirstName = "Bülent",
                            LastName = "GÜNEŞ",
                            Phone = "05417415252",
                            Specialty = "Nutritionist"
                        },
                        new
                        {
                            Id = 2,
                            Address = "CELALİYE  Mah.Büyükçekmece/İstanbul",
                            Age = "33",
                            FirstName = "Barış",
                            LastName = "YİĞİT",
                            Phone = "05366325412",
                            Specialty = "internal Medicine Specialist"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ayazağa Mah.Sarıyer/İstanbul",
                            Age = "51",
                            FirstName = "Okan",
                            LastName = "AYDIN",
                            Phone = "05232143609",
                            Specialty = "Gynecologist"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Atatürk  Mah.Arnavutköy/İstanbul",
                            Age = "43",
                            FirstName = "Levent",
                            LastName = "CAYMAZ",
                            Phone = "05328979878",
                            Specialty = "Plastic Surgery"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Şirinevler Mah.Bahçelievler/İstanbul",
                            Age = "36",
                            FirstName = "Büşra",
                            LastName = "BERK",
                            Phone = "05366478543",
                            Specialty = "Pediatric Surgery"
                        });
                });

            modelBuilder.Entity("Hospital_Appointment_System_MVC_Project.Models.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletedMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity_No")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateMachineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "İnönü Mah.Küçükçekmece/İstanbul",
                            Age = "26",
                            FirstName = "Oğuzhan",
                            Identity_No = "68795435210",
                            LastName = "KÖMCÜ",
                            Phone = "05356548789"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Çukur Mah.Fatih/İstanbul",
                            Age = "35",
                            FirstName = "Ozan",
                            Identity_No = "55523698745",
                            LastName = "SAĞLAM",
                            Phone = "05321463625"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Çobançeşme Mah.Bağcılar/İstanbul",
                            Age = "75",
                            FirstName = "Gamze",
                            Identity_No = "25478965412",
                            LastName = "KURT",
                            Phone = "05312145326"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Kartaltepe  Mah.Bakırköy/İstanbul",
                            Age = "22",
                            FirstName = "Elif",
                            Identity_No = "21032547801",
                            LastName = "DUMAN",
                            Phone = "05326898587"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Cumhuriyet Mah.Bahçelievler/İstanbul",
                            Age = "10",
                            FirstName = "Mertcan",
                            Identity_No = "21304156987",
                            LastName = "TUNA",
                            Phone = "05365532284"
                        });
                });

            modelBuilder.Entity("Hospital_Appointment_System_MVC_Project.Models.Entities.Appointment", b =>
                {
                    b.HasOne("Hospital_Appointment_System_MVC_Project.Models.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital_Appointment_System_MVC_Project.Models.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital_Appointment_System_MVC_Project.Models.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Hospital_Appointment_System_MVC_Project.Models.Entities.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
