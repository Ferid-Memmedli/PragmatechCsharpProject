using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppForm.DataAcces.Abstract;
using TodoAppForm.Entities.Concrete;
using TodoAppForm.Enums;

namespace TodoAppForm.DataAcces.Concrete
{
    public class InMemoryTodoDal : ITodoDal
    {
        private static readonly List<TodoEntity> _todoEntities;  //Virtual DataBase
        static InMemoryTodoDal()
        {
            _todoEntities = new List<TodoEntity>();
        }   //InMemoryTodoDal Instance alinan zaman Virtual DataBase-de Instance almaq
        public int Count()
        {
            return _todoEntities.Count;
        }  //Virtual DataBase Daxilinde Data Sayi Qaytarir
        public int Add(TodoEntity data)
        {
            int result;
            try
            {
                _todoEntities.Add(data);
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
                throw;
            }
            return result;
        }  //Virtual DataBase Data Add Edir.Returun olaraq : 1 qaytarir eks teqdirde : 0
        public List<TodoEntity> GetAll()
        {
            return _todoEntities;
        }   //Virtual DataBase List Qaytarir
        public List<TodoEntity> GetAll(Status status)
        {
            return _todoEntities.Where(i => i.Status == status).ToList();
        }   //DataBase-den Userleri Statusuna uygun filtirlemeq ve List qaytarmaq
        public List<TodoEntity> GetAll(ImportanceLevel importanceLevel)
        {
            return _todoEntities.Where(i => i.ImportanceLevel == importanceLevel).ToList();
        }  //DataBase-den Userleri ImportanceLevel uygun filtirlemeq ve List qaytarmaq
    }
}
