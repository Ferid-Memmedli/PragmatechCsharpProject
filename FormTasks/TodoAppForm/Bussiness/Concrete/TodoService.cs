using System;
using System.Collections.Generic;
using System.Linq;
using TodoAppForm.Bussiness.Abstract;
using TodoAppForm.DataAcces.Abstract;
using TodoAppForm.Entities.Concrete;
using TodoAppForm.Enums;

namespace TodoAppForm.Bussiness.Concrete
{
    public class TodoService : ITodoService
    {
        private readonly ITodoDal _todoDal;  //Base Class Olmalidi
        public TodoService(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }
        public int Add(TodoEntity data)
        {
            return _todoDal.Add(data);
        }  //Virtual DataBase Data Add Edir.Returun olaraq : 1 qaytarir eks teqdirde : 0
        public int Count()
        {
            return _todoDal.Count();
        }   //DataBase Daxilinde Data Sayi Qaytarir
        public List<TodoEntity> GetAll()
        {
            return _todoDal.GetAll();
        }   //Virtual DataBase List Qaytarir
        public List<TodoEntity> GetAll(Status status)
        {
            return _todoDal.GetAll(status);
        }  //DataBase-den Userleri Statusuna uygun filtirlemeq ve List qaytarmaq
        public List<TodoEntity> GetAll(ImportanceLevel importanceLevel)
        {
            return _todoDal.GetAll(importanceLevel);
        }   //DataBase-den Userleri ImportanceLevel uygun filtirlemeq ve List qaytarmaq
    }
}
