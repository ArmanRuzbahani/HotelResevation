using HotelResevation.Domain.Core;
using HotelResevation.Domain.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE.Common
{
	/// <summary>
	/// کلاس زمینه بانک اطلاعاتی که توسط Entity Framework Core استفاده می‌شود
	/// </summary>
	public class ApplicationDBContext : DbContext
	{
		/// <summary>
		/// سازنده کلاس که برای DI استفاده می‌شود
		/// </summary>
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
			: base(options)
		{
		}

		/// <summary>
		/// تنظیمات اتصال به دیتابیس در صورتی که از DI استفاده نشود
		/// </summary>
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=ARMAN\SQLEXPRESS;Database=HotelResevation;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;");
			}
		}

		/// <summary>
		/// پیکربندی مدل‌ها و روابط بین موجودیت‌ها (Entity ها)
		/// </summary>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// رابطه یک به چند: هتل ← اتاق‌ها
			modelBuilder.Entity<Hotel>()
				.HasMany(h => h.Rooms)
				.WithOne(r => r.Hotel)
				.HasForeignKey(r => r.HotelId)
				.OnDelete(DeleteBehavior.Cascade); // حذف اتاق‌ها با حذف هتل

			// رابطه یک به چند: هتل ← نظرات
			modelBuilder.Entity<Hotel>()
				.HasMany(h => h.Comments)
				.WithOne(c => c.Hotel)
				.HasForeignKey(c => c.HotelId)
				.OnDelete(DeleteBehavior.Cascade); // حذف نظرات با حذف هتل

			// رابطه یک به چند: اتاق ← رزروها
			modelBuilder.Entity<Room>()
				.HasMany(r => r.Bookings)
				.WithOne(b => b.Room)
				.HasForeignKey(b => b.RoomId)
				.OnDelete(DeleteBehavior.Cascade); // حذف رزروها با حذف اتاق
		}

		// مجموعه‌ای از موجودیت‌های جدول نظرات
		public DbSet<Comment> Comments { get; set; }

		// مجموعه‌ای از موجودیت‌های جدول هتل‌ها
		public DbSet<Hotel> Hotels { get; set; }

		// مجموعه‌ای از موجودیت‌های جدول رزروها
		public DbSet<HotelBooking> HotelBookings { get; set; }

		// مجموعه‌ای از موجودیت‌های جدول اتاق‌ها
		public DbSet<Room> Rooms { get; set; }
	}
}
