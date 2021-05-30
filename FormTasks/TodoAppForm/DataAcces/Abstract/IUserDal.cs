using System;
using System.Collections.Generic;
using WinForms.TodoApp.Entities.Concrete;

namespace WinForms.TodoApp.DataAcces.Abstract
{
    public interface IUserDal
    {
        List<UserEntity> GetAll();

        void Add(UserEntity data);
    }

    public interface ITodoDal
    {
        int Count();

        int Add(TodoEntity data);
    }
}
