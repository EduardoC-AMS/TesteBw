using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }   
    }
}