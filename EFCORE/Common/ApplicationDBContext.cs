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
	public class ApplicationDBContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=ARMAN\SQLEXPRESS;Database=HotelResevation;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;");

			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// 🔗 Hotel → Rooms (One-to-Many)
			modelBuilder.Entity<Hotel>()
				.HasMany(h => h.Rooms)
				.WithOne(r => r.Hotel)
				.HasForeignKey(r => r.HotelId)
				.OnDelete(DeleteBehavior.Cascade);

			// 🔗 Hotel → Comments (One-to-Many)
			modelBuilder.Entity<Hotel>()
				.HasMany(h => h.Comments)
				.WithOne(c => c.Hotel)
				.HasForeignKey(c => c.HotelId)
				.OnDelete(DeleteBehavior.Cascade);

			// 🔗 Room → HotelBookings (One-to-Many)
			modelBuilder.Entity<Room>()
				.HasMany(r => r.Bookings)
				.WithOne(b => b.Room)
				.HasForeignKey(b => b.RoomId)
				.OnDelete(DeleteBehavior.Cascade);
		}
		public DbSet<Comment> comments {  get; set; }	
		public DbSet<Hotel> hotels { get; set; }
		public DbSet<HotelBooking> hotelBookings { get; set; }
		public DbSet<Room> rooms { get; set; }	
	}
}
