using HotelResevation.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelResevation.Domain.Core.Entitys
{
	public class Hotel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Adress { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Photos { get; set; }
		public List<Room> Rooms { get; set; }
		public List<Comment> Comments { get; set; }
		public string description { get; set; }
		public int Numbersofroom { get; set; }
		public Citys Citys { get; set; }


	}
}
