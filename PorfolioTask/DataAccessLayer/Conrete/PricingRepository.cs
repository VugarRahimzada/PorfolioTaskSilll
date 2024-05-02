using Microsoft.EntityFrameworkCore;
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
    public class PricingRepository : IPricingRepository
    {
        Context c = new Context();

        public void Add(Pricing entity)
        {
            c.Pricings.Add(entity);
            c.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = c.Pricings.FirstOrDefault(x => x.Id == id);
            c.Pricings.Remove(value);
            c.SaveChanges();
        }

        public List<Pricing> GetAll()
        {
            return c.Pricings.ToList();
            
        }

        public Pricing GetById(int id)
        {
            var value = c.Pricings.FirstOrDefault(x => x.Id == id);
            return value;
        }

        public void Update(Pricing entity)
        {
            var value = c.Pricings.FirstOrDefault(x => x.Id == entity.Id);
            value.Title = entity.Title;
            value.Money = entity.Money;
            value.Icon = entity.Icon;
            c.SaveChanges();
        }
    }
}
