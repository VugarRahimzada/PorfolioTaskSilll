using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int  CountryId { get; set; }
        public Country Country { get; set; }
    }
}
