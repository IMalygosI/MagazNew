using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaz
{
    public class List
    {
        public List<Product> Product = new List<Product>()
        {
            new Product("МЯСО", 1000, "Продукты", 0, $"default_image.jpg"),
            new Product("Телевизор", 1000, "Техника", 1, $"TV.jpg"),
            new Product("Пальто", 100000, "Одежда", 2, $"default_image.jpg"),
            new Product("Ноутбук", 12000, "Техника", 3, $"nout.jpg"),
            new Product("Ручки", 1000, "Канцелярия", 4, $"rycka.jpg"),
            new Product("Куртка", 100000, "Одежда", 5, $"kyrtka.jpg"),
            new Product("Мак", 100, "Продукты", 6, $"default_image.jpg")
        };
        public List<Product> korzinaa = new List<Product>(){};
    }
}
