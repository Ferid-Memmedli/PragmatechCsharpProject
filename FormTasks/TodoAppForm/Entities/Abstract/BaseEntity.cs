using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppForm.Entities.Abstract
{
    public abstract class BaseEntity
    {

    }

    public abstract class BaseEntity<T> : BaseEntity, IEntity<T>
    {
        public T Id { get; set; }
    }
}
