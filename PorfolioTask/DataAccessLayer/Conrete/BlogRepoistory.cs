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
    public class BlogRepoistory : IBlogRepoistory
    {
        Context c = new Context();
        public void Add(Blog entity)
        {
           c.Blogs.Add(entity);
           c.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return  c.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            var value = c.Blogs.FirstOrDefault(x => x.Id == id);

            return value;
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void IncreaseCommentCounta(int id)
        {
            GetById(id).Comment++;
            //var value = c.Blogs.FirstOrDefault(x => x.Id == id);
            //value.Comment++;
            c.SaveChanges();
        }
        public void IncreaseLikeCounta(int id)
        {
            GetById(id).Like++;
            c.SaveChanges();
        }
        public void DecreaseLikeCounta(int id)
        {
            GetById(id).Like--;
            c.SaveChanges();
        }
    }
}
