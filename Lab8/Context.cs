using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Lab8
{
    public class Context : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-BV1FJHR6;Database=User;Trusted_Connection=True;");
        }
       // public Context(DbContextOptions<Context> options)
       //: base(options)
       // {  public Context context = new Context();
       // context.Database.EnsureCreated(); }
    }
}