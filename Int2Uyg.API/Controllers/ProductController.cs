using AutoMapper;
using Int2Uyg.API.DTOs;
using Int2Uyg.API.Models;
using Int2Uyg.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Uyg.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;
        private readonly IMapper _mapper; 
        ResultDto _result = new ResultDto();

        public ProductController(ProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public List<ProductDto> List() 
        {
            var products = _productRepository.GetList();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        [HttpGet("{id}")]
        public ProductDto GetById(int id) 
        {
            var product = _productRepository.GetById(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        [HttpPost]
        public ResultDto Add(ProductDto modelDto) 
        {
            var product = _mapper.Map<Product>(modelDto);

            _productRepository.Add(product);
            _result.Status = true;
            _result.Message = "Kayıt Eklendi";
            return _result;
        }

        [HttpPut]
        public ResultDto Update(ProductDto modelDto) 
        {
            var product = _mapper.Map<Product>(modelDto);

            _productRepository.Update(product);
            _result.Status = true;
            _result.Message = "Kayıt Güncellendi";
            return _result;
        }

        [HttpDelete]
        public ResultDto Delete(int id)
        {
            _productRepository.Delete(id);
            _result.Status = true;
            _result.Message = "Kayıt Silindi";
            return _result;
        }
    }
}