using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S50Games.Web.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public double ProfitLoss { get; set; } = 0.0;

        //Navigation properties
        [Required]
        public Player Player { get; set; }

        [Required]
        public Stage Stage { get; set; }
    }
}
