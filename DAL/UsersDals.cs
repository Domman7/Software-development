using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UsersDal : IUsersDal
    {
        private List<User> users = new List<User>() {
            new User() { Id = 1, Name = "Ivan", Login = "QQQ", Password= "12345", RegistrationDate = new DateTime(2015, 7, 20)}
        };

        public User GetById(int id)
        {
            return users.FirstOrDefault(item => item.Id == id);
        }
        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(item => item.Name == login);
        }
    }
}