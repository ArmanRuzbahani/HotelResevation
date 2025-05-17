using HotelResevation.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelResevation.Domain.Core.Entitys
{
	/// <summary>
	/// کلاس موجودیت هتل - اطلاعات اصلی هتل را نگهداری می‌کند
	/// </summary>
	public class Hotel
	{
		/// <summary>
		/// شناسه یکتا و کلید اصلی هتل
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// نام هتل - اجباری با حداکثر طول 100 کاراکتر
		/// </summary>
		[Required(ErrorMessage = "نام هتل الزامی است")]
		[Display(Name = "نام هتل")]
		[StringLength(100, ErrorMessage = "نام هتل نمی‌تواند بیش از 100 کاراکتر باشد")]
		public string Name { get; set; }

		/// <summary>
		/// آدرس کامل هتل - اجباری با حداکثر طول 200 کاراکتر
		/// </summary>
		[Required(ErrorMessage = "آدرس هتل الزامی است")]
		[Display(Name = "آدرس")]
		[StringLength(200, ErrorMessage = "آدرس نمی‌تواند بیش از 200 کاراکتر باشد")]
		public string Address { get; set; }

		/// <summary>
		/// شماره تماس هتل - باید 11 رقمی باشد
		/// </summary>
		[Required(ErrorMessage = "شماره تلفن الزامی است")]
		[Display(Name = "شماره تماس")]
		[RegularExpression(@"^[0-9]{11}$", ErrorMessage = "شماره تلفن باید 11 رقمی باشد")]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// آدرس ایمیل هتل - با فرمت استاندارد ایمیل
		/// </summary>
		[Required(ErrorMessage = "ایمیل الزامی است")]
		[Display(Name = "ایمیل")]
		[EmailAddress(ErrorMessage = "فرمت ایمیل نامعتبر است")]
		public string Email { get; set; }

		/// <summary>
		/// مسیر تصاویر هتل (می‌تواند لیستی از آدرس تصاویر باشد)
		/// </summary>
		[Display(Name = "تصاویر")]
		public string Photos { get; set; }

		/// <summary>
		/// لیست اتاق‌های موجود در این هتل (رابطه یک-به-بسیار با اتاق‌ها)
		/// </summary>
		[Display(Name = "اتاق‌ها")]
		public List<Room> Rooms { get; set; } = new();

		/// <summary>
		/// لیست نظرات کاربران درباره این هتل (رابطه یک-به-بسیار با نظرات)
		/// </summary>
		[Display(Name = "نظرات")]
		public List<Comment> Comments { get; set; } = new();

		/// <summary>
		/// توضیحات کامل درباره هتل - اجباری با حداکثر 1000 کاراکتر
		/// </summary>
		[Required(ErrorMessage = "توضیحات هتل الزامی است")]
		[Display(Name = "توضیحات")]
		[StringLength(1000, ErrorMessage = "توضیحات نمی‌تواند بیش از 1000 کاراکتر باشد")]
		public string Description { get; set; }

		/// <summary>
		/// تعداد کل اتاق‌های هتل - باید بین 1 تا 1000 باشد
		/// </summary>
		[Required(ErrorMessage = "تعداد اتاق‌ها الزامی است")]
		[Display(Name = "تعداد اتاق‌ها")]
		[Range(1, 1000, ErrorMessage = "تعداد اتاق‌ها باید بین 1 تا 1000 باشد")]
		public int NumberOfRooms { get; set; }

		/// <summary>
		/// شهر محل قرارگیری هتل (از نوع Enum) - اجباری
		/// </summary>
		[Required(ErrorMessage = "شهر الزامی است")]
		[Display(Name = "شهر")]
		public City City { get; set; }
	}
}