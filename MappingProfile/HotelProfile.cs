using AutoMapper;
using HotelResevation.Domain.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTOs.HotelDTO.HotelDTO;

namespace MappingProfile
{
	public class HotelProfile : Profile
	{
		public HotelProfile() 
		{
			// مپینگ ایجاد هتل از DTO به مدل
			CreateMap<HotelCreateDto, Hotel>();

			// مپینگ به‌روزرسانی هتل از DTO به مدل (فیلدهای null نادیده گرفته می‌شوند)
			CreateMap<HotelUpdateDto, Hotel>()
				.ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

			// مپینگ مدل به DTO خواندنی برای نمایش اطلاعات هتل
			CreateMap<Hotel, HotelReadDto>();

		}
	}
}
