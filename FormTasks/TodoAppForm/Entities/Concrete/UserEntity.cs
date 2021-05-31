using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppForm.Entities.Abstract;

namespace TodoAppForm.Entities.Concrete
{
    public class UserEntity : BaseEntity<Guid>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
