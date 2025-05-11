using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevation.Domain.Core.Entitys
{
	public class Room
	{
		public int Id { get; set; }
		public string RoomName { get; set; }
		public string Photos { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }
		public int PricePerNight { get; set; }
		public bool IsEmpty { get; set; }
		public List<HotelBooking> Bookings { get; set; } = new();
	}
}

