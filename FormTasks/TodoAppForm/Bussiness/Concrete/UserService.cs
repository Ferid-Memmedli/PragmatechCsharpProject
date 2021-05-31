using System;
using System.Collections.Generic;
using System.Linq;
using TodoAppForm.Bussiness.Abstract;
using TodoAppForm.DataAcces.Abstract;
using TodoAppForm.Entities.Concrete;

namespace TodoAppForm.Bussiness.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;  // Base Class olmalidi
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(UserEntity data)
        {
            _userDal.Add(data);
        }  //user : UserEntity datasi DataBase Add Olunur
        public List<UserEntity> GetAll()
        {
            return _userDal.GetAll();
        }  // DataBaseden melumatlarin cagrilmasi
        public UserEntity GetUser(string username, string password)
        {
            return _userDal.GetUser(username, password);
        }  //DataBase-den Useri tapmaq
    }
}
