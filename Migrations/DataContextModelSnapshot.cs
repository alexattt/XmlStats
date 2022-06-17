﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VismaTechnicalTask.Data;

namespace VismaTechnicalTask.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VismaTechnicalTask.Models.AppRec", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("GenDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MIGversion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MsgType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("AppRecs");
                });

            modelBuilder.Entity("VismaTechnicalTask.Models.ErrorReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppRecID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Err_DN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Err_OT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Err_S")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Err_V")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppRecID");

                    b.ToTable("ErrorReasons");
                });

            modelBuilder.Entity("VismaTechnicalTask.Models.HelperInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastAddedXmlDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HelperInfo");
                });

            modelBuilder.Entity("VismaTechnicalTask.Models.Receiver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdrType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCPersonId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCPersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCPersonTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedSpeciality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAdr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeleAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Receivers");
                });

            modelBuilder.Entity("VismaTechnicalTask.Models.Sender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdrType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCPersonId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCPersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HCPersonTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedSpeciality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAdr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeleAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Senders");
                });

            modelBuilder.Entity("VismaTechnicalTask.Models.AppRec", b =>
                {
                    b.HasOne("VismaTechnicalTask.Models.Receiver", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VismaTechnicalTask.Models.Sender", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("VismaTechnicalTask.Models.ErrorReason", b =>
                {
                    b.HasOne("VismaTechnicalTask.Models.AppRec", "AppRec")
                        .WithMany()
                        .HasForeignKey("AppRecID");

                    b.Navigation("AppRec");
                });
#pragma warning restore 612, 618
        }
    }
}
