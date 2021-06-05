using System;
using System.Collections.Generic;
using System.Linq;
using TodoAppForm.Entities.Concrete;

namespace TodoAppForm.Bussiness.Abstract
{
    public interface IUserService
    {
        UserEntity GetUser(string username, string password);
        void Add(UserEntity data);
        List<UserEntity> GetAll();
    }
}
