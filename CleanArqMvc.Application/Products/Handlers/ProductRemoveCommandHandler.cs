using CleanArqMvc.Application.Products.Commands;
using CleanArqMvc.Domain.Entities;
using CleanArqMvc.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Application.Products.Handlers
{
    public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        public ProductRemoveCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            if(product == null)
            {
                throw new ApplicationException($"Entity could not be found");
            }
            else
            {
                var result = await _productRepository.DeleteAsync(request.Id);
                return result;
            }
        }
    }
}
