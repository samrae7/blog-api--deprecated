﻿// <auto-generated />
using System;
using BlogApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogApi.Migrations
{
    [DbContext(typeof(PostContext))]
    partial class PostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("BlogApi.Models.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1L, Body = "Much ado about nothing", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "William Shakespeare" },
                        new { Id = 2L, Body = "Pride and Prejudice", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Jane Austen" },
                        new { Id = 3L, Body = "Decline anf Fall", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Evelyn Waugh" },
                        new { Id = 4L, Body = "Middlemarch", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "George Eliot" },
                        new { Id = 5L, Body = "Great Expectations", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Charles Dickens" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
