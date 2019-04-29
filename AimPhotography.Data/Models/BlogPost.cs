using System;
using System.Collections.Generic;
using System.Text;

namespace AimPhotography.Data.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual IEnumerable<BlogPostImage> BlogImages { get; set; }
    }
}