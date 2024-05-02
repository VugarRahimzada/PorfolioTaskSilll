using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int isDelete { get; set; }
        public DateTime CreateTime {  get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; }
    }
}
