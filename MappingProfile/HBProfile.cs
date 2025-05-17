using AutoMapper;
using HotelResevation.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTOs.HotelBookingDTO.HBDTO;

namespace MappingProfile
{
	public class HBProfile : Profile
	{
		public HBProfile()
		{
			CreateMap<HotelBookingCreateDto, HotelBooking>()
				   .ForMember(dest => dest.DateTimeBooked, opt => opt.MapFrom(src => DateTime.Now));

			// مپینگ از UpdateDto به مدل برای بروزرسانی رزرو (فیلدهای null نادیده گرفته می‌شوند)
			CreateMap<HotelBookingUpdateDto, HotelBooking>()
				.ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

			// مپینگ از مدل به ReadDto برای نمایش رزرو
			CreateMap<HotelBooking, HotelBookingReadDto>();

		}
	}
}
