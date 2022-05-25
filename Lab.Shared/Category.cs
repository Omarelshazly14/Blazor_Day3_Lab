using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Shared
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3,ErrorMessage ="Name must be greater than 3 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\w+\.(png|jpg|jpeg)$")]
        public string Image { get; set; }

        //Navigation Properties
        public virtual List<Product> Products { get; set; }
    }
}
