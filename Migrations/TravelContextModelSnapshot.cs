﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WeekProject.Models;

namespace WeekProject.Migrations
{
    [DbContext(typeof(TravelContext))]
    partial class TravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("WeekProject.Models.Comment", b =>
                {
                    b.Property<int>("commentid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("comment");

                    b.Property<DateTime>("created_at");

                    b.Property<int>("pictureid");

                    b.Property<int>("senderid");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("commentid");

                    b.HasIndex("pictureid");

                    b.HasIndex("senderid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WeekProject.Models.Picture", b =>
                {
                    b.Property<int>("pictureid")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created_at");

                    b.Property<DateTime>("date_visited");

                    b.Property<string>("description");

                    b.Property<string>("pict_name");

                    b.Property<DateTime>("updated_at");

                    b.Property<int>("userid");

                    b.HasKey("pictureid");

                    b.HasIndex("userid");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("WeekProject.Models.Place", b =>
                {
                    b.Property<int>("placeid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<string>("city");

                    b.Property<DateTime>("created_at");

                    b.Property<int>("place_pictid");

                    b.Property<string>("state");

                    b.Property<DateTime>("updated_at");

                    b.Property<int>("visitorid");

                    b.HasKey("placeid");

                    b.HasIndex("place_pictid");

                    b.HasIndex("visitorid");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("WeekProject.Models.User", b =>
                {
                    b.Property<int>("userid")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created_at");

                    b.Property<string>("email");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.Property<string>("nickname");

                    b.Property<string>("password");

                    b.Property<string>("profile_pict");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WeekProject.Models.Comment", b =>
                {
                    b.HasOne("WeekProject.Models.Picture", "picture")
                        .WithMany("pict_comments")
                        .HasForeignKey("pictureid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WeekProject.Models.User", "sender")
                        .WithMany("my_comments")
                        .HasForeignKey("senderid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WeekProject.Models.Picture", b =>
                {
                    b.HasOne("WeekProject.Models.User", "user")
                        .WithMany("uploaded")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WeekProject.Models.Place", b =>
                {
                    b.HasOne("WeekProject.Models.Picture", "place_pict")
                        .WithMany("places")
                        .HasForeignKey("place_pictid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WeekProject.Models.User", "visitor")
                        .WithMany("visited")
                        .HasForeignKey("visitorid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
