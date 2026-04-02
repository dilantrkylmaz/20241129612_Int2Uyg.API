using AutoMapper;
using Int2Uyg.API.DTOs;
using Int2Uyg.API.Models;
using Int2Uyg.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Int2Uyg.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AnswerController : ControllerBase
    {
        private readonly AnswerRepository _answerRepository;
        private readonly IMapper _mapper;
        ResultDto _result = new ResultDto();

        public AnswerController(AnswerRepository answerRepository, IMapper mapper)
        {
            _answerRepository = answerRepository;
            _mapper = mapper;
        }

        // Bir sorunun cevaplarını listeler
        [HttpGet("{questionId}")]
        public async Task<List<AnswerDto>> GetAnswersByQuestion(int questionId)
        {
            var answers = await _answerRepository.GetAllAsync();
            var filteredAnswers = answers.Where(a => a.QuestionId == questionId).ToList();
            return _mapper.Map<List<AnswerDto>>(filteredAnswers);
        }

        // Soruya yeni cevap ekler (Her üye cevap verebilir)
        [HttpPost]
        public async Task<ResultDto> Add(AnswerDto dto)
        {
            var answer = _mapper.Map<Answer>(dto);
            await _answerRepository.AddAsync(answer);
            _result.Status = true;
            _result.Message = "Cevabınız başarıyla kaydedildi.";
            return _result;
        }

        // Kötü/Spam cevabı siler (Sadece Admin silebilir)
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ResultDto> Delete(int id)
        {
            await _answerRepository.DeleteAsync(id);
            _result.Status = true;
            _result.Message = "Cevap silindi.";
            return _result;
        }
    }
}