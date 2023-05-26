using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-REQ40DK; database=CoreBlogDb; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

        public DbSet<BlogReyting> BlogReytings { get; set; }
        public DbSet<Natification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Message2> Message2s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>().
                HasOne(x => x.SenderUser).
                WithMany(y => y.SenderWriter).
                HasForeignKey(i => i.SenderID).
                OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>().
                HasOne(x => x.ReceiverUser).
                WithMany(y => y.ReceiverWriter).
                HasForeignKey(i => i.ReceiverID).
                OnDelete(DeleteBehavior.ClientSetNull);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Blog>().
        //        HasOne(a => a.Category).
        //        WithMany(b => b.Blogs).
        //        OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<Blog>().
        //        HasMany(a => a.Comments).
        //        WithOne(b => b.Blog).
        //        HasForeignKey(i=>i.CommentID);
        //}

    }
}
