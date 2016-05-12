using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Poss
    {
        public Poss()
        {
            this.Campaigns = new List<Campaign>();
            this.PosseMembershipDetails = new List<PosseMembershipDetail>();
            this.Posses1 = new List<Poss>();
            this.Posses11 = new List<Poss>();
            this.Posses12 = new List<Poss>();
            this.Posses13 = new List<Poss>();
        }

        public int Id { get; set; }
        public string Info { get; set; }
        public string Name { get; set; }
        public int TargetId { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> PosseId { get; set; }
        public string ZipCode1 { get; set; }
        public string Discriminator { get; set; }
        public Nullable<int> CoralinSuperPosse_Id { get; set; }
        public Nullable<int> m_CoralinPosse_Id { get; set; }
        public Nullable<int> SuperPosse_Id { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<PosseMembershipDetail> PosseMembershipDetails { get; set; }
        public virtual ICollection<Poss> Posses1 { get; set; }
        public virtual Poss Poss1 { get; set; }
        public virtual ICollection<Poss> Posses11 { get; set; }
        public virtual Poss Poss2 { get; set; }
        public virtual ICollection<Poss> Posses12 { get; set; }
        public virtual Poss Poss3 { get; set; }
        public virtual ICollection<Poss> Posses13 { get; set; }
        public virtual Poss Poss4 { get; set; }
        public virtual Target Target { get; set; }
    }
}
