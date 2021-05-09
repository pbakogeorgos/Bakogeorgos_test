using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Models
{
    public class Match
    {   
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime MatchDate { get; set; }
        public DateTime MatchTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }       
        public List<MatchOdd> MatchOdds { get; set; }

    }
    


}
