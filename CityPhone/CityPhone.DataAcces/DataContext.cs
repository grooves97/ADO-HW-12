namespace CityPhone.DataAcces
{
    using CityPhone.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
         public DbSet<City> Cities { get; set; }
        public DbSet<Number> Numbers { get; set; }
    }
}