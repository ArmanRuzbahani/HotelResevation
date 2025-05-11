using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevation.Domain.Core.Entitys
{
	public class Comment
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }
		public string UserFullName { get; set; }
		public string Email { get; set; }
		public bool IsCheckedByAdmin { get; set; }
		public DateTime DateTimeCreated { get; set; } = DateTime.Now;
		public int Stars { get; set; }
	}
}
