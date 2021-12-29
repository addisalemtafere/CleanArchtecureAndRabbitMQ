﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiroRabbit.Transfer.Data.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiroRabbit.Transfer.Data.Migrations
{
    [DbContext(typeof(TransferDbContext))]
    [Migration("20211229082623_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MiroRabbit.Transfer.Data.Model.TransferLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("FromAccount")
                        .HasColumnType("integer");

                    b.Property<int>("ToAccount")
                        .HasColumnType("integer");

                    b.Property<decimal>("TransferAmount")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("TransferLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
