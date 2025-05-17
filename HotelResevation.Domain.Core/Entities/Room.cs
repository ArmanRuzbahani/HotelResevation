using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // برای اتریبیوت‌های اعتبارسنجی
using System.ComponentModel.DataAnnotations.Schema; // برای اتریبیوت‌های مربوط به دیتابیس
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevation.Domain.Core.Entitys
{
	/// <summary>
	/// کلاس نماینده‌گر اتاق‌های هتل
	/// </summary>
	public class Room
	{
		/// <summary>
		/// شناسه یکتای اتاق (کلید اصلی)
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// نام/شماره اتاق - اجباری
		/// </summary>
		[Required(ErrorMessage = "نام اتاق الزامی است")]
		[Display(Name = "نام/شماره اتاق")]
		[StringLength(50, ErrorMessage = "نام اتاق نمی‌تواند بیش از 50 کاراکتر باشد")]
		public string RoomName { get; set; }

		/// <summary>
		/// مسیر تصاویر اتاق (می‌تواند لیستی از آدرس تصاویر باشد)
		/// </summary>
		[Display(Name = "تصاویر اتاق")]
		public string Photos { get; set; }

		/// <summary>
		/// شناسه هتل مربوطه (کلید خارجی)
		/// </summary>
		[Required(ErrorMessage = "انتخاب هتل الزامی است")]
		[Display(Name = "هتل")]
		public int HotelId { get; set; }

		/// <summary>
		/// شیء هتل مربوطه (رابطه چند-به-یک)
		/// </summary>
		[ForeignKey("HotelId")]
		public Hotel Hotel { get; set; }

		/// <summary>
		/// قیمت هر شب اقامت - باید بیشتر از صفر باشد
		/// </summary>
		[Required(ErrorMessage = "قیمت هر شب الزامی است")]
		[Display(Name = "قیمت هر شب (تومان)")]
		[Range(1, int.MaxValue, ErrorMessage = "قیمت باید بیشتر از صفر باشد")]
		public int PricePerNight { get; set; }

		/// <summary>
		/// وضعیت اشغال بودن اتاق
		/// </summary>
		[Display(Name = "وضعیت اشغال")]
		public bool IsEmpty { get; set; }

		/// <summary>
		/// لیست رزروهای این اتاق (رابطه یک-به-بسیار)
		/// </summary>
		[Display(Name = "رزروها")]
		public List<HotelBooking> Bookings { get; set; } = new();
	}
}