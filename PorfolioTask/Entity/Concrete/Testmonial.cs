using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class Testmonial : BaseEntity
    {
        public string Name { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Description { get; set; }
    }
}
