using PorfolioTask.DataAccessLayer.Abstract;
using PorfolioTask.DataAccessLayer.Db;
using PorfolioTask.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.DataAccessLayer.Conrete
{
    public class UserRepository : IUserRepository
    {
        Context c = new Context();
        public void Add(User entity)
        {
            c.Users.Add(entity);
            c.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = c.Users.FirstOrDefault(x => x.Id == id);
            c.Users.Remove(value);
            c.SaveChanges();
        }

        public User GetById(int id)
        {
            var value = c.Users.FirstOrDefault(x => x.Id == id);
            return value;
        }

        public List<User> GetAll()
        {
            return c.Users.ToList();
        }
        public List<User> GetActiveAll()
        {
            return c.Users.Where(x=>x.isDelete==0).ToList();
        }


        public void Update(User entity)
        {
            var value = c.Users.FirstOrDefault(x => x.Id == entity.Id);
            value.Name= entity.Name;
            value.Title= entity.Title;
            value.Description= entity.Description;
            value.ProfileImageUrl = entity.ProfileImageUrl;
            c.SaveChanges();
        }
        
        public void SoftDelete(int id)
        {
            var value = GetById(id);

            if (value!=null)
            {
                if (value.isDelete==0)
                {
                    value.isDelete = value.Id;
                    c.SaveChanges();
                }
            }
        }
    }
}
