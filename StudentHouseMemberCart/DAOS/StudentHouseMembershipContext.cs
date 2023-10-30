using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BussinenssObject.Models
{
    public partial class StudentHouseMembershipContext : DbContext
    {
        public StudentHouseMembershipContext()
        {
        }

        public StudentHouseMembershipContext(DbContextOptions<StudentHouseMembershipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminService> AdminServices { get; set; } = null!;
        public virtual DbSet<AdminT> AdminTs { get; set; } = null!;
        public virtual DbSet<CustomerT> CustomerTs { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<StaffOrder> StaffOrders { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-RFJCRS8T;Database=StudentHouseMembership; Uid=sa; Pwd=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.LatestUpdate).HasColumnType("date");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.Admin)
                    .WithMany()
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK__AdminServ__Admin__32E0915F");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__AdminServ__Servi__33D4B598");
            });

            modelBuilder.Entity<AdminT>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__Admin__719FE4E8EBE4F4B7");

                entity.ToTable("AdminT");

                entity.Property(e => e.AdminId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdminID");

                entity.Property(e => e.AdminName).HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<CustomerT>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B8A12F5394");

                entity.ToTable("CustomerT");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("dateCreated");

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
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalServices).HasColumnName("totalServices");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__CustomerI__286302EC");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__2B3F6F97");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__OrderDeta__Servi__2C3393D0");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("PaymentID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Payment__OrderID__36B12243");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ServiceID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StaffOrder");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__StaffOrde__Order__398D8EEE");

                entity.HasOne(d => d.Staff)
                    .WithMany()
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__StaffOrde__Staff__38996AB5");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.StaffId)
                    .ValueGeneratedNever()
                    .HasColumnName("StaffID");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(10);

                entity.Property(e => e.Phone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__Staff__ServiceID__2F10007B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
