using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace CS_EFCore.Models
{
    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAB1-10;Initial Catalog=PersonInfoDB;Integrated Security=SSPI;");

            //base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();
            //base.OnModelCreating(modelBuilder); 
        }
    }

    

}
