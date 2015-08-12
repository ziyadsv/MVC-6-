﻿using System.Collections.Generic;

namespace JustBlog.Core.Object
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}