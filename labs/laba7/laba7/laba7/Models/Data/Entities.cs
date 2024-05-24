using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7.Models.Data
{
    public class Entities
    {
        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
            public int RoleId { get; set; } = 1;
            public virtual Role Role { get; set; }
        }

        public class Role
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public virtual IEnumerable<User> Users { get; set; }
        }
    }
}
