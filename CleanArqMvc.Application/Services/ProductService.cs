using AutoMapper;
using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Application.Interface;
using CleanArqMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDTO> GetProductCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
