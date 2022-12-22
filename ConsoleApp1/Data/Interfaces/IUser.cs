using ConsoleApp1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Interfaces
{
    public interface IUser
    {
        void AddUser(User user);
        User GetById(int id);
        List<User> GetAll();
        void EditUserById(int id, string name, string surname);
        void Edit(User user);
        void RemoveById(int id);
        void RemoveAll();
    }
}
