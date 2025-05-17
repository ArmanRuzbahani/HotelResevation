using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.HotelBookingDTO
{
	public class HBDTO
	{
		public class HotelBookingCreateDto
		{
			/// <summary>
			/// شناسه اتاق رزرو شده (الزامی)
			/// </summary>
			[Required(ErrorMessage = "انتخاب اتاق الزامی است")]
			public int RoomId { get; set; }

			/// <summary>
			/// شماره موبایل مهمان (الزامی، فرمت معتبر)
			/// </summary>
			[Required(ErrorMessage = "شماره موبایل الزامی است")]
			[RegularExpression(@"^09[0-9]{9}$", ErrorMessage = "شماره موبایل باید با 09 شروع شده و 11 رقمی باشد")]
			[StringLength(11, MinimumLength = 11, ErrorMessage = "شماره موبایل باید 11 رقمی باشد")]
			public string PhoneNumber { get; set; }

			/// <summary>
			/// شماره ملی مهمان (الزامی، 10 رقم)
			/// </summary>
			[Required(ErrorMessage = "شماره ملی الزامی است")]
			[StringLength(10, MinimumLength = 10, ErrorMessage = "شماره ملی باید 10 رقمی باشد")]
			public string IdCard { get; set; }

			/// <summary>
			/// نام و نام خانوادگی مهمان (الزامی، بین 3 تا 100 کاراکتر)
			/// </summary>
			[Required(ErrorMessage = "نام و نام خانوادگی الزامی است")]
			[StringLength(100, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 100 کاراکتر باشد")]
			public string UserFullName { get; set; }

			/// <summary>
			/// تاریخ شروع اقامت (الزامی)
			/// </summary>
			[Required(ErrorMessage = "تاریخ شروع اقامت الزامی است")]
			[DataType(DataType.Date)]
			public DateTime StartDate { get; set; }

			/// <summary>
			/// تاریخ پایان اقامت (الزامی)
			/// </summary>
			[Required(ErrorMessage = "تاریخ پایان اقامت الزامی است")]
			[DataType(DataType.Date)]
			public DateTime EndDate { get; set; }

			/// <summary>
			/// مبلغ کل رزرو (اختیاری، مثبت یا صفر)
			/// </summary>
			[Range(0, double.MaxValue, ErrorMessage = "مبلغ نمی‌تواند منفی باشد")]
			public decimal? TotalPrice { get; set; }
		}

		public class HotelBookingUpdateDto
		{
			/// <summary>
			/// شناسه یکتای رزرو (الزامی)
			/// </summary>
			[Required(ErrorMessage = "شناسه رزرو الزامی است")]
			public int Id { get; set; }

			/// <summary>
			/// شناسه اتاق رزرو شده (اختیاری)
			/// </summary>
			public int? RoomId { get; set; }

			/// <summary>
			/// شماره موبایل مهمان (اختیاری)
			/// </summary>
			[RegularExpression(@"^09[0-9]{9}$", ErrorMessage = "شماره موبایل باید با 09 شروع شده و 11 رقمی باشد")]
			[StringLength(11, MinimumLength = 11, ErrorMessage = "شماره موبایل باید 11 رقمی باشد")]
			public string? PhoneNumber { get; set; }

			/// <summary>
			/// شماره ملی مهمان (اختیاری)
			/// </summary>
			[StringLength(10, MinimumLength = 10, ErrorMessage = "شماره ملی باید 10 رقمی باشد")]
			public string? IdCard { get; set; }

			/// <summary>
			/// نام و نام خانوادگی مهمان (اختیاری)
			/// </summary>
			[StringLength(100, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 100 کاراکتر باشد")]
			public string? UserFullName { get; set; }

			/// <summary>
			/// وضعیت رزرو (اختیاری)
			/// </summary>
			public bool? IsActive { get; set; }

			/// <summary>
			/// تاریخ شروع اقامت (اختیاری)
			/// </summary>
			[DataType(DataType.Date)]
			public DateTime? StartDate { get; set; }

			/// <summary>
			/// تاریخ پایان اقامت (اختیاری)
			/// </summary>
			[DataType(DataType.Date)]
			public DateTime? EndDate { get; set; }

			/// <summary>
			/// مبلغ کل رزرو (اختیاری، مثبت یا صفر)
			/// </summary>
			[Range(0, double.MaxValue, ErrorMessage = "مبلغ نمی‌تواند منفی باشد")]
			public decimal? TotalPrice { get; set; }
		}

		public class HotelBookingReadDto
		{
			/// <summary>
			/// شناسه یکتای رزرو
			/// </summary>
			public int Id { get; set; }

			/// <summary>
			/// شناسه اتاق رزرو شده
			/// </summary>
			public int RoomId { get; set; }

			/// <summary>
			/// شماره موبایل مهمان
			/// </summary>
			public string PhoneNumber { get; set; }

			/// <summary>
			/// شماره ملی مهمان
			/// </summary>
			public string IdCard { get; set; }

			/// <summary>
			/// نام و نام خانوادگی مهمان
			/// </summary>
			public string UserFullName { get; set; }

			/// <summary>
			/// وضعیت رزرو
			/// </summary>
			public bool IsActive { get; set; }

			/// <summary>
			/// تاریخ شروع اقامت
			/// </summary>
			public DateTime StartDate { get; set; }

			/// <summary>
			/// تاریخ پایان اقامت
			/// </summary>
			public DateTime EndDate { get; set; }

			/// <summary>
			/// مبلغ کل رزرو
			/// </summary>
			public decimal TotalPrice { get; set; }
		}
	}
}
