using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicStore.Models.Extensions
{
    public static class ProductExtension
    {
        public static decimal? TotalPriceExtension(this IEnumerable<Product> productos)
        {
            return productos.Sum(b => b?.Price??0);
        }
    }
}
