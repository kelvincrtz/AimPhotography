using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AimPhotography.Data.Models;

namespace AimPhotography.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Blog> Blog { get; set; }
        DbSet<BlogPost> BlogPosts { get; set; }
        DbSet<BlogPostImage> BlogPostImages { get; set; }
    }
}
