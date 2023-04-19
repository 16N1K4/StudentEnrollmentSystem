﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEnrollmentSystem.Data;

#nullable disable

namespace StudentEnrollmentSystem.Migrations
{
    [DbContext(typeof(SESContext))]
    [Migration("20230419182217_student_number_config")]
    partial class student_number_config
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.HasSequence<int>("StudentNo")
                .StartsAt(999L);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "01c4af82-e7e4-441f-a04e-b976cf24d2f5",
                            ConcurrencyStamp = "871e0e8c-bf40-4255-94ae-664e69ebed84",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "e6f7f994-1a74-4e45-acce-ff2a74cc3a9a",
                            ConcurrencyStamp = "f62cde67-a4d9-4ede-808e-024afb51e3ff",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR StudentNo");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DeptID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            DeptID = -1,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Faculty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DeptID");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Section", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("SectionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            SectionCode = "MAB"
                        },
                        new
                        {
                            ID = 2,
                            SectionCode = "MBC"
                        },
                        new
                        {
                            ID = 3,
                            SectionCode = "MCD"
                        },
                        new
                        {
                            ID = 4,
                            SectionCode = "MDE"
                        },
                        new
                        {
                            ID = 5,
                            SectionCode = "MEF"
                        },
                        new
                        {
                            ID = 6,
                            SectionCode = "MFG"
                        },
                        new
                        {
                            ID = 7,
                            SectionCode = "MGH"
                        },
                        new
                        {
                            ID = 8,
                            SectionCode = "MHI"
                        },
                        new
                        {
                            ID = 9,
                            SectionCode = "MIJ"
                        },
                        new
                        {
                            ID = 10,
                            SectionCode = "TAB"
                        },
                        new
                        {
                            ID = 11,
                            SectionCode = "TBC"
                        },
                        new
                        {
                            ID = 12,
                            SectionCode = "TCD"
                        },
                        new
                        {
                            ID = 13,
                            SectionCode = "TDE"
                        },
                        new
                        {
                            ID = 14,
                            SectionCode = "TEF"
                        },
                        new
                        {
                            ID = 15,
                            SectionCode = "TFG"
                        },
                        new
                        {
                            ID = 16,
                            SectionCode = "TGH"
                        },
                        new
                        {
                            ID = 17,
                            SectionCode = "THI"
                        },
                        new
                        {
                            ID = 18,
                            SectionCode = "TIJ"
                        },
                        new
                        {
                            ID = 19,
                            SectionCode = "WAB"
                        },
                        new
                        {
                            ID = 20,
                            SectionCode = "WBC"
                        },
                        new
                        {
                            ID = 21,
                            SectionCode = "WCD"
                        },
                        new
                        {
                            ID = 22,
                            SectionCode = "WDE"
                        },
                        new
                        {
                            ID = 23,
                            SectionCode = "WEF"
                        },
                        new
                        {
                            ID = 24,
                            SectionCode = "WFG"
                        },
                        new
                        {
                            ID = 25,
                            SectionCode = "WGH"
                        },
                        new
                        {
                            ID = 26,
                            SectionCode = "WHI"
                        },
                        new
                        {
                            ID = 27,
                            SectionCode = "WIJ"
                        },
                        new
                        {
                            ID = 28,
                            SectionCode = "HAB"
                        },
                        new
                        {
                            ID = 29,
                            SectionCode = "HBC"
                        },
                        new
                        {
                            ID = 30,
                            SectionCode = "HCD"
                        },
                        new
                        {
                            ID = 31,
                            SectionCode = "HDE"
                        },
                        new
                        {
                            ID = 32,
                            SectionCode = "HEF"
                        },
                        new
                        {
                            ID = 33,
                            SectionCode = "HFG"
                        },
                        new
                        {
                            ID = 34,
                            SectionCode = "HGH"
                        },
                        new
                        {
                            ID = 35,
                            SectionCode = "HHI"
                        },
                        new
                        {
                            ID = 36,
                            SectionCode = "HIJ"
                        },
                        new
                        {
                            ID = 37,
                            SectionCode = "FAB"
                        },
                        new
                        {
                            ID = 38,
                            SectionCode = "FBC"
                        },
                        new
                        {
                            ID = 39,
                            SectionCode = "FCD"
                        },
                        new
                        {
                            ID = 40,
                            SectionCode = "FDE"
                        },
                        new
                        {
                            ID = 41,
                            SectionCode = "FEF"
                        },
                        new
                        {
                            ID = 42,
                            SectionCode = "FFG"
                        },
                        new
                        {
                            ID = 43,
                            SectionCode = "FGH"
                        },
                        new
                        {
                            ID = 44,
                            SectionCode = "FHI"
                        },
                        new
                        {
                            ID = 45,
                            SectionCode = "FIJ"
                        },
                        new
                        {
                            ID = 46,
                            SectionCode = "SAB"
                        },
                        new
                        {
                            ID = 47,
                            SectionCode = "SBC"
                        },
                        new
                        {
                            ID = 48,
                            SectionCode = "SCD"
                        },
                        new
                        {
                            ID = 49,
                            SectionCode = "SDE"
                        },
                        new
                        {
                            ID = 50,
                            SectionCode = "SEF"
                        },
                        new
                        {
                            ID = 51,
                            SectionCode = "SFG"
                        },
                        new
                        {
                            ID = 52,
                            SectionCode = "SGH"
                        },
                        new
                        {
                            ID = 53,
                            SectionCode = "SHI"
                        },
                        new
                        {
                            ID = 54,
                            SectionCode = "SIJ"
                        });
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.StudentSubject", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "SubjectID");

                    b.HasIndex("SubjectID");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ClassSize")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionID")
                        .HasColumnType("int");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("SectionID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentEnrollmentSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.ApplicationUser", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Course", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Faculty", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.Department", "Department")
                        .WithMany("Faculties")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.StudentSubject", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.ApplicationUser", "Student")
                        .WithMany("Subjects")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentEnrollmentSystem.Models.Subject", "Subject")
                        .WithMany("Students")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Subject", b =>
                {
                    b.HasOne("StudentEnrollmentSystem.Models.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentEnrollmentSystem.Models.Faculty", "Faculty")
                        .WithMany("Subjects")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StudentEnrollmentSystem.Models.Section", "Section")
                        .WithMany("Subjects")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Faculty");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.ApplicationUser", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Course", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Faculty", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Section", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentEnrollmentSystem.Models.Subject", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
