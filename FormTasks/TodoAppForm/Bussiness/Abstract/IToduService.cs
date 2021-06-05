using System;
using System.Collections.Generic;
using System.Linq;
using TodoAppForm.Entities.Concrete;
using TodoAppForm.Enums;

namespace TodoAppForm.Bussiness.Abstract
{
    public interface ITodoService
    {         
        int Count();
        int Add(TodoEntity data);
        List<TodoEntity> GetAll();
        List<TodoEntity> GetAll(Status status);
        List<TodoEntity> GetAll(ImportanceLevel importanceLevel);
    }
}
