
// es un error pensar q los modelos son tablas, solo algunos...solo van a base de datos los que vamos a persisit
namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}
