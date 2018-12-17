using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Productos { get; }
    }
}
