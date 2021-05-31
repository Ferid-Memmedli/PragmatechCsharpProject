using System;
using System.Collections.Generic;
using System.Linq;
using TodoAppForm.Entities.Concrete;
using TodoAppForm.Enums;

namespace TodoAppForm.Bussiness.Abstract
{
    public interface ITodoService
    {         
        public int Count();
        public int Add(TodoEntity data);
        public List<TodoEntity> GetAll();
        public List<TodoEntity> GetAll(Status status);
    }
}
