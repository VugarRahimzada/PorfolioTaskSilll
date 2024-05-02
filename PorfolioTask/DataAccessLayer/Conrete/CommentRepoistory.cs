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
    public class CommentRepoistory : ICommentRepository
    {
        Context c = new Context();
        public void Add(Comment entity)
        {
            c.Comments.Add(entity);
            c.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }
        public int Counta(int id)
        {
            var value = c.Comments.Where(x=>x.BlogId == id).Count();
            return value;
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
