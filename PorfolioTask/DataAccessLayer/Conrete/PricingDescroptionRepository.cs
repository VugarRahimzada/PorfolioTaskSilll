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
    public class PricingDescroptionRepository : IPricingDescriptionRepository
    {
        Context c = new Context();

        public void Add(PricingDescription entity)
        {
            c.PricingDescriptions.Add(entity);
            c.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = c.PricingDescriptions.FirstOrDefault(x => x.Id == id);
            c.PricingDescriptions.Remove(value);
            c.SaveChanges();
        }

        public List<PricingDescription> GetAll()
        {
            var data = c.PricingDescriptions.Include(x=>x.Pricings).ToList();
            return data;
      
        } 
        
        public List<PricingDescription> GetByChoos(int id)
        {
            var data = c.PricingDescriptions.Include(x=>x.Pricings).Where(x=>x.PricingId==id).ToList();
            return data;
        }

        public PricingDescription GetById(int id)
        {
            var value = c.PricingDescriptions.FirstOrDefault(x => x.Id == id);
            return value;
        }

        public void Update(PricingDescription entity)
        {
            var value = c.PricingDescriptions.FirstOrDefault(x => x.Id == entity.Id);
            value.Description = entity.Description;
            value.PricingId = entity.PricingId;
            c.SaveChanges();
        }
    }
}
