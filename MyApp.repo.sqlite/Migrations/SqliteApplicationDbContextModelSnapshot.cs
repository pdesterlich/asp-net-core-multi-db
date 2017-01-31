using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyApp.repo.sqlite;

namespace MyApp.repo.sqlite.Migrations
{
    [DbContext(typeof(SqliteApplicationDbContext))]
    partial class SqliteApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("MyApp.models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerCode");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });
        }
    }
}
