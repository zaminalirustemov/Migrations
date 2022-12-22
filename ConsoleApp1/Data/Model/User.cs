using ConsoleApp1.Data.Base;
using ConsoleApp1.Data.Contexts;
using ConsoleApp1.Data.Interfaces;
using ConsoleApp1.Data.Static;
using ConsoleApp1.Utils.Exc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Model
{

    public class User : IBaseEntity, IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public UserStatusEnum Status { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Username} {Phone} {Status}";
        }


        public void EditUserById(int id,string name, string surname)
        {
            using (AppDbContext appdbcontext = new AppDbContext())
            {
                if (id == null)
                {
                    throw new NullUserException();
                }
                else
                {
                    User user = appdbcontext.Users.Find(1);
                    user.Name=name;
                    user.Surname=surname;
                    appdbcontext.Users.Update(user);
                    appdbcontext.SaveChanges();
                }
            }
        }

        public void Edit(User user)
        {
            using (AppDbContext appdbcontext = new AppDbContext())
            {
                appdbcontext.Users.Update(user);
                appdbcontext.SaveChanges();
            }
        }

        public void RemoveAll()
        {
            AppDbContext appdbcontext = new AppDbContext();
            appdbcontext.Users.RemoveRange(appdbcontext.Users.ToList());
            appdbcontext.SaveChanges();

        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new NullUserException();
            }
            else
            {
                using (AppDbContext appdbcontext = new AppDbContext())
                {
                    appdbcontext.Users.Add(user);
                    appdbcontext.SaveChanges();
                }
            }
        }

        public List<User> GetAll()
        {
            AppDbContext appdbcontext = new AppDbContext();
            List<User> users = appdbcontext.Users.ToList();
            return users;
        }

        public User GetById(int id)
        {
            AppDbContext appdbcontext = new AppDbContext();
            User user = appdbcontext.Users.FirstOrDefault(user => user.Id == id);
            if (user == null)
            {
                throw new NullUserException();
            }
            return user;
        }

        public void RemoveById(int id)
        {
            AppDbContext appdbcontext = new AppDbContext();
            User user = appdbcontext.Users.Find(id);
            if (user != null)
            {
                appdbcontext.Users.Remove(user);
            }
            appdbcontext.SaveChanges();


            foreach (var item in appdbcontext.Users)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Username} {item.Phone} {item.Status}");
            }
        }
    }
}
