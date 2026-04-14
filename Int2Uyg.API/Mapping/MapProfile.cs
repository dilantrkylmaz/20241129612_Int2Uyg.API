using AutoMapper;
using Int2Uyg.API.DTOs;
using Int2Uyg.API.Models;

namespace Uyg.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Survey, SurveyDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<QuestionOption, QuestionOptionDto>().ReverseMap();
        }
    }
}