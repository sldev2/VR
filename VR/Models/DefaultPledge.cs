using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class DefaultPledge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string TemplateNoTargetRegion { get; set; }
        public string TemplateNotIncumbent { get; set; }
        public string TemplateNotIncumbentNoTargetRegion { get; set; }
        public int PledgeType { get; set; }
    }
}
