using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicStore.Models.Extensions;

namespace ElectronicStore.Models
{
    public class Repository
    {
        public static List<Product> productos = new List<Product>();
        public static IEnumerable<Product> Productos
        {
            get
            {
                return productos;
            }
        }
        public static void AddProduct(Product producto)
        {
            productos.Add(producto);
        }

        //metodos del modelo
        public static decimal? TotalPrice()
        {
            return productos.TotalPriceExtension();
        }
    }
}
