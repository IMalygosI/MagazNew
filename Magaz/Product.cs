using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaz
{
    public class Product
    {
        private string NameProduct;
        private double praiseProduct;
        private string typeProduct;
        private string sourse;
        private int ids = 0;
        public Product(string Name, double Prise, string type, int id, string Image_sourse)
        {
            NameProduct = Name;
            praiseProduct = Prise;
            typeProduct = type;
            sourse = Image_sourse;
        }
        public double PraiseProduct
        {
            get { return praiseProduct; }
            set { praiseProduct = value; }
        }
        public string ProductName
        {
            get { return NameProduct; }
            set { NameProduct = value; }
        }
        public string TypeProduct
        {
            get { return typeProduct; }
            set { typeProduct = value; }
        }
        public int Id
        {
            get { return ids; }
            set { ids = value; }
        }
        public string Sourse
        {
            get { return sourse; }
            set { sourse = value; }
        }
        public Bitmap? image => Sourse != null ? new Bitmap($"Asset/{Sourse}") : new Bitmap($"Asset/default_image.jpg");
    }
}