using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM3.Models
{
    public class Category
    {
        public int ID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
