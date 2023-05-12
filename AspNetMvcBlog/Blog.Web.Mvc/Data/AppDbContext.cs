using Blog.Web.Mvc.Models.Concreta;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Web.Mvc.Models.Data.Entity
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "Server = COSKUNFAMILY\\SQLEXPRESS; database=AspNetMvcBlogDB;";
            builder.UseSqlServer(connectionString);
            base.OnConfiguring(builder);
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<CategoryPost> categoryPosts { get; set; }
        public DbSet<Page> pages { get; set; }
        public DbSet<Post> posts  { get; set; }
        public DbSet<PostComment> postComments  { get; set; }
        public DbSet<PostImage>  postImages  { get; set; }
        public DbSet<Setting>  settings  { get; set; }
        public DbSet<User>  users  { get; set; }



    }
}
