using System.Collections.Generic;
using System.Linq;
using ElectronicStore.Models;

namespace ElectronicStore.Models
{
    public class FakeProductRepository:IProductRepository
    {
        public IQueryable<Product> Books => new List<Product>
        {
            new Product
            {
                Name ="Arduino Mega",
                Description = "Hardware module",
                Price = 57 ,
                Category ="Microcontrolador"
            },
            new Product
            {
                Name ="Arduino Uno",
                Description = "Hardware module",
                Price = 57 ,
                Category ="Microcontrolador"
            },
            new Product
            {
                Name ="Arduino Mega",
                Description = "Hardware module",
                Price = 57 ,
                Category ="Electronica de potencia"
            }
        }.AsQueryable<Product>();
    }
}