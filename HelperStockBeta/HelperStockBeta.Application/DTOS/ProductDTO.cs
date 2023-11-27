using HelperStockBeta.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HelperStockBeta.Application.DTOS
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Price is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "(0:C2)")]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Th Stook is Required")]
        [Range(1, 9999)]
        [DisplayName("Stook")]
        public int Stook { get; set; }

        [MaxLength(250)]
        [DisplayName("Image")]
        public string Image { get; set; }

        public Category Category { get; set; }

        [DisplayName("Categories")]
        public int CategoryId { get; set; }

    }
}
