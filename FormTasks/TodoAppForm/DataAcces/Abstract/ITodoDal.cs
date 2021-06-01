using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppForm.Entities.Concrete;
using TodoAppForm.Enums;

namespace TodoAppForm.DataAcces.Abstract
{
    public interface ITodoDal
    {
        int Count();
        int Add(TodoEntity data);
        List<TodoEntity> GetAll();
        List<TodoEntity> GetAll(Status status);
        List<TodoEntity> GetAll(ImportanceLevel importanceLevel);
    }
}
