using System;
using System.Collections.Generic;
using System.Text;

namespace AimPhotography.Data.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public IEnumerable<BlogPost> BlogPosts { get; set; }

    }
}
