using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Domain.Entities
{
    public sealed class Product
    {
        [Range(1, int.MaxValue, ErrorMessage = "O ID deve ser maior ou igual a 1.")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Image {  get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public Product(int id, string name, string desc, decimal price, int stock, string image)
        {
            Id = id > 0 ? id : throw new ArgumentException("O ID deve ser maior ou igual a 1.");
            Name = name;
            Description = desc;
            Price = price;
            Stock = stock;
            Image = image;
        }
    }
}
