using HotelResevation.Domain.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevation.Domain.Core
{
	public class HotelBooking
	{
		public int Id { get; set; }
		public Room Room { get; set; }
		public int RoomId { get; set; }
		public DateTime DateTimeBooked { get; set; } = DateTime.Now;
		public string PhoneNumber { get; set; }
		public string IdCard { get; set; }
		public string UserFullName { get; set; }

	}
}
