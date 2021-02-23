﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Training_API.Data;

namespace Training_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210221180956_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Training_API.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matheus",
                            Surname = "Marchi Moro"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cristina",
                            Surname = "da Silva"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Eduardo",
                            Surname = "Pereira"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bárbara",
                            Surname = "de Souza"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Thomas",
                            Surname = "Cruz"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Norman",
                            Surname = "Reedus"
                        });
                });

            modelBuilder.Entity("Training_API.Models.RestRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RestRoom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 25,
                            Name = "Espaço 1"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 30,
                            Name = "Espaço 2"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 35,
                            Name = "Espaço 3"
                        });
                });

            modelBuilder.Entity("Training_API.Models.RestRoomPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("RestRoomId")
                        .HasColumnType("int");

                    b.Property<int>("RestTimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("RestRoomId");

                    b.HasIndex("RestTimeId");

                    b.ToTable("RestRoomPerson");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PersonId = 1,
                            RestRoomId = 1,
                            RestTimeId = 1
                        },
                        new
                        {
                            Id = 2,
                            PersonId = 2,
                            RestRoomId = 1,
                            RestTimeId = 1
                        },
                        new
                        {
                            Id = 3,
                            PersonId = 3,
                            RestRoomId = 2,
                            RestTimeId = 1
                        },
                        new
                        {
                            Id = 4,
                            PersonId = 4,
                            RestRoomId = 2,
                            RestTimeId = 1
                        },
                        new
                        {
                            Id = 5,
                            PersonId = 1,
                            RestRoomId = 2,
                            RestTimeId = 2
                        },
                        new
                        {
                            Id = 6,
                            PersonId = 2,
                            RestRoomId = 2,
                            RestTimeId = 2
                        },
                        new
                        {
                            Id = 7,
                            PersonId = 3,
                            RestRoomId = 1,
                            RestTimeId = 2
                        },
                        new
                        {
                            Id = 8,
                            PersonId = 4,
                            RestRoomId = 1,
                            RestTimeId = 2
                        });
                });

            modelBuilder.Entity("Training_API.Models.RestTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartingDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RestTime");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndingDateTime = new DateTime(2021, 4, 18, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            StartingDateTime = new DateTime(2021, 4, 18, 15, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EndingDateTime = new DateTime(2021, 4, 19, 17, 15, 0, 0, DateTimeKind.Unspecified),
                            StartingDateTime = new DateTime(2021, 4, 19, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Training_API.Models.StageTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartingDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("StageTime");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndingDateTime = new DateTime(2021, 4, 18, 18, 15, 0, 0, DateTimeKind.Unspecified),
                            StartingDateTime = new DateTime(2021, 4, 18, 14, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EndingDateTime = new DateTime(2021, 4, 19, 18, 15, 0, 0, DateTimeKind.Unspecified),
                            StartingDateTime = new DateTime(2021, 4, 19, 14, 15, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Training_API.Models.TrainingRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingRoom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 10,
                            Name = "Sala 1"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 15,
                            Name = "Sala 2"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 20,
                            Name = "Sala 3"
                        });
                });

            modelBuilder.Entity("Training_API.Models.TrainingRoomPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("StageTimeId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("StageTimeId");

                    b.HasIndex("TrainingRoomId");

                    b.ToTable("TrainingRoomPerson");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PersonId = 1,
                            StageTimeId = 1,
                            TrainingRoomId = 1
                        },
                        new
                        {
                            Id = 2,
                            PersonId = 2,
                            StageTimeId = 1,
                            TrainingRoomId = 1
                        },
                        new
                        {
                            Id = 3,
                            PersonId = 3,
                            StageTimeId = 1,
                            TrainingRoomId = 2
                        },
                        new
                        {
                            Id = 4,
                            PersonId = 4,
                            StageTimeId = 1,
                            TrainingRoomId = 2
                        },
                        new
                        {
                            Id = 5,
                            PersonId = 1,
                            StageTimeId = 2,
                            TrainingRoomId = 1
                        },
                        new
                        {
                            Id = 6,
                            PersonId = 2,
                            StageTimeId = 2,
                            TrainingRoomId = 2
                        },
                        new
                        {
                            Id = 7,
                            PersonId = 3,
                            StageTimeId = 2,
                            TrainingRoomId = 2
                        },
                        new
                        {
                            Id = 8,
                            PersonId = 4,
                            StageTimeId = 2,
                            TrainingRoomId = 1
                        });
                });

            modelBuilder.Entity("Training_API.Models.RestRoomPerson", b =>
                {
                    b.HasOne("Training_API.Models.Person", "Person")
                        .WithMany("RestRoomPeople")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Training_API.Models.RestRoom", "RestRoom")
                        .WithMany("RestRoomPeople")
                        .HasForeignKey("RestRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Training_API.Models.RestTime", "RestTime")
                        .WithMany()
                        .HasForeignKey("RestTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("RestRoom");

                    b.Navigation("RestTime");
                });

            modelBuilder.Entity("Training_API.Models.TrainingRoomPerson", b =>
                {
                    b.HasOne("Training_API.Models.Person", "Person")
                        .WithMany("TrainingRoomPeople")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Training_API.Models.StageTime", "StageTime")
                        .WithMany()
                        .HasForeignKey("StageTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Training_API.Models.TrainingRoom", "TrainingRoom")
                        .WithMany("TrainingRoomPeople")
                        .HasForeignKey("TrainingRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("StageTime");

                    b.Navigation("TrainingRoom");
                });

            modelBuilder.Entity("Training_API.Models.Person", b =>
                {
                    b.Navigation("RestRoomPeople");

                    b.Navigation("TrainingRoomPeople");
                });

            modelBuilder.Entity("Training_API.Models.RestRoom", b =>
                {
                    b.Navigation("RestRoomPeople");
                });

            modelBuilder.Entity("Training_API.Models.TrainingRoom", b =>
                {
                    b.Navigation("TrainingRoomPeople");
                });
#pragma warning restore 612, 618
        }
    }
}