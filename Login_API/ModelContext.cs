//using Microsoft.EntityFrameworkCore;
//using Project_DiChoThue.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DiChoThue
//{
//    public partial class ModelContext : DbContext
//    {
//        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
//        {
//        }

//        public DbSet<Shipper> Shipper { get; set; }
//        //public object Shipper { get; internal set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Shipper>().ToTable("Shipper");
           
//        }
//    }
//}
