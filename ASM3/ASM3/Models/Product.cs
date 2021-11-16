using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Cat_ID { get; set; }
        public Category Category { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public int Price { get; set; }

        public string Unit { get; set; }
    }
}
