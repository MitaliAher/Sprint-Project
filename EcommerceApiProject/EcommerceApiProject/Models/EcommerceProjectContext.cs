using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcommerceApiProject.Models
{
    public partial class EcommerceProjectContext : DbContext
    {
        public EcommerceProjectContext()
        {
        }

        public EcommerceProjectContext(DbContextOptions<EcommerceProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryTbl1> CategoryTbl1s { get; set; }
        public virtual DbSet<LoginTbl> LoginTbls { get; set; }
        public virtual DbSet<ProductTbl> ProductTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CategoryTbl1>(entity =>
            {
                entity.ToTable("CategoryTbl1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CatName).HasMaxLength(100);
            });

            modelBuilder.Entity<LoginTbl>(entity =>
            {
                entity.ToTable("LoginTbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductTbl>(entity =>
            {
                entity.ToTable("ProductTbl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.ProductDescription).HasMaxLength(100);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductImage).HasMaxLength(100);

                entity.Property(e => e.ProductMrp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
