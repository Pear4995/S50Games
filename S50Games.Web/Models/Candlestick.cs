using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace S50Games.Web.Models
{
    public class Candlestick
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float O { get; set; }
        public float H { get; set; }
        public float L { get; set; }
        public float C { get; set; }

        [Required]
        public Stage Stage { get; set; }
    }
}
