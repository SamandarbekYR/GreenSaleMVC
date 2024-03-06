using AutoMapper;
using GreenSaleMVC.Data.Entities.Messages;
using GreenSaleMVC.DTOs;
using GreenSaleMVC.DTOs.Messages;

namespace GreenSaleMVC.BLL.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Message, AddMessageDto>().ReverseMap();
            CreateMap<Category, AddCategoryDto>().ReverseMap();
        }
    }
}
