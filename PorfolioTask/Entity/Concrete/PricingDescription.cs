using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class PricingDescription : BaseEntity
    {
        public string Description { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricings { get; set; }
    }
}
