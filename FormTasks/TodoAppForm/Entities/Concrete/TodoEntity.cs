using System;
using System.ComponentModel;
using System.Linq;
using TodoAppForm.Entities.Abstract;
using TodoAppForm.Enums;

namespace TodoAppForm.Entities.Concrete
{
    public class TodoEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }

        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [DisplayName("Importance Level")]
        public ImportanceLevel ImportanceLevel { get; set; }

        public Status Status { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
