using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo3.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }

        public ICollection<Article> Articles { get; set; }


    }
}
