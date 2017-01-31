using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyApp.repo.mysql;

namespace MyApp.repo.mysql.Migrations
{
    [DbContext(typeof(MySqlApplicationDbContext))]
    [Migration("20170131160930_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
