using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public List<City> Citys { get; set; }
    }
}
