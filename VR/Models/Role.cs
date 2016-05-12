using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public System.Guid RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
