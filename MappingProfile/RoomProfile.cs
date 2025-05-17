using AutoMapper;
using DTOs.RoomDTO;
using HotelResevation.Domain.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingProfile
{
	public class RoomProfile : Profile
	{
		public RoomProfile()
		{
			// مپینگ از CreateDto به مدل
			CreateMap<RoomDTO.RoomCreateDto, Room>();

			// مپینگ از UpdateDto به مدل (فیلدهای null نادیده گرفته می‌شوند)
			CreateMap<RoomDTO.RoomUpdateDto, Room>()
				.ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

			// مپینگ از مدل به ReadDto
			CreateMap<Room, RoomDTO.RoomReadDto>();
		}
	}
}
