using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace S50Games.Web.Models
{
    public class Stage
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Budget { get; set; }

        [StringLength(30)]
        [Required]
        public string StageId { get; set; }
        public ICollection<Candlestick> Candlesticks { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
