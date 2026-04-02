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
            CreateMap<Survey, SurveyDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<QuestionOption, QuestionOptionDto>().ReverseMap();
        }
    }
}