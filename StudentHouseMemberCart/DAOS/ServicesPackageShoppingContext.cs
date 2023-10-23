using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BussinenssObject.Models
{
    public partial class ServicesPackageShoppingContext : DbContext
    {
        public ServicesPackageShoppingContext()
        {
        }

        public ServicesPackageShoppingContext(DbContextOptions<ServicesPackageShoppingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerManagement> CustomerManagements { get; set; } = null!;
        public virtual DbSet<OrderManagement> OrderManagements { get; set; } = null!;
        public virtual DbSet<PackageServiceManagement> PackageServiceManagements { get; set; } = null!;
        public virtual DbSet<ServiceManagement> ServiceManagements { get; set; } = null!;
        public virtual DbSet<StaffManagement> StaffManagements { get; set; } = null!;
        public virtual DbSet<StaffOrderManagement> StaffOrderManagements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-RFJCRS8T;Database=ServicesPackageShopping; Uid=sa; Pwd=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerManagement>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B8AAB8FDCB");

                entity.ToTable("CustomerManagement");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Avatar)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('https://firebasestorage.googleapis.com/v0/b/stufb-e00cc.appspot.com/o/images%2Favatar-nobita.png?alt=media&token=b7b03285-7690-47ef-b1ac-44a33e4179e5&_gl=1*1rvt5ir*_ga*MzExODI2NzcyLjE2OTQ5NjAyNDU.*_ga_CW55HF8NVT*MTY5Njk0MzU2Ni4xNi4xLjE2OTY5NDM4NzcuNDEuMC4w')");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.TotalOrders)
                    .HasColumnName("totalOrders")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderManagement>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderMan__C3905BCFFDCEEA32");

                entity.ToTable("OrderManagement");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCompleted)
                    .HasColumnType("date")
                    .HasColumnName("dateCompleted");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOTE");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentMethod");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");
            });

            modelBuilder.Entity<PackageServiceManagement>(entity =>
            {
                entity.HasKey(e => e.PackageServiceId)
                    .HasName("PK__PackageS__5EAFC210C1338618");

                entity.ToTable("PackageServiceManagement");

                entity.Property(e => e.PackageServiceId).HasColumnName("PackageServiceID");

                entity.Property(e => e.AverageRating)
                    .HasColumnName("averageRating")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Image)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('https://firebasestorage.googleapis.com/v0/b/stufb-e00cc.appspot.com/o/images%2F4Stu-Logo.png?alt=media&token=2736aeb6-4735-4890-a257-9ef1a0593566&_gl=1*1e16zej*_ga*MzExODI2NzcyLjE2OTQ5NjAyNDU.*_ga_CW55HF8NVT*MTY5NjM0Mzg5OC4xMi4xLjE2OTYzNDM5NDUuMTMuMC4w')");

                entity.Property(e => e.LongImage)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('https://firebasestorage.googleapis.com/v0/b/stufb-e00cc.appspot.com/o/images%2F4Stu-Logo%20(320%20x%20160%20px).png?alt=media&token=e63499fb-1d54-498e-9687-103ab9f255bc&_gl=1*2scf3l*_ga*MzExODI2NzcyLjE2OTQ5NjAyNDU.*_ga_CW55HF8NVT*MTY5Njk0MzU2Ni4xNi4xLjE2OTY5NDM2MDQuMjIuMC4w')");

                entity.Property(e => e.PackageServiceDesc).HasColumnType("text");

                entity.Property(e => e.PackageServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RatingCount)
                    .HasColumnName("ratingCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepetitionCycle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.Time)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceManagement>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__ServiceM__C51BB0EAF4366F6D");

                entity.ToTable("ServiceManagement");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.AverageRating)
                    .HasColumnName("averageRating")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Image)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('https://firebasestorage.googleapis.com/v0/b/stufb-e00cc.appspot.com/o/images%2F4Stu-Logo.png?alt=media&token=2736aeb6-4735-4890-a257-9ef1a0593566&_gl=1*1e16zej*_ga*MzExODI2NzcyLjE2OTQ5NjAyNDU.*_ga_CW55HF8NVT*MTY5NjM0Mzg5OC4xMi4xLjE2OTYzNDM5NDUuMTMuMC4w')");

                entity.Property(e => e.LongImage)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('https://firebasestorage.googleapis.com/v0/b/stufb-e00cc.appspot.com/o/images%2F4Stu-Logo%20(320%20x%20160%20px).png?alt=media&token=e63499fb-1d54-498e-9687-103ab9f255bc&_gl=1*2scf3l*_ga*MzExODI2NzcyLjE2OTQ5NjAyNDU.*_ga_CW55HF8NVT*MTY5Njk0MzU2Ni4xNi4xLjE2OTY5NDM2MDQuMjIuMC4w')");

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RatingCount)
                    .HasColumnName("ratingCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServiceDesc).HasColumnType("text");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffManagement>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("PK__StaffMan__96D4AAF7D5782494");

                entity.ToTable("StaffManagement");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Avatar)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('https://firebasestorage.googleapis.com/v0/b/stufb-e00cc.appspot.com/o/images%2Favatar-nobita.png?alt=media&token=b7b03285-7690-47ef-b1ac-44a33e4179e5&_gl=1*1rvt5ir*_ga*MzExODI2NzcyLjE2OTQ5NjAyNDU.*_ga_CW55HF8NVT*MTY5Njk0MzU2Ni4xNi4xLjE2OTY5NDM4NzcuNDEuMC4w')");

                entity.Property(e => e.AverageRating)
                    .HasColumnName("averageRating")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RatingCount)
                    .HasColumnName("ratingCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");
            });

            modelBuilder.Entity<StaffOrderManagement>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.StaffId })
                    .HasName("PK__StaffOrd__AAFD11009C838259");

                entity.ToTable("StaffOrderManagement");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.StaffOrderManagements)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffOrderManagement_OrderManagement");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffOrderManagements)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffOrderManagement_StaffManagement");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
