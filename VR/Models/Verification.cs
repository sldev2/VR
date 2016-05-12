using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Verification
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string PicturesUrl { get; set; }
        public int PledgeCommitmentId { get; set; }
        public string VideoUrl { get; set; }
        public virtual PledgeCommitment PledgeCommitment { get; set; }
    }
}
