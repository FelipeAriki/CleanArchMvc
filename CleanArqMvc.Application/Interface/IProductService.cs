using CleanArqMvc.Application.DTOs;
using CleanArqMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllAsync();
        Task<ProductDTO> GetByIdAsync(int id);
        Task<ProductDTO> GetProductCategoryAsync(int id);
        Task CreateAsync(ProductDTO productDTO);
        Task UpdateAsync(ProductDTO productDTO);
        Task DeleteAsync(int id);
    }
}
