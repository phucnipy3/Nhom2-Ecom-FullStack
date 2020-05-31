﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Nhom2.Ecom.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200531151330_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogID");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.BlogComment", b =>
                {
                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("BlogID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("BlogComment");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.CategoryDetail", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("CategoryDetail");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.CustomerAddress", b =>
                {
                    b.Property<int>("CustomerAddressID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinceID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CustomerAddressID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerAddressID")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PromotionCodeID")
                        .HasColumnType("int");

                    b.Property<int?>("StatusID")
                        .HasColumnType("int");

                    b.Property<string>("Transport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerAddressID");

                    b.HasIndex("PromotionCodeID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.OrderDetail", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.OrderTracking", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CompleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID", "StatusID");

                    b.HasIndex("StatusID");

                    b.ToTable("OrderTracking");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Name")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PromotionPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.ProductComment", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("ProductComment");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.ProductImage", b =>
                {
                    b.Property<int>("ProductImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ProductImageID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.ProductRate", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RatePoint")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("ProductRate");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.PromotionCode", b =>
                {
                    b.Property<int>("PromotionCodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Infomation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("PromotionCodeID");

                    b.ToTable("PromotionCode");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Province", b =>
                {
                    b.Property<int>("ProvinceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Infomation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.BlogComment", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Blog", "Blog")
                        .WithMany("BlogComments")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Users", "User")
                        .WithMany("BlogComments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.CategoryDetail", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Category", "Category")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Product", "Product")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.CustomerAddress", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Users", "User")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("CustomerAddressID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Province", "Province")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.Order", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.CustomerAddress", "CustomerAddress")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerAddressID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.PromotionCode", "PromotionCode")
                        .WithMany("Orders")
                        .HasForeignKey("PromotionCodeID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Nhom2.Ecom.Data.Database.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.OrderDetail", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.OrderTracking", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Order", "Order")
                        .WithMany("OrderTrackings")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Status", "Status")
                        .WithMany("OrderTrackings")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.ProductComment", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Product", "Product")
                        .WithMany("ProductComments")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Users", "User")
                        .WithMany("ProductComments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.ProductImage", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom2.Ecom.Data.Database.ProductRate", b =>
                {
                    b.HasOne("Nhom2.Ecom.Data.Database.Product", "Product")
                        .WithMany("ProductRates")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Nhom2.Ecom.Data.Database.Users", "User")
                        .WithMany("ProductRates")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
