using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class House
    {
        public House()
        {
            this.Opponents = new List<Opponent>();
            this.Targets = new List<Target>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbr2 { get; set; }
        public string Abbr3 { get; set; }
        public virtual ICollection<Opponent> Opponents { get; set; }
        public virtual ICollection<Target> Targets { get; set; }
    }
}
