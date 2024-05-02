﻿using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class Comment : BaseEntity
    {
        public string Message { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
