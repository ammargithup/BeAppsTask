using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDAL.Entity.Product
{
    public class Product
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name required")]
        [StringLength(200, ErrorMessage = "Maximum length is {1}")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Price required")]
        [RegularExpression(@"^\d+\.\d{0,2}$",ErrorMessage ="Enter price like 1000.00 ")]
        [Range(1, 9999999999999999.99,ErrorMessage ="Can't set Price to 0 ")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Image Url required")]
        public string ImageUrl { get; set; }
    }
}
