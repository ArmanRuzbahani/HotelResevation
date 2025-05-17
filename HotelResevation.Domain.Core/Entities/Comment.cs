using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevation.Domain.Core.Entitys
{
	/// <summary>
	/// کلاس نماینده‌گر نظرات کاربران درباره هتل
	/// </summary>
	public class Comment
	{
		/// <summary>
		/// شناسه یکتای نظر
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// محتوای نظر کاربر
		/// </summary>
		[Required(ErrorMessage = "متن نظر نمی‌تواند خالی باشد")]
		[Display(Name = "متن نظر")]
		[StringLength(100, ErrorMessage = "متن نظر نمی‌تواند بیش از 100 کاراکتر باشد")]
		public string Content { get; set; }

		/// <summary>
		/// شناسه هتل مربوطه - کلید خارجی
		/// </summary>
		[Required]
		public int HotelId { get; set; }

		/// <summary>
		/// شیء هتل مربوطه - ارتباط ناوبری
		/// </summary>
		[ForeignKey("HotelId")]
		public Hotel Hotel { get; set; }

		/// <summary>
		/// نام و نام خانوادگی کاربر
		/// </summary>
		[Required(ErrorMessage = "نام و نام خانوادگی الزامی است")]
		[Display(Name = "نام و نام خانوادگی")]
		public string UserFullName { get; set; }

		/// <summary>
		/// آدرس ایمیل کاربر
		/// </summary>
		[Required(ErrorMessage = "ایمیل الزامی است")]
		[Display(Name = "ایمیل")]
		[EmailAddress(ErrorMessage = "ایمیل را به‌درستی وارد کنید")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		/// <summary>
		/// وضعیت تایید/بررسی نظر توسط ادمین
		/// </summary>
		public bool IsCheckedByAdmin { get; set; } = false;

		/// <summary>
		/// تاریخ و زمان ایجاد نظر - به‌صورت پیش‌فرض زمان حال تنظیم می‌شود
		/// </summary>
		public DateTime DateTimeCreated { get; set; } = DateTime.Now;

		/// <summary>
		/// امتیاز داده شده به هتل (بین 1 تا 5)
		/// </summary>
		[Required(ErrorMessage = "لطفاً به هتل امتیاز دهید")]
		[Range(1, 5, ErrorMessage = "امتیاز باید عددی بین 1 تا 5 باشد")]
		public int Stars { get; set; }
	}
}