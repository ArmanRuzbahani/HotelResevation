using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.RoomDTO
{
	public class RoomDTO
	{
		public class RoomCreateDto
		{
			/// <summary>
			/// نام یا شماره اتاق - اجباری با حداکثر 50 کاراکتر
			/// </summary>
			[Required(ErrorMessage = "نام اتاق الزامی است")]
			[StringLength(50, ErrorMessage = "نام اتاق نمی‌تواند بیش از 50 کاراکتر باشد")]
			public string RoomName { get; set; }

			/// <summary>
			/// مسیر تصاویر اتاق (می‌تواند رشته JSON یا کاما جدا باشد)
			/// </summary>
			public string Photos { get; set; }

			/// <summary>
			/// شناسه هتل مربوطه - اجباری
			/// </summary>
			[Required(ErrorMessage = "شناسه هتل الزامی است")]
			public int HotelId { get; set; }

			/// <summary>
			/// قیمت هر شب اقامت - باید بیشتر از صفر باشد
			/// </summary>
			[Required(ErrorMessage = "قیمت هر شب الزامی است")]
			[Range(1, int.MaxValue, ErrorMessage = "قیمت باید بیشتر از صفر باشد")]
			public int PricePerNight { get; set; }

			/// <summary>
			/// وضعیت اشغال بودن اتاق
			/// </summary>
			public bool IsEmpty { get; set; } = true;
		}

		public class RoomUpdateDto
		{
			/// <summary>
			/// شناسه اتاق - اجباری
			/// </summary>
			[Required(ErrorMessage = "شناسه اتاق الزامی است")]
			public int Id { get; set; }

			/// <summary>
			/// نام یا شماره اتاق - اختیاری با حداکثر 50 کاراکتر
			/// </summary>
			[StringLength(50, ErrorMessage = "نام اتاق نمی‌تواند بیش از 50 کاراکتر باشد")]
			public string? RoomName { get; set; }

			/// <summary>
			/// مسیر تصاویر اتاق - اختیاری
			/// </summary>
			public string? Photos { get; set; }

			/// <summary>
			/// شناسه هتل - اختیاری
			/// </summary>
			public int? HotelId { get; set; }

			/// <summary>
			/// قیمت هر شب - اختیاری، باید بزرگتر از صفر باشد
			/// </summary>
			[Range(1, int.MaxValue, ErrorMessage = "قیمت باید بیشتر از صفر باشد")]
			public int? PricePerNight { get; set; }

			/// <summary>
			/// وضعیت اشغال بودن اتاق - اختیاری
			/// </summary>
			public bool? IsEmpty { get; set; }
		}

		public class RoomReadDto
		{
			/// <summary>
			/// شناسه یکتای اتاق
			/// </summary>
			public int Id { get; set; }

			/// <summary>
			/// نام یا شماره اتاق
			/// </summary>
			public string RoomName { get; set; }

			/// <summary>
			/// مسیر تصاویر اتاق
			/// </summary>
			public string Photos { get; set; }

			/// <summary>
			/// شناسه هتل مربوطه
			/// </summary>
			public int HotelId { get; set; }

			/// <summary>
			/// قیمت هر شب اقامت
			/// </summary>
			public int PricePerNight { get; set; }

			/// <summary>
			/// وضعیت اشغال بودن اتاق
			/// </summary>
			public bool IsEmpty { get; set; }
		}
	}
}
