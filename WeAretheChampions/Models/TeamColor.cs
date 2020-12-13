using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAretheChampions.Models
{
    [Table ("TeamColor")]
    public class TeamColor
    {
        [Key]
        [ForeignKey("Team")]
        public int TeamId { get; set; }

        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public virtual Team Team { get; set; }
        public virtual Color Color { get; set; }

    }
}
