using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAretheChampions.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        [Required]
        public int TeamId { get; set; }

        [Required, MaxLength(100)]
        public string TeamName { get; set; }
        public virtual ICollection<Match> Team1Matches { get; set; }
        public virtual ICollection<Match> Team2Matches { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}
