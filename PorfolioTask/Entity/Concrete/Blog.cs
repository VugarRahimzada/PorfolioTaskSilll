using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class Blog : BaseEntity
    {
            public string Title { get; set; }
            public string Writer { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public int Like { get; set; } = 0;
            public int Comment { get; set; } = 0;
        
    }
}
