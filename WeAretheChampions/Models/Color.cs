using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAretheChampions.Models
{
    [Table("Color")]
    public class Color
    {
        [Key]
        [Required]
        public int RenkId { get; set; }
        public string ColorName { get; set; }
    }
}
