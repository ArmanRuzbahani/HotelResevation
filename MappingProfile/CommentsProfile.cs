using AutoMapper;
using HotelResevation.Domain.Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingProfile
{
	public class CommentsProfile : Profile
	{
		public CommentsProfile()
		{
			// مپینگ از CommentCreateDto به Comment (برای ایجاد کامنت جدید)
			CreateMap<DTOs.CommentDTo.CommentsDTO.CommentCreateDto, Comment>()
				.ForMember(dest => dest.DateTimeCreated, opt => opt.MapFrom(src => DateTime.Now));

			// مپینگ از CommentUpdateDto به Comment (برای آپدیت)
			CreateMap<DTOs.CommentDTo.CommentsDTO.CommentUpdateDto, Comment>()
				.ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// مپینگ از Comment به CommentReadDto (برای نمایش)
			CreateMap<Comment, DTOs.CommentDTo.CommentsDTO.CommentReadDto>();
		}
	}
}
