using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class Pricing : BaseEntity
    {
        public string Title { get; set; }
        public double Money { get; set; }
        public string Icon { get; set; }
    }
}
