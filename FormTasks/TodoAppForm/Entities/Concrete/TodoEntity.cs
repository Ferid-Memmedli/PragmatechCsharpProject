using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppForm.Entities.Abstract;
using TodoAppForm.Enums;

namespace TodoAppForm.Entities.Concrete
{
    public class TodoEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int ImportanceLevel { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
