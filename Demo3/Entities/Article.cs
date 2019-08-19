using System;

namespace Demo3.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
      
        public string Content { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}