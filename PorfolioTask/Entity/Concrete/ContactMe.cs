using PorfolioTask.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.Entity.Concrete
{
    public class ContactMe : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactMessage { get; set; } 
    }
}
