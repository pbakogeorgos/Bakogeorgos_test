using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Models
{
    public class MatchOdd
    {   
        [Key]
        public int ID { get; set; }      
        public string Specifier { get; set; }
        public float Odd { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }

    }
}
