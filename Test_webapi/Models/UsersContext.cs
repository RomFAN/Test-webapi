using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_webapi.Models
{
    public class UsersContext: DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
    : base(options)
        { }

        public DbSet<User> User { get; set; }
     //   public DbSet<Post> Posts { get; set; }
    }
}
