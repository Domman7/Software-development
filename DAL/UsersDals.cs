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
            new User() { Id = 1, Name = "Ivan", Age = 20, Phone = "1" },
            new User() { Id = 2, Name = "Anton", Age = 21, Phone = "2" },
            new User() { Id = 3, Name = "Egor", Age = 22, Phone = "3" },
            new User() { Id = 4, Name = "Andrew", Age = 24, Phone = "4" },
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