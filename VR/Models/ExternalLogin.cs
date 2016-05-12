using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class ExternalLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public System.Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
