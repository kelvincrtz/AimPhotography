using System;
using System.Collections.Generic;
using System.Text;

namespace AimPhotography.Data.Models
{
    public class BlogPostImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogPostId { get; set; }
        public string ImageUrl { get; set; }
    }
}