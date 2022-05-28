using System.ComponentModel.DataAnnotations;
namespace NetAssessment.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName{ get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string ProductDescription { get; set; }
    }
}
