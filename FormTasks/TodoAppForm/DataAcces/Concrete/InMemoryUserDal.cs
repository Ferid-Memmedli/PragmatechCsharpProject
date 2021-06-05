using System;
using System.Collections.Generic;
using System.Linq;
using TodoAppForm.DataAcces.Abstract;
using TodoAppForm.Entities.Concrete;

namespace TodoAppForm.DataAcces.Concrete
{
    public class InMemoryUserDal : IUserDal
    {
        private static readonly List<UserEntity> _userEntities;  //Virtual DataBase
        static InMemoryUserDal()
        {
            _userEntities = new List<UserEntity>
            {
                new UserEntity {Id = Guid.NewGuid(), Username = "user", Password = "12"}
            };
        } //InMemoryUserDal Instance alinan zaman Virtual DataBase-de Instance almaq ve UserData yerlesdirmeq
        public UserEntity GetUser(string username, string password)
        {
            return _userEntities.SingleOrDefault(i => i.Username == username && i.Password == password);
        } //DataBase-den Useri tapmaq
        public List<UserEntity> GetAll()
        {
            return _userEntities;
        }  //Virtual DataBase List Qaytarir
        public void Add(UserEntity data)
        {
            _userEntities.Add(data);
        } // DataBase Yeni User Elave edir
    }
}
