﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using src.Data;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221210103142_ContactUsUpdate")]
    partial class ContactUsUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("src.Entities.BlogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PathToImage")
                        .HasColumnType("longtext");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BlogEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9951),
                            Description = "Defamation removal can be challenging. With our step-by-step guide, learn how to protect ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1Ay8uRSkkC7t3fesB6Bv9uYPPMTDPoIsg",
                            Tag = "Reputation Management",
                            Title = "How to Do Defamation Removal Online",
                            Url = "https://notion.com"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9978),
                            Description = "If you’re well known in your region, the United States, or the world, you’ve likely put a lot of time and resources,,,",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1BfStpnrw0gp9KgwhghQY2MauokSpZgmc",
                            Tag = "Reputation Management",
                            Title = "Why You Need An Online Reputation",
                            Url = "https://notion.com"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9982),
                            Description = "Fast People Search removal can help protect your privacy online. Learn how to complete the r/reddit.com ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=17ihd1n1_xPrEPDdQTO2S87ERAxQqkoJQ",
                            Tag = "Social Media",
                            Title = "How to Remove Info from Reddit",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9984),
                            Description = "Since most customers will interact with as business for the first time on the internet, having an effective customer ....",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1b8srGH7MPKV0kw9apnc5XllJF24OuW0A",
                            Tag = "Reputation Management",
                            Title = "5 Strategies for Customer Review Management in 2022",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9986),
                            Description = "Having a great Google review management strategy is very important. They act as an icebreaker to....",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1ULJjgPxnEGkLEO9VIX_5m7dkKCjwLayk",
                            Tag = "Google Review",
                            Title = "How to Remove Personal Information from Google",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9992),
                            Description = "Fast People Search removal can help protect your privacy online. Learn how to complete the FastPeopleSearch...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1eJQLcMxgObTqbKYc3jujQsvgAd72fQa-",
                            Tag = "Politics",
                            Title = "Reputation Management for Politicians: What to Know",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9994),
                            Description = "Your public perception is known as your online reputation, telling others who you are, what …",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1-r54A5pU0NAVTwr8IQZ9mxvWUG37Zxu2",
                            Tag = "Reputation Management",
                            Title = "How to Remove My Information from Been Verified",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 8,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9995),
                            Description = "If you’re well known in your region, the United States, or the world, you’ve likely put a lot of time and...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1YNXXb3_mVJePpK3JPbknuTomNpvuBIAl",
                            Tag = "Reputation Management",
                            Title = "7 Software Development Models to Organize Your Team",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 9,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 269, DateTimeKind.Local).AddTicks(9996),
                            Description = "Your public perception is known as your online reputation, telling others who you are, what values...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1NZY_9xSFlzQ2_OrOThoZlXQUap77k18A",
                            Tag = "Social Media",
                            Title = "How to Remove My Information from Instagram",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 10,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 270, DateTimeKind.Local),
                            Description = "Defamation removal can be challenging. With our step-by-step guide, learn how to protect ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1NZY_9xSFlzQ2_OrOThoZlXQUap77k18A",
                            Tag = "Reputation Management",
                            Title = "How to Do Defamation Removal Online",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 11,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 270, DateTimeKind.Local).AddTicks(2),
                            Description = "Defamation removal can be challenging. With our step-by-step guide, learn how to protect ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1YNXXb3_mVJePpK3JPbknuTomNpvuBIAl",
                            Tag = "Reputation Management",
                            Title = "How to Do Defamation Removal Online",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 12,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 270, DateTimeKind.Local).AddTicks(4),
                            Description = "Defamation removal can be challenging. With our step-by-step guide, learn how to protect ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=1eJQLcMxgObTqbKYc3jujQsvgAd72fQa-",
                            Tag = "Reputation Management",
                            Title = "How to Do Defamation Removal Online",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 13,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 270, DateTimeKind.Local).AddTicks(6),
                            Description = "Defamation removal can be challenging. With our step-by-step guide, learn how to protect ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=17ihd1n1_xPrEPDdQTO2S87ERAxQqkoJQ",
                            Tag = "Reputation Management",
                            Title = "How to Do Defamation Removal Online",
                            Url = "https://google.com"
                        },
                        new
                        {
                            Id = 14,
                            CreationDate = new DateTime(2022, 12, 10, 11, 31, 42, 270, DateTimeKind.Local).AddTicks(8),
                            Description = "Defamation removal can be challenging. With our step-by-step guide, learn how to protect ...",
                            PathToImage = "https://drive.google.com/uc?export=view&id=17ihd1n1_xPrEPDdQTO2S87ERAxQqkoJQ",
                            Tag = "Reputation Management",
                            Title = "How to Do Defamation Removal Online",
                            Url = "https://google.com"
                        });
                });

            modelBuilder.Entity("src.Entities.CareerResponse", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CoverLetterFileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ResumeFileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("CareerResponses");
                });

            modelBuilder.Entity("src.Entities.ChallengeReview", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ComplaintMessage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("ReviewId");

                    b.ToTable("challengeReviews");
                });

            modelBuilder.Entity("src.Entities.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("src.Entities.Quote", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastAccessed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReviewLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("src.Entities.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BusinessType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ComplainerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LawyerEmail")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewString")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfReview")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ViewLastTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WebsiteName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("src.Entities.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OrderNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TrxRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("src.Entities.UserComplains", b =>
                {
                    b.Property<Guid>("ComplaintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ComplaintMessage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ComplaintId");

                    b.ToTable("UserComplaint");
                });
#pragma warning restore 612, 618
        }
    }
}
