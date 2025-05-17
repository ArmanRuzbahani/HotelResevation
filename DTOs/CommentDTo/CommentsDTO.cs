using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.CommentDTo
{
	public class CommentsDTO
	{
		#region CommentCreateDto
		/// <summary>
		/// دی تی او برای ساخت نظر جدید
		/// </summary>
		public class CommentCreateDto
		{
			/// <summary>
			/// محتوای نظر کاربر (الزامی، حداکثر 100 کاراکتر)
			/// </summary>
			[Required(ErrorMessage = "متن نظر نمی‌تواند خالی باشد")]
			[StringLength(100, ErrorMessage = "متن نظر نمی‌تواند بیش از 100 کاراکتر باشد")]
			public string Content { get; set; }


			/// <summary>
			/// نام و نام خانوادگی کاربر (الزامی)
			/// </summary>
			[Required(ErrorMessage = "نام و نام خانوادگی الزامی است")]
			public string UserFullName { get; set; }

			/// <summary>
			/// ایمیل کاربر (الزامی و باید معتبر باشد)
			/// </summary>
			[Required(ErrorMessage = "ایمیل الزامی است")]
			[EmailAddress(ErrorMessage = "ایمیل را به‌درستی وارد کنید")]
			[DataType(DataType.EmailAddress)]
			public string Email { get; set; }

			/// <summary>
			/// امتیاز به هتل (بین 1 تا 5، اجباری)
			/// </summary>
			[Required(ErrorMessage = "لطفاً به هتل امتیاز دهید")]
			[Range(1, 5, ErrorMessage = "امتیاز باید عددی بین 1 تا 5 باشد")]
			public int Stars { get; set; }
		}
		#endregion

		#region CommentUpdateDto
		/// <summary>
		/// دی تی او برای به‌روزرسانی نظر (تمام فیلدها اختیاری به جز Id)
		/// </summary>
		public class CommentUpdateDto
		{
			[Required(ErrorMessage = "شناسه نظر الزامی است")]
			public int Id { get; set; }

			/// <summary>
			/// محتوای نظر کاربر (حداکثر 100 کاراکتر، اختیاری)
			/// </summary>
			[StringLength(100, ErrorMessage = "متن نظر نمی‌تواند بیش از 100 کاراکتر باشد")]
			public string? Content { get; set; }

			/// <summary>
			/// نام و نام خانوادگی کاربر (اختیاری)
			/// </summary>
			public string? UserFullName { get; set; }

			/// <summary>
			/// ایمیل کاربر (اختیاری و در صورت وجود باید معتبر باشد)
			/// </summary>
			[EmailAddress(ErrorMessage = "ایمیل را به‌درستی وارد کنید")]
			[DataType(DataType.EmailAddress)]
			public string? Email { get; set; }

			

			/// <summary>
			/// امتیاز به هتل (بین 1 تا 5، اختیاری)
			/// </summary>
			[Range(1, 5, ErrorMessage = "امتیاز باید عددی بین 1 تا 5 باشد")]
			public int? Stars { get; set; }
			public bool? IsCheckedByAdmin { get; set; }
		}
		#endregion

		#region CommentReadDto
		/// <summary>
		/// دی تی او برای خواندن نظر (نمایش به کاربر)
		/// </summary>
		public class CommentReadDto
		{
			/// <summary>
			/// شناسه یکتای نظر
			/// </summary>
			public int Id { get; set; }

			/// <summary>
			/// محتوای نظر کاربر
			/// </summary>
			public string Content { get; set; }

			/// <summary>
			/// نام و نام خانوادگی کاربر
			/// </summary>
			public string UserFullName { get; set; }

			/// <summary>
			/// ایمیل کاربر
			/// </summary>
			public string Email { get; set; }

			
			/// <summary>
			/// تاریخ و زمان ایجاد نظر
			/// </summary>
			public DateTime DateTimeCreated { get; set; }

			/// <summary>
			/// امتیاز به هتل
			/// </summary>
			public int Stars { get; set; }

			public bool IsCheckedByAdmin { get; set; }
		}
		#endregion
	}
}
