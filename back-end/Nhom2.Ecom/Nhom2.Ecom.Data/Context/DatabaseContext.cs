namespace Nhom2.Ecom.Data
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogComment> BlogComments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryDetail> CategoryDetails { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderTracking> OrderTrackings { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductComment> ProductComments { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductRate> ProductRates { get; set; }
        public virtual DbSet<PromotionCode> PromotionCodes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogComment>()
                .HasKey(e => new { e.BlogID, e.UserID });

            modelBuilder.Entity<CategoryDetail>()
                .HasKey(e => new { e.ProductID, e.CategoryID });

            modelBuilder.Entity<OrderDetail>()
                .HasKey(e => new { e.ProductID, e.OrderID });

            modelBuilder.Entity<OrderTracking>()
                .HasKey(e => new { e.OrderID, e.StatusID });

            modelBuilder.Entity<ProductComment>()
                .HasKey(e => new { e.ProductID, e.UserID });

            modelBuilder.Entity<ProductRate>()
                .HasKey(e => new { e.ProductID, e.UserID });

            modelBuilder.Entity<Blog>()
                .HasMany(e => e.BlogComments)
                .WithOne(e => e.Blog)
                .HasForeignKey(e => e.BlogID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.BlogComments)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryDetails)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CategoryDetails)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.CustomerAddresses)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.CustomerAddressID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(e => e.User)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(e => e.PromotionCode)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.PromotionCodeID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(e => e.CustomerAddress)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.CustomerAddressID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithOne(e => e.Order)
                .HasForeignKey(e => e.OrderID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderTrackings)
                .WithOne(e => e.Order)
                .HasForeignKey(e => e.StatusID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.OrderTrackings)
                .WithOne(e => e.Status)
                .HasForeignKey(e => e.StatusID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductComments)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ProductComments)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductRates)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ProductRates)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.CustomerAddresses)
                .WithOne(e => e.Province)
                .HasForeignKey(e => e.ProvinceID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductImages)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
