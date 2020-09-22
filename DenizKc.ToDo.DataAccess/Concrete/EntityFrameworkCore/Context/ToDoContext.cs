using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using DenizKC.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class ToDoContext:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KDK0AO7;DataBase=TODO2;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new GorevMap());
            base.OnModelCreating(modelBuilder);
        }
       
        public DbSet<Gorev> Gorevler { get; set; }
    }
}
