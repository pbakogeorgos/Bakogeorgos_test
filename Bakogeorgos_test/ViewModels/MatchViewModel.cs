using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.ViewModels
{
    public class MatchViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime MatchDate { get; set; }
        public DateTime MatchTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public Sports Sport { get; set; }
    }

    public enum Sports { Football, Basketball }
}
