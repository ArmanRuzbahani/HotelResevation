using HotelResevation.Domain.Core.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevation.Domain.Core
{
	/// <summary>
	/// کلاس نماینده‌گر رزرو هتل
	/// </summary>
	public class HotelBooking
	{
		/// <summary>
		/// شناسه یکتای رزرو (کلید اصلی)
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// شیء اتاق رزرو شده (رابطه چند-به-یک)
		/// </summary>
		[ForeignKey("RoomId")]
		[Display(Name = "اتاق رزرو شده")]
		public Room Room { get; set; }

		/// <summary>
		/// شناسه اتاق رزرو شده (کلید خارجی)
		/// </summary>
		[Required(ErrorMessage = "انتخاب اتاق الزامی است")]
		[Display(Name = "شماره اتاق")]
		public int RoomId { get; set; }

		/// <summary>
		/// تاریخ و زمان ثبت رزرو (به صورت خودکار با زمان فعلی پر می‌شود)
		/// </summary>
		[Display(Name = "تاریخ رزرو")]
		[DataType(DataType.DateTime)]
		public DateTime DateTimeBooked { get; set; } = DateTime.Now;

		/// <summary>
		/// شماره موبایل مهمان
		/// </summary>
		[Required(ErrorMessage = "{0} الزامی است")]
		[Display(Name = "شماره موبایل")]
		[RegularExpression(@"^09[0-9]{9}$",
			ErrorMessage = "شماره موبایل باید با 09 شروع شده و 11 رقمی باشد")]
		[StringLength(11, MinimumLength = 11,
			ErrorMessage = "شماره موبایل باید 11 رقمی باشد")]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// شماره ملی مهمان
		/// </summary>
		[Required(ErrorMessage = "{0} الزامی است")]
		[Display(Name = "شماره ملی")]
		[StringLength(10, MinimumLength = 10,
			ErrorMessage = "شماره ملی باید 10 رقمی باشد")]
		public string IdCard { get; set; }

		/// <summary>
		/// نام و نام خانوادگی مهمان
		/// </summary>
		[Required(ErrorMessage = "{0} الزامی است")]
		[Display(Name = "نام و نام خانوادگی")]
		[StringLength(100, MinimumLength = 3,
			ErrorMessage = "نام باید بین 3 تا 100 کاراکتر باشد")]
		public string UserFullName { get; set; }

		/// <summary>
		/// وضعیت رزرو (پیش‌فرض: فعال)
		/// </summary>
		[Display(Name = "وضعیت رزرو")]
		public bool IsActive { get; set; } = true;

		/// <summary>
		/// تاریخ شروع اقامت
		/// </summary>
		[Required(ErrorMessage = "تاریخ شروع اقامت الزامی است")]
		[Display(Name = "تاریخ شروع")]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		/// <summary>
		/// تاریخ پایان اقامت
		/// </summary>
		[Required(ErrorMessage = "تاریخ پایان اقامت الزامی است")]
		[Display(Name = "تاریخ پایان")]
		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }

		/// <summary>
		/// مبلغ کل رزرو (به تومان)
		/// </summary>
		[Display(Name = "مبلغ کل")]
		[Range(0, double.MaxValue, ErrorMessage = "مبلغ نمی‌تواند منفی باشد")]
		public decimal TotalPrice { get; set; }
	}
}