using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAretheChampions.Models
{
    [Table ("Player")]
    public class Player
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }

        [Required, MaxLength(50)]
        public string PlayerName { get; set; }
        public virtual Team Team { get; set; }

    }
}
