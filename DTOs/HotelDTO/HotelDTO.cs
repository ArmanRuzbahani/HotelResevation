using HotelResevation.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOs.HotelDTO
{
	public class HotelDTO
	{
		public class HotelCreateDto
		{
			/// <summary>
			/// نام هتل - اجباری با حداکثر 100 کاراکتر
			/// </summary>
			[Required(ErrorMessage = "نام هتل الزامی است")]
			[StringLength(100, ErrorMessage = "نام هتل نمی‌تواند بیش از 100 کاراکتر باشد")]
			public string Name { get; set; }

			/// <summary>
			/// آدرس کامل هتل - اجباری با حداکثر 200 کاراکتر
			/// </summary>
			[Required(ErrorMessage = "آدرس هتل الزامی است")]
			[StringLength(200, ErrorMessage = "آدرس نمی‌تواند بیش از 200 کاراکتر باشد")]
			public string Address { get; set; }

			/// <summary>
			/// شماره تماس هتل - باید 11 رقمی باشد
			/// </summary>
			[Required(ErrorMessage = "شماره تلفن الزامی است")]
			[RegularExpression(@"^[0-9]{11}$", ErrorMessage = "شماره تلفن باید 11 رقمی باشد")]
			public string PhoneNumber { get; set; }

			/// <summary>
			/// ایمیل هتل با فرمت استاندارد
			/// </summary>
			[Required(ErrorMessage = "ایمیل الزامی است")]
			[EmailAddress(ErrorMessage = "فرمت ایمیل نامعتبر است")]
			public string Email { get; set; }

			/// <summary>
			/// مسیر تصاویر هتل (رشته، می‌تواند JSON یا کاما جدا باشد)
			/// </summary>
			public string Photos { get; set; }

			/// <summary>
			/// توضیحات هتل - اجباری با حداکثر 1000 کاراکتر
			/// </summary>
			[Required(ErrorMessage = "توضیحات هتل الزامی است")]
			[StringLength(1000, ErrorMessage = "توضیحات نمی‌تواند بیش از 1000 کاراکتر باشد")]
			public string Description { get; set; }

			/// <summary>
			/// تعداد کل اتاق‌ها - بین 1 تا 1000
			/// </summary>
			[Required(ErrorMessage = "تعداد اتاق‌ها الزامی است")]
			[Range(1, 1000, ErrorMessage = "تعداد اتاق‌ها باید بین 1 تا 1000 باشد")]
			public int NumberOfRooms { get; set; }

			/// <summary>
			/// شهر هتل - enum اجباری
			/// </summary>
			[Required(ErrorMessage = "شهر الزامی است")]
			public City City { get; set; }
		}

		public class HotelUpdateDto
		{
			/// <summary>
			/// شناسه یکتای هتل (الزامی)
			/// </summary>
			[Required(ErrorMessage = "شناسه هتل الزامی است")]
			public int Id { get; set; }

			/// <summary>
			/// نام هتل - اختیاری با حداکثر 100 کاراکتر
			/// </summary>
			[StringLength(100, ErrorMessage = "نام هتل نمی‌تواند بیش از 100 کاراکتر باشد")]
			public string? Name { get; set; }

			/// <summary>
			/// آدرس هتل - اختیاری با حداکثر 200 کاراکتر
			/// </summary>
			[StringLength(200, ErrorMessage = "آدرس نمی‌تواند بیش از 200 کاراکتر باشد")]
			public string? Address { get; set; }

			/// <summary>
			/// شماره تماس هتل - اختیاری، باید 11 رقمی باشد
			/// </summary>
			[RegularExpression(@"^[0-9]{11}$", ErrorMessage = "شماره تلفن باید 11 رقمی باشد")]
			public string? PhoneNumber { get; set; }

			/// <summary>
			/// ایمیل هتل - اختیاری با فرمت استاندارد ایمیل
			/// </summary>
			[EmailAddress(ErrorMessage = "فرمت ایمیل نامعتبر است")]
			public string? Email { get; set; }

			/// <summary>
			/// مسیر تصاویر هتل - اختیاری
			/// </summary>
			public string? Photos { get; set; }

			/// <summary>
			/// توضیحات هتل - اختیاری با حداکثر 1000 کاراکتر
			/// </summary>
			[StringLength(1000, ErrorMessage = "توضیحات نمی‌تواند بیش از 1000 کاراکتر باشد")]
			public string? Description { get; set; }

			/// <summary>
			/// تعداد اتاق‌ها - اختیاری، بین 1 تا 1000
			/// </summary>
			[Range(1, 1000, ErrorMessage = "تعداد اتاق‌ها باید بین 1 تا 1000 باشد")]
			public int? NumberOfRooms { get; set; }

			/// <summary>
			/// شهر - اختیاری
			/// </summary>
			public City? City { get; set; }
		}

		public class HotelReadDto
		{
			/// <summary>
			/// شناسه یکتای هتل
			/// </summary>
			public int Id { get; set; }

			/// <summary>
			/// نام هتل
			/// </summary>
			public string Name { get; set; }

			/// <summary>
			/// آدرس هتل
			/// </summary>
			public string Address { get; set; }

			/// <summary>
			/// شماره تماس هتل
			/// </summary>
			public string PhoneNumber { get; set; }

			/// <summary>
			/// ایمیل هتل
			/// </summary>
			public string Email { get; set; }

			/// <summary>
			/// مسیر تصاویر هتل
			/// </summary>
			public string Photos { get; set; }

			/// <summary>
			/// توضیحات هتل
			/// </summary>
			public string Description { get; set; }

			/// <summary>
			/// تعداد کل اتاق‌ها
			/// </summary>
			public int NumberOfRooms { get; set; }

			/// <summary>
			/// شهر هتل
			/// </summary>
			public City City { get; set; }
		}
	}
}
