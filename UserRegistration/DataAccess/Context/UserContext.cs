using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
  public  class UserContext:DbContext
    {
        public UserContext() { }
       
        public DbSet<User> users { set; get; }
        public DbSet<Department> departments { set; get; }
        public DbSet<Employee> employees { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=UserDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
