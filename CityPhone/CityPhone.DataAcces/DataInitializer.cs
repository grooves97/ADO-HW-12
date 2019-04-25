using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CityPhone.Models;

namespace CityPhone.DataAcces
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<City> cities;

            cities = new List<City>
            {
                new City
                {
                    Name="Астана",
                    Code = 7172
                },

                new City
                {
                    Name="Тараз",
                    Code = 7262
                },

                new City
                {
                    Name="Палодар",
                    Code = 7182
                },

                new City
                {
                    Name="Шымкент",
                    Code = 7252
                },

                new City
                {
                    Name="Актау",
                    Code = 7213
                }
            };

            context.Cities.AddRange(cities);
            base.Seed(context);
        }
    }
}
