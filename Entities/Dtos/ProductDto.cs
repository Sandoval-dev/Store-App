using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "Product Name is not empty")]
        public String? ProductName { get; init; } = String.Empty;

        [Required(ErrorMessage = "Price is not empty")]
        public decimal Price { get; init; }
        public int? CategoryId { get; init; }
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
    }
}
