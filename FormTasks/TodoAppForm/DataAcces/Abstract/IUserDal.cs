﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppForm.Entities.Concrete;

namespace TodoAppForm.DataAcces.Abstract
{
    public interface IUserDal
    {
        UserEntity GetUser(string username, string password);
        void Add(UserEntity data);
        List<UserEntity> GetAll();
    }
}
