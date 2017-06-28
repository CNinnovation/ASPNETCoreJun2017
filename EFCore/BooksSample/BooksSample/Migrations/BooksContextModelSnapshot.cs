﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BooksSample.Models;

namespace BooksSample.Migrations
{
    [DbContext(typeof(BooksContext))]
    partial class BooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BooksSample.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Isbn")
                        .HasMaxLength(20);

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Title")
                        .HasMaxLength(60);

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });
        }
    }
}