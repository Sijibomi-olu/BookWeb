using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;
using BookWeb.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Data
{
    public class BookWebDataContext : DbContext
    {
        public BookWebDataContext(DbContextOptions<BookWebDataContext> options) : base(options)
        {
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Characteristics> Characteristics { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
