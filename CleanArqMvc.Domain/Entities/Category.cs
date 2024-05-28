using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqMvc.Domain.Entities
{
    public sealed class Category
    {
        [Range(1, int.MaxValue, ErrorMessage = "O ID deve ser maior ou igual a 1.")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }

        public Category(int id, string name) 
        {
            Id = id > 0 ? id : throw new ArgumentException("O ID deve ser maior ou igual a 1.");
            Name = name;
        }
    }
}
