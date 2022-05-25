using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Shared
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3, ErrorMessage = "Name must be greater than 3 characters")]
        public string Name { get; set; }
        [Required]
        [Range(500.0,5000.0)]
        public decimal Price { get; set; }
        [Required]
        [RegularExpression(@"^\w+\.(png|jpg|jpeg)$")]
        public string Image { get; set; }

        //Foriegn Key
        [ForeignKey("Category")]
        public int Cat_ID { get; set; }

        //Navigation Properties
        public virtual Category Category { get; set; }
    }
}
